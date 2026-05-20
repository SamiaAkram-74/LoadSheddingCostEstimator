using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Data;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using LoadSheddingCostEstimator.Database;
using LoadSheddingCostEstimator.Models;   // ← Model namespace

namespace LoadSheddingCostEstimator.Forms
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
        }

        void LoadSummary()
        {
            lblTotalOutages.Text = "Total Outages: " +
                DBHelper.ExecuteScalar(
                    "SELECT COUNT(*) FROM OutageLogs WHERE UserID=@uid",
                    DBHelper.Param("@uid", LoginForm.LoggedInUserID));

            lblTotalCost.Text = "Total Cost/Loss: " +
                DBHelper.ExecuteScalar(@"
                    SELECT IFNULL(SUM(lr.TotalLoss), 0)
                    FROM LossRecords lr
                    JOIN OutageLogs o ON lr.OutageID = o.OutageID
                    WHERE o.UserID = @uid",
                    DBHelper.Param("@uid", LoginForm.LoggedInUserID)) + " PKR";

            lblAvgDuration.Text = "Avg Duration: " +
                DBHelper.ExecuteScalar(
                    "SELECT IFNULL(AVG(DurationHours), 0) FROM OutageLogs WHERE UserID=@uid",
                    DBHelper.Param("@uid", LoginForm.LoggedInUserID)) + " hrs";
        }

        void LoadTable()
        {
            DataTable dt = DBHelper.GetDataTable(
                "SELECT * FROM OutageLogs WHERE UserID=@uid",
                DBHelper.Param("@uid", LoginForm.LoggedInUserID));

            dataGridView1.DataSource = dt;
        }

        void LoadChart()
        {
            chart1.Series.Clear();

            Series series = new Series("Outages");
            series.ChartType = SeriesChartType.Column;

            string query = @"
                SELECT DATE(StartTime), COUNT(*)
                FROM OutageLogs
                WHERE UserID=@uid
                GROUP BY DATE(StartTime)";

            DataTable dt = DBHelper.GetDataTable(query,
                DBHelper.Param("@uid", LoginForm.LoggedInUserID));

            foreach (DataRow row in dt.Rows)
                series.Points.AddXY(row[0].ToString(), row[1]);

            chart1.Series.Add(series);
        }

        void LoadInsights()
        {
            object total       = DBHelper.ExecuteScalar(
                "SELECT COUNT(*) FROM OutageLogs WHERE UserID=@uid",
                DBHelper.Param("@uid", LoginForm.LoggedInUserID));

            object maxDuration = DBHelper.ExecuteScalar(
                "SELECT MAX(DurationHours) FROM OutageLogs WHERE UserID=@uid",
                DBHelper.Param("@uid", LoginForm.LoggedInUserID));

            object avg         = DBHelper.ExecuteScalar(
                "SELECT AVG(DurationHours) FROM OutageLogs WHERE UserID=@uid",
                DBHelper.Param("@uid", LoginForm.LoggedInUserID));

            lblInsight.Text =
                "📊 Smart Insights:\n"  +
                "⚡ Total Outages: "    + total       + "\n" +
                "⏱ Longest Outage: "   + maxDuration  + " hrs\n" +
                "📉 Average Duration: " + avg          + " hrs";
        }

        void RefreshDashboard()
        {
            LoadSummary();
            LoadTable();
            LoadChart();
            LoadInsights();
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            try { LoadSummary();  } catch (Exception ex) { MessageBox.Show(ex.Message); }
            try { LoadTable();    } catch (Exception ex) { MessageBox.Show(ex.Message); }
            try { LoadChart();    } catch (Exception ex) { MessageBox.Show(ex.Message); }
            try { LoadInsights(); } catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        // =====================================================
        //   SaveLoss() - ✅ LossRecord MODEL use karo
        // =====================================================
        public static void SaveLoss(int outageID)
        {
            double loss = CalculateLoss(outageID);

            // ✅ LossRecord MODEL object banao
            LossRecord record = new LossRecord
            {
                OutageID   = outageID,
                TotalLoss  = loss,
                RecordDate = DateTime.Now
            };

            int exists = Convert.ToInt32(DBHelper.ExecuteScalar(
                "SELECT COUNT(*) FROM LossRecords WHERE OutageID=@o",
                DBHelper.Param("@o", record.OutageID)));

            if (exists > 0)
            {
                // Model se UPDATE karo
                DBHelper.ExecuteNonQuery(@"
                    UPDATE LossRecords 
                    SET TotalLoss=@l, RecordDate=@d 
                    WHERE OutageID=@o",
                    DBHelper.Param("@l", record.TotalLoss),
                    DBHelper.Param("@d", record.RecordDate),
                    DBHelper.Param("@o", record.OutageID));
            }
            else
            {
                // Model se INSERT karo
                DBHelper.ExecuteNonQuery(@"
                    INSERT INTO LossRecords (OutageID, TotalLoss, RecordDate) 
                    VALUES (@o, @l, @d)",
                    DBHelper.Param("@o", record.OutageID),
                    DBHelper.Param("@l", record.TotalLoss),
                    DBHelper.Param("@d", record.RecordDate));
            }
        }

        // =====================================================
        //   CalculateLoss() - ✅ Appliance MODEL use karo
        //   Formula: (HoursUsed * Wattage * Rate) / 1000
        // =====================================================
        public static double CalculateLoss(int outageID)
        {
            double totalLoss = 0;

            string query = @"
                SELECT u.HoursUsed, a.Wattage, a.Rate, a.ApplianceID, a.ApplianceName
                FROM UsageLogs u
                JOIN Appliances a ON u.ApplianceID = a.ApplianceID
                WHERE u.OutageID = @id";

            DataTable dt = DBHelper.GetDataTable(query,
                DBHelper.Param("@id", outageID));

            foreach (DataRow row in dt.Rows)
            {
                // ✅ Appliance MODEL object banao — row se populate karo
                Appliance appliance = new Appliance
                {
                    ApplianceID   = Convert.ToInt32(row["ApplianceID"]),
                    ApplianceName = row["ApplianceName"].ToString(),
                    Wattage       = Convert.ToDouble(row["Wattage"]),
                    Rate          = Convert.ToDouble(row["Rate"])
                };

                double hoursUsed = Convert.ToDouble(row["HoursUsed"]);

                // Model ki properties se loss calculate karo
                totalLoss += (hoursUsed * appliance.Wattage * appliance.Rate) / 1000.0;
            }

            return totalLoss;
        }

        // ===================== BUTTON EVENTS =====================

        private void btnAddOutage_Click(object sender, EventArgs e)
        {
            OutageForm f = new OutageForm();
            f.ShowDialog();
            RefreshDashboard();
        }

        private void btnRefresh_Click(object sender, EventArgs e) => RefreshDashboard();

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm f = new LoginForm();
            f.Show();
            this.Close();
        }

        private void btnUsage_Click(object sender, EventArgs e)
        {
            UsageForm f = new UsageForm();
            f.ShowDialog();
            RefreshDashboard();
        }

        private void btnAppliance_Click(object sender, EventArgs e)
        {
            ApplianceForm f = new ApplianceForm();
            f.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to delete.");
                return;
            }

            // ✅ OutageLog MODEL object banao — delete ke liye
            OutageLog outage = new OutageLog
            {
                OutageID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["OutageID"].Value),
                UserID   = LoginForm.LoggedInUserID
            };

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this record?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                // LossRecords pehle delete karo (foreign key)
                DBHelper.ExecuteNonQuery(
                    "DELETE FROM LossRecords WHERE OutageID=@id",
                    DBHelper.Param("@id", outage.OutageID));

                // Phir OutageLog delete karo — model ke properties se
                DBHelper.ExecuteNonQuery(
                    "DELETE FROM OutageLogs WHERE OutageID=@id AND UserID=@uid",
                    DBHelper.Param("@id",  outage.OutageID),
                    DBHelper.Param("@uid", outage.UserID));

                MessageBox.Show("Record deleted successfully.");
                RefreshDashboard();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to close?",
                "Confirm",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
                this.Close();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            try
            {
                string filePath = Path.Combine(Application.StartupPath, "LoadShedding_Report.pdf");
                Document doc = new Document(PageSize.A4);
                PdfWriter.GetInstance(doc, new FileStream(filePath, FileMode.Create));
                doc.Open();

                Paragraph title = new Paragraph("Load Shedding Cost Report\n\n",
                    FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 18));
                title.Alignment = Element.ALIGN_CENTER;
                doc.Add(title);

                doc.Add(new Paragraph("SUMMARY\n\n"));
                doc.Add(new Paragraph(lblTotalOutages.Text));
                doc.Add(new Paragraph(lblTotalCost.Text));
                doc.Add(new Paragraph(lblAvgDuration.Text));
                doc.Add(new Paragraph("\n"));

                doc.Add(new Paragraph("INSIGHTS\n\n"));
                doc.Add(new Paragraph(lblInsight.Text));
                doc.Add(new Paragraph("\n"));

                doc.Add(new Paragraph("OUTAGE CHART\n\n"));
                using (MemoryStream ms = new MemoryStream())
                {
                    chart1.SaveImage(ms, ChartImageFormat.Png);
                    iTextSharp.text.Image chartImage =
                        iTextSharp.text.Image.GetInstance(ms.ToArray());
                    chartImage.ScaleToFit(500f, 300f);
                    chartImage.Alignment = Element.ALIGN_CENTER;
                    doc.Add(chartImage);
                }

                doc.Add(new Paragraph("\nOUTAGE LOGS\n\n"));
                PdfPTable table = new PdfPTable(dataGridView1.Columns.Count);

                foreach (DataGridViewColumn col in dataGridView1.Columns)
                    table.AddCell(new Phrase(col.HeaderText));

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (!row.IsNewRow)
                        foreach (DataGridViewCell cell in row.Cells)
                            table.AddCell(cell.Value?.ToString() ?? "");
                }

                doc.Add(table);
                doc.Close();

                MessageBox.Show("Report with chart generated successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void lblAvgDuration_Click(object sender, EventArgs e) { }
    }
}
