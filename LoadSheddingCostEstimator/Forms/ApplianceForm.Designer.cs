namespace LoadSheddingCostEstimator.Forms
{
    partial class ApplianceForm
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
            this.txtApplianceName = new System.Windows.Forms.TextBox();
            this.txtWattage = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.dgvAppliances = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppliances)).BeginInit();
            this.SuspendLayout();
            // 
            // txtApplianceName
            // 
            this.txtApplianceName.BackColor = System.Drawing.SystemColors.Control;
            this.txtApplianceName.Location = new System.Drawing.Point(157, 72);
            this.txtApplianceName.Name = "txtApplianceName";
            this.txtApplianceName.Size = new System.Drawing.Size(111, 26);
            this.txtApplianceName.TabIndex = 0;
            // 
            // txtWattage
            // 
            this.txtWattage.BackColor = System.Drawing.SystemColors.Control;
            this.txtWattage.Location = new System.Drawing.Point(159, 116);
            this.txtWattage.Name = "txtWattage";
            this.txtWattage.Size = new System.Drawing.Size(111, 26);
            this.txtWattage.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.Control;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnAdd.Location = new System.Drawing.Point(12, 215);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(246, 41);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.Control;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnDelete.Location = new System.Drawing.Point(11, 315);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(246, 41);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.Control;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnClear.Location = new System.Drawing.Point(11, 362);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(246, 36);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click_1);
            // 
            // dgvAppliances
            // 
            this.dgvAppliances.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvAppliances.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAppliances.Location = new System.Drawing.Point(276, 72);
            this.dgvAppliances.Name = "dgvAppliances";
            this.dgvAppliances.RowHeadersWidth = 62;
            this.dgvAppliances.RowTemplate.Height = 28;
            this.dgvAppliances.Size = new System.Drawing.Size(669, 366);
            this.dgvAppliances.TabIndex = 5;
            this.dgvAppliances.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAppliances_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(12, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Appliance Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(23, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Wattage";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Font = new System.Drawing.Font("Bauhaus 93", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(296, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(299, 45);
            this.label3.TabIndex = 8;
            this.label3.Text = "Appliance Form";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.Control;
            this.btnClose.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnClose.Location = new System.Drawing.Point(11, 404);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(247, 34);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(12, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Rate(per kWh)";
            // 
            // txtRate
            // 
            this.txtRate.BackColor = System.Drawing.SystemColors.Control;
            this.txtRate.Location = new System.Drawing.Point(157, 163);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(113, 26);
            this.txtRate.TabIndex = 11;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.Control;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnUpdate.Location = new System.Drawing.Point(12, 262);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(245, 47);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // ApplianceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(957, 450);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtRate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvAppliances);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtWattage);
            this.Controls.Add(this.txtApplianceName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ApplianceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ApplianceForm";
            this.Load += new System.EventHandler(this.ApplianceForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppliances)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtApplianceName;
        private System.Windows.Forms.TextBox txtWattage;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridView dgvAppliances;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.Button btnUpdate;
    }
}