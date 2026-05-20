namespace LoadSheddingCostEstimator.Forms
{
    partial class UsageForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbOutage = new System.Windows.Forms.ComboBox();
            this.cmbAppliance = new System.Windows.Forms.ComboBox();
            this.txtHours = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgvUsage = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsage)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(42, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Outage";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(42, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select Appliance";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(42, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hours Used";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(635, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 20);
            this.label5.TabIndex = 4;
            // 
            // cmbOutage
            // 
            this.cmbOutage.BackColor = System.Drawing.SystemColors.Control;
            this.cmbOutage.FormattingEnabled = true;
            this.cmbOutage.Location = new System.Drawing.Point(219, 75);
            this.cmbOutage.Name = "cmbOutage";
            this.cmbOutage.Size = new System.Drawing.Size(134, 28);
            this.cmbOutage.TabIndex = 9;
            // 
            // cmbAppliance
            // 
            this.cmbAppliance.BackColor = System.Drawing.SystemColors.Control;
            this.cmbAppliance.FormattingEnabled = true;
            this.cmbAppliance.Items.AddRange(new object[] {
            "TV",
            "Washing machine",
            "Oven",
            "Freezer",
            "Pump",
            "Fan",
            "AC",
            "Bulb"});
            this.cmbAppliance.Location = new System.Drawing.Point(218, 112);
            this.cmbAppliance.Name = "cmbAppliance";
            this.cmbAppliance.Size = new System.Drawing.Size(134, 28);
            this.cmbAppliance.TabIndex = 10;
            // 
            // txtHours
            // 
            this.txtHours.BackColor = System.Drawing.SystemColors.Control;
            this.txtHours.Location = new System.Drawing.Point(217, 154);
            this.txtHours.Name = "txtHours";
            this.txtHours.Size = new System.Drawing.Size(135, 26);
            this.txtHours.TabIndex = 11;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.Control;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSave.Location = new System.Drawing.Point(34, 186);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(319, 38);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save Usage";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.Control;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnClear.Location = new System.Drawing.Point(34, 273);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(318, 49);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.Control;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnDelete.Location = new System.Drawing.Point(35, 328);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(317, 45);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dgvUsage
            // 
            this.dgvUsage.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvUsage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsage.Location = new System.Drawing.Point(395, 75);
            this.dgvUsage.Name = "dgvUsage";
            this.dgvUsage.RowHeadersWidth = 62;
            this.dgvUsage.RowTemplate.Height = 28;
            this.dgvUsage.Size = new System.Drawing.Size(678, 347);
            this.dgvUsage.TabIndex = 15;
            this.dgvUsage.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsage_CellClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Font = new System.Drawing.Font("Bauhaus 93", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(387, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(233, 45);
            this.label4.TabIndex = 16;
            this.label4.Text = "Usage Form";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.Control;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnClose.Location = new System.Drawing.Point(35, 379);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(318, 46);
            this.btnClose.TabIndex = 17;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.Control;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnUpdate.Location = new System.Drawing.Point(35, 230);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(317, 37);
            this.btnUpdate.TabIndex = 18;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // UsageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1085, 450);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvUsage);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtHours);
            this.Controls.Add(this.cmbAppliance);
            this.Controls.Add(this.cmbOutage);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UsageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "UsageForm";
            this.Load += new System.EventHandler(this.UsageForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbOutage;
        private System.Windows.Forms.ComboBox cmbAppliance;
        private System.Windows.Forms.TextBox txtHours;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvUsage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnUpdate;
    }
}