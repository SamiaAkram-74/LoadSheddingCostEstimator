using System;
using System.Data;
using System.Windows.Forms;
using LoadSheddingCostEstimator.Database;
using LoadSheddingCostEstimator.Models;   // ← Model namespace

namespace LoadSheddingCostEstimator.Forms
{
    public partial class UsageForm : Form
    {
        public UsageForm()
        {
            InitializeComponent();
        }

        private void UsageForm_Load(object sender, EventArgs e)
        {
            LoadOutages();
            LoadAppliances();
            LoadUsageTable();
        }

        void LoadOutages()
        {
            string query = @"SELECT OutageID, StartTime || ' - ' || EndTime AS DisplayText 
                             FROM OutageLogs 
                             WHERE UserID=@uid";

            DataTable dt = DBHelper.GetDataTable(query,
                DBHelper.Param("@uid", LoginForm.LoggedInUserID));

            cmbOutage.DataSource    = dt;
            cmbOutage.DisplayMember = "DisplayText";
            cmbOutage.ValueMember   = "OutageID";
        }

        void LoadAppliances()
        {
            DataTable dt = DBHelper.GetDataTable(
                "SELECT ApplianceID, ApplianceName FROM Appliances");

            cmbAppliance.DataSource    = dt;
            cmbAppliance.DisplayMember = "ApplianceName";
            cmbAppliance.ValueMember   = "ApplianceID";
        }

        void LoadUsageTable()
        {
            string query = @"
SELECT u.UsageID,
       u.OutageID,
       u.ApplianceID,
       o.StartTime,
       a.ApplianceName,
       u.HoursUsed
FROM UsageLogs u
JOIN OutageLogs  o ON u.OutageID    = o.OutageID
JOIN Appliances  a ON u.ApplianceID = a.ApplianceID
WHERE o.UserID=@uid";

            DataTable dt = DBHelper.GetDataTable(query,
                DBHelper.Param("@uid", LoginForm.LoggedInUserID));

            dgvUsage.DataSource = dt;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmbOutage.SelectedIndex == -1 || cmbAppliance.SelectedIndex == -1 || txtHours.Text == "")
            {
                MessageBox.Show("Fill all fields");
                return;
            }

            if (!double.TryParse(txtHours.Text, out double hours))
            {
                MessageBox.Show("Invalid hours value");
                return;
            }

            try
            {
                // ✅ UsageLog MODEL object banao
                UsageLog usage = new UsageLog
                {
                    OutageID    = Convert.ToInt32(cmbOutage.SelectedValue),
                    ApplianceID = Convert.ToInt32(cmbAppliance.SelectedValue),
                    HoursUsed   = hours
                };

                // Model se INSERT karo
                string query = @"INSERT INTO UsageLogs 
                                 (OutageID, ApplianceID, HoursUsed)
                                 VALUES (@o, @a, @h)";

                DBHelper.ExecuteNonQuery(query,
                    DBHelper.Param("@o", usage.OutageID),
                    DBHelper.Param("@a", usage.ApplianceID),
                    DBHelper.Param("@h", usage.HoursUsed));

                // Loss calculate karo — OutageID model se lo
                DashboardForm.SaveLoss(usage.OutageID);

                MessageBox.Show("Usage Saved + Loss Calculated!");
                ClearFields();
                LoadUsageTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvUsage.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a record first");
                return;
            }

            if (cmbOutage.SelectedIndex == -1 || cmbAppliance.SelectedIndex == -1 || txtHours.Text == "")
            {
                MessageBox.Show("Fill all fields");
                return;
            }

            if (!double.TryParse(txtHours.Text, out double hours))
            {
                MessageBox.Show("Invalid hours value");
                return;
            }

            try
            {
                // ✅ UsageLog MODEL object banao — ID bhi include karo
                UsageLog usage = new UsageLog
                {
                    UsageID     = Convert.ToInt32(dgvUsage.SelectedRows[0].Cells["UsageID"].Value),
                    OutageID    = Convert.ToInt32(cmbOutage.SelectedValue),
                    ApplianceID = Convert.ToInt32(cmbAppliance.SelectedValue),
                    HoursUsed   = hours
                };

                // Model se UPDATE karo
                string query = @"
        UPDATE UsageLogs
        SET OutageID=@o,
            ApplianceID=@a,
            HoursUsed=@h
        WHERE UsageID=@id";

                DBHelper.ExecuteNonQuery(query,
                    DBHelper.Param("@o",  usage.OutageID),
                    DBHelper.Param("@a",  usage.ApplianceID),
                    DBHelper.Param("@h",  usage.HoursUsed),
                    DBHelper.Param("@id", usage.UsageID));

                // Recalculate loss — model ka OutageID use karo
                DashboardForm.SaveLoss(usage.OutageID);

                MessageBox.Show("Updated Successfully!");
                ClearFields();
                LoadUsageTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvUsage.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a record first");
                return;
            }

            // ✅ UsageLog MODEL object banao — sirf ID ke liye
            UsageLog usage = new UsageLog
            {
                UsageID = Convert.ToInt32(dgvUsage.SelectedRows[0].Cells["UsageID"].Value)
            };

            DBHelper.ExecuteNonQuery(
                "DELETE FROM UsageLogs WHERE UsageID=@id",
                DBHelper.Param("@id", usage.UsageID));

            MessageBox.Show("Deleted!");
            LoadUsageTable();
        }

        private void dgvUsage_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvUsage.Rows[e.RowIndex]; // Clicked row

                // ✅ Grid row ko UsageLog MODEL mein map karo
                UsageLog selected = new UsageLog
                {
                    UsageID     = Convert.ToInt32(row.Cells["UsageID"].Value),
                    OutageID    = Convert.ToInt32(row.Cells["OutageID"].Value),
                    ApplianceID = Convert.ToInt32(row.Cells["ApplianceID"].Value),
                    HoursUsed   = Convert.ToDouble(row.Cells["HoursUsed"].Value)
                };

                // Model se form fields populate karo
                txtHours.Text              = selected.HoursUsed.ToString();
                cmbOutage.SelectedValue    = selected.OutageID;
                cmbAppliance.SelectedValue = selected.ApplianceID;
            }
        }

        void ClearFields()
        {
            txtHours.Clear();
            cmbOutage.SelectedIndex    = -1;
            cmbAppliance.SelectedIndex = -1;
        }

        private void btnClear_Click(object sender, EventArgs e) => ClearFields();

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
    }
}
