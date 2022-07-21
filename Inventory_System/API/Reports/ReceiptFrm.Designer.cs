namespace Inventory_System.API.Reports
{
    partial class ReceiptFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReceiptFrm));
            this.crpReceiptView = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crpReceiptView
            // 
            this.crpReceiptView.ActiveViewIndex = -1;
            this.crpReceiptView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crpReceiptView.Cursor = System.Windows.Forms.Cursors.Default;
            this.crpReceiptView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crpReceiptView.Location = new System.Drawing.Point(0, 0);
            this.crpReceiptView.Name = "crpReceiptView";
            this.crpReceiptView.ShowGotoPageButton = false;
            this.crpReceiptView.ShowPageNavigateButtons = false;
            this.crpReceiptView.ShowRefreshButton = false;
            this.crpReceiptView.ShowTextSearchButton = false;
            this.crpReceiptView.Size = new System.Drawing.Size(607, 520);
            this.crpReceiptView.TabIndex = 0;
            this.crpReceiptView.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // ReceiptFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(607, 520);
            this.Controls.Add(this.crpReceiptView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReceiptFrm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sales Receipt";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crpReceiptView;
    }
}