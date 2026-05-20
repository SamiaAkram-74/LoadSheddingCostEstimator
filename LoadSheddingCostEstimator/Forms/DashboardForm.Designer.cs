namespace LoadSheddingCostEstimator.Forms
{
    partial class DashboardForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lblTotalOutages = new System.Windows.Forms.Label();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.lblAvgDuration = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnAddOutage = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblInsight = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnUsage = new System.Windows.Forms.Button();
            this.btnAppliance = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.sqLiteCommandBuilder1 = new System.Data.SQLite.SQLiteCommandBuilder();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTotalOutages
            // 
            this.lblTotalOutages.AutoSize = true;
            this.lblTotalOutages.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTotalOutages.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalOutages.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTotalOutages.Location = new System.Drawing.Point(382, 80);
            this.lblTotalOutages.Name = "lblTotalOutages";
            this.lblTotalOutages.Size = new System.Drawing.Size(160, 22);
            this.lblTotalOutages.TabIndex = 0;
            this.lblTotalOutages.Text = "Total Outages: 0";
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTotalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCost.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTotalCost.Location = new System.Drawing.Point(619, 80);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(220, 22);
            this.lblTotalCost.TabIndex = 1;
            this.lblTotalCost.Text = "Total Loss/Cost: 0 PKR";
            // 
            // lblAvgDuration
            // 
            this.lblAvgDuration.AutoSize = true;
            this.lblAvgDuration.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblAvgDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvgDuration.ForeColor = System.Drawing.SystemColors.Control;
            this.lblAvgDuration.Location = new System.Drawing.Point(946, 80);
            this.lblAvgDuration.Name = "lblAvgDuration";
            this.lblAvgDuration.Size = new System.Drawing.Size(183, 22);
            this.lblAvgDuration.TabIndex = 2;
            this.lblAvgDuration.Text = "Avg Duration: 0 hrs";
            this.lblAvgDuration.Click += new System.EventHandler(this.lblAvgDuration_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(342, 142);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(585, 243);
            this.dataGridView1.TabIndex = 4;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.SystemColors.Control;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnRefresh.Location = new System.Drawing.Point(13, 223);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(261, 67);
            this.btnRefresh.TabIndex = 8;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnAddOutage
            // 
            this.btnAddOutage.BackColor = System.Drawing.SystemColors.Control;
            this.btnAddOutage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddOutage.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnAddOutage.Location = new System.Drawing.Point(13, 15);
            this.btnAddOutage.Name = "btnAddOutage";
            this.btnAddOutage.Size = new System.Drawing.Size(261, 56);
            this.btnAddOutage.TabIndex = 9;
            this.btnAddOutage.Text = "Add Outage Form";
            this.btnAddOutage.UseVisualStyleBackColor = false;
            this.btnAddOutage.Click += new System.EventHandler(this.btnAddOutage_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.SystemColors.Control;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnLogout.Location = new System.Drawing.Point(13, 502);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(261, 59);
            this.btnLogout.TabIndex = 10;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblInsight
            // 
            this.lblInsight.AutoSize = true;
            this.lblInsight.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblInsight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInsight.ForeColor = System.Drawing.SystemColors.Control;
            this.lblInsight.Location = new System.Drawing.Point(946, 142);
            this.lblInsight.Name = "lblInsight";
            this.lblInsight.Size = new System.Drawing.Size(246, 22);
            this.lblInsight.TabIndex = 11;
            this.lblInsight.Text = "Insights will appear here...";
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.chart1.BorderlineColor = System.Drawing.SystemColors.ControlDarkDark;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(292, 406);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(931, 234);
            this.chart1.TabIndex = 12;
            this.chart1.Text = "chart1";
            // 
            // btnUsage
            // 
            this.btnUsage.BackColor = System.Drawing.SystemColors.Control;
            this.btnUsage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsage.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnUsage.Location = new System.Drawing.Point(13, 147);
            this.btnUsage.Name = "btnUsage";
            this.btnUsage.Size = new System.Drawing.Size(261, 70);
            this.btnUsage.TabIndex = 13;
            this.btnUsage.Text = "Add Usage";
            this.btnUsage.UseVisualStyleBackColor = false;
            this.btnUsage.Click += new System.EventHandler(this.btnUsage_Click);
            // 
            // btnAppliance
            // 
            this.btnAppliance.BackColor = System.Drawing.SystemColors.Control;
            this.btnAppliance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAppliance.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnAppliance.Location = new System.Drawing.Point(12, 77);
            this.btnAppliance.Name = "btnAppliance";
            this.btnAppliance.Size = new System.Drawing.Size(261, 64);
            this.btnAppliance.TabIndex = 14;
            this.btnAppliance.Text = "Add Appliance";
            this.btnAppliance.UseVisualStyleBackColor = false;
            this.btnAppliance.Click += new System.EventHandler(this.btnAppliance_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Font = new System.Drawing.Font("Bauhaus 93", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(407, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(565, 45);
            this.label1.TabIndex = 15;
            this.label1.Text = "Load Shedding Cost Estimator";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.Control;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnDelete.Location = new System.Drawing.Point(13, 371);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(261, 61);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.btnReport);
            this.panel1.Controls.Add(this.btnAddOutage);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnAppliance);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnUsage);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Location = new System.Drawing.Point(-1, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(287, 586);
            this.panel1.TabIndex = 17;
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.SystemColors.Control;
            this.btnReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnReport.Location = new System.Drawing.Point(13, 296);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(260, 69);
            this.btnReport.TabIndex = 20;
            this.btnReport.Text = "Generate Report";
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.Control;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnClose.Location = new System.Drawing.Point(13, 438);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(262, 58);
            this.btnClose.TabIndex = 18;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // sqLiteCommandBuilder1
            // 
            this.sqLiteCommandBuilder1.DataAdapter = null;
            this.sqLiteCommandBuilder1.QuoteSuffix = "]";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(-1, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1265, 57);
            this.panel2.TabIndex = 19;
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1264, 652);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.lblInsight);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblAvgDuration);
            this.Controls.Add(this.lblTotalCost);
            this.Controls.Add(this.lblTotalOutages);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "DashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DashboardForm";
            this.Load += new System.EventHandler(this.DashboardForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTotalOutages;
        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.Label lblAvgDuration;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnAddOutage;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblInsight;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button btnUsage;
        private System.Windows.Forms.Button btnAppliance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClose;
        private System.Data.SQLite.SQLiteCommandBuilder sqLiteCommandBuilder1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnReport;
    }
}