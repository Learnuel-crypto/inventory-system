namespace Inventory_System.API.Reports
{
    partial class ReportsFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportsFrm));
            this.crpReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crpReportViewer
            // 
            this.crpReportViewer.ActiveViewIndex = -1;
            this.crpReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crpReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.crpReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crpReportViewer.Location = new System.Drawing.Point(0, 0);
            this.crpReportViewer.Name = "crpReportViewer";
            this.crpReportViewer.Size = new System.Drawing.Size(789, 563);
            this.crpReportViewer.TabIndex = 0;
            this.crpReportViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // ReportsFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(789, 563);
            this.Controls.Add(this.crpReportViewer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReportsFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crpReportViewer;
    }
}