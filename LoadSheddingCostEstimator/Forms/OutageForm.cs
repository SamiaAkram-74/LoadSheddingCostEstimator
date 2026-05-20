using System;
using System.Windows.Forms;
using LoadSheddingCostEstimator.Database;
using LoadSheddingCostEstimator.Models;   // ← Model namespace

namespace LoadSheddingCostEstimator.Forms
{
    public partial class OutageForm : Form
    {
        public OutageForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime start = dtpStart.Value;
                DateTime end   = dtpEnd.Value;

                if (end <= start)
                {
                    MessageBox.Show("End time must be greater than start time!");
                    return;
                }

                // ✅ OutageLog MODEL object banao — seedha raw values nahi
                OutageLog outage = new OutageLog
                {
                    UserID        = LoginForm.LoggedInUserID,
                    StartTime     = start,
                    EndTime       = end,
                    DurationHours = (end - start).TotalHours
                };

                // Model object ki properties se INSERT karo
                string query = @"INSERT INTO OutageLogs 
                                 (UserID, StartTime, EndTime, DurationHours)
                                 VALUES (@uid, @s, @e, @d)";

                DBHelper.ExecuteNonQuery(query,
                    DBHelper.Param("@uid", outage.UserID),
                    DBHelper.Param("@s",   outage.StartTime),
                    DBHelper.Param("@e",   outage.EndTime),
                    DBHelper.Param("@d",   outage.DurationHours));

                MessageBox.Show("Outage Saved Successfully!");
                ClearFields();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        void UpdateDuration()
        {
            // ✅ OutageLog MODEL use karke duration calculate karo
            OutageLog temp = new OutageLog
            {
                StartTime = dtpStart.Value,
                EndTime   = dtpEnd.Value
            };

            if (temp.EndTime > temp.StartTime)
                txtDuration.Text = (temp.EndTime - temp.StartTime).TotalHours.ToString("0.00");
            else
                txtDuration.Text = "0";
        }

        void ClearFields()
        {
            dtpStart.Value = DateTime.Now;
            dtpEnd.Value   = DateTime.Now;
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

        private void dtpStart_ValueChanged_1(object sender, EventArgs e) => UpdateDuration();
        private void dtpEnd_ValueChanged_1(object sender, EventArgs e)   => UpdateDuration();
    }
}
