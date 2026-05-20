using System;
using System.Data;
using System.Windows.Forms;
using LoadSheddingCostEstimator.Database;
using LoadSheddingCostEstimator.Models;   // ← Model namespace

namespace LoadSheddingCostEstimator.Forms
{
    public partial class ApplianceForm : Form
    {
        public ApplianceForm()
        {
            InitializeComponent();
        }

        private void ApplianceForm_Load(object sender, EventArgs e)
        {
            LoadAppliances();
        }

        void LoadAppliances()
        {
            DataTable dt = DBHelper.GetDataTable("SELECT * FROM Appliances");
            dgvAppliances.DataSource = dt;
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            if (txtApplianceName.Text == "" || txtWattage.Text == "" || txtRate.Text == "")
            {
                MessageBox.Show("Please fill all fields");
                return;
            }

            if (!double.TryParse(txtWattage.Text, out double watt) ||
                !double.TryParse(txtRate.Text,    out double rate))
            {
                MessageBox.Show("Invalid wattage or rate");
                return;
            }

            // ✅ Appliance MODEL object banao
            Appliance appliance = new Appliance
            {
                ApplianceName = txtApplianceName.Text.Trim(),
                Wattage       = watt,
                Rate          = rate
            };

            // Model se INSERT karo
            string query = @"INSERT INTO Appliances (ApplianceName, Wattage, Rate)
                             VALUES (@name, @watt, @rate)";

            DBHelper.ExecuteNonQuery(query,
                DBHelper.Param("@name", appliance.ApplianceName),
                DBHelper.Param("@watt", appliance.Wattage),
                DBHelper.Param("@rate", appliance.Rate));

            MessageBox.Show("Appliance Added Successfully!");
            ClearFields();
            LoadAppliances();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvAppliances.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an appliance first");
                return;
            }

            if (txtApplianceName.Text == "" || txtWattage.Text == "" || txtRate.Text == "")
            {
                MessageBox.Show("Please fill all fields");
                return;
            }

            if (!double.TryParse(txtWattage.Text, out double watt) ||
                !double.TryParse(txtRate.Text,    out double rate))
            {
                MessageBox.Show("Invalid wattage or rate");
                return;
            }

            // ✅ Appliance MODEL object banao — selected row se ID bhi include karo
            Appliance appliance = new Appliance
            {
                ApplianceID   = Convert.ToInt32(dgvAppliances.SelectedRows[0].Cells["ApplianceID"].Value),
                ApplianceName = txtApplianceName.Text.Trim(),
                Wattage       = watt,
                Rate          = rate
            };

            // Model se UPDATE karo
            string query = @"UPDATE Appliances
                     SET ApplianceName=@name,
                         Wattage=@watt,
                         Rate=@rate
                     WHERE ApplianceID=@id";

            DBHelper.ExecuteNonQuery(query,
                DBHelper.Param("@name", appliance.ApplianceName),
                DBHelper.Param("@watt", appliance.Wattage),
                DBHelper.Param("@rate", appliance.Rate),
                DBHelper.Param("@id",   appliance.ApplianceID));

            MessageBox.Show("Updated Successfully!");
            ClearFields();
            LoadAppliances();
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            if (dgvAppliances.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select an appliance first");
                return;
            }

            // ✅ Appliance MODEL object banao — sirf ID ke liye bhi
            Appliance appliance = new Appliance
            {
                ApplianceID = Convert.ToInt32(dgvAppliances.SelectedRows[0].Cells["ApplianceID"].Value)
            };

            DBHelper.ExecuteNonQuery(
                "DELETE FROM Appliances WHERE ApplianceID=@id",
                DBHelper.Param("@id", appliance.ApplianceID));

            MessageBox.Show("Deleted Successfully!");
            LoadAppliances();
        }

        void ClearFields()
        {
            txtApplianceName.Clear();
            txtWattage.Clear();
            txtRate.Clear();
        }

        private void btnClear_Click_1(object sender, EventArgs e) => ClearFields();

        private void dgvAppliances_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvAppliances.Rows[e.RowIndex];

                // ✅ Grid row ko Appliance MODEL mein map karo
                Appliance selected = new Appliance
                {
                    ApplianceID   = Convert.ToInt32(row.Cells["ApplianceID"].Value),
                    ApplianceName = row.Cells["ApplianceName"].Value.ToString(),
                    Wattage       = Convert.ToDouble(row.Cells["Wattage"].Value),
                    Rate          = Convert.ToDouble(row.Cells["Rate"].Value)
                };

                // Model se form fields populate karo
                txtApplianceName.Text = selected.ApplianceName;
                txtWattage.Text       = selected.Wattage.ToString();
                txtRate.Text          = selected.Rate.ToString();
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
    }
}
