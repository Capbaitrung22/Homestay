namespace Homestaylist
{
    partial class HomestayList
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnCreate = new System.Windows.Forms.ToolStripMenuItem();
            this.btnUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRefesh = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDisplay = new System.Windows.Forms.ToolStripMenuItem();
            this.grdHomelist = new System.Windows.Forms.DataGridView();
            this.lblhomestayown = new System.Windows.Forms.Label();
            this.cbxhomestayown = new System.Windows.Forms.ComboBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtdem = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdHomelist)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCreate,
            this.btnUpdate,
            this.btnDelete,
            this.btnRefesh,
            this.btnDisplay});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(796, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnCreate
            // 
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(64, 24);
            this.btnCreate.Text = "Create";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(70, 24);
            this.btnUpdate.Text = "Update";
            // 
            // btnDelete
            // 
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(65, 24);
            this.btnDelete.Text = "Delete";
            // 
            // btnRefesh
            // 
            this.btnRefesh.Name = "btnRefesh";
            this.btnRefesh.Size = new System.Drawing.Size(65, 24);
            this.btnRefesh.Text = "Refesh";
            // 
            // btnDisplay
            // 
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(70, 24);
            this.btnDisplay.Text = "Display";
            // 
            // grdHomelist
            // 
            this.grdHomelist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdHomelist.Location = new System.Drawing.Point(13, 103);
            this.grdHomelist.Name = "grdHomelist";
            this.grdHomelist.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.grdHomelist.RowTemplate.Height = 24;
            this.grdHomelist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdHomelist.Size = new System.Drawing.Size(771, 353);
            this.grdHomelist.TabIndex = 1;
            // 
            // lblhomestayown
            // 
            this.lblhomestayown.AutoSize = true;
            this.lblhomestayown.Location = new System.Drawing.Point(23, 64);
            this.lblhomestayown.Name = "lblhomestayown";
            this.lblhomestayown.Size = new System.Drawing.Size(100, 17);
            this.lblhomestayown.TabIndex = 2;
            this.lblhomestayown.Text = "Homestay own";
            // 
            // cbxhomestayown
            // 
            this.cbxhomestayown.FormattingEnabled = true;
            this.cbxhomestayown.Location = new System.Drawing.Point(141, 61);
            this.cbxhomestayown.Name = "cbxhomestayown";
            this.cbxhomestayown.Size = new System.Drawing.Size(149, 24);
            this.cbxhomestayown.TabIndex = 3;
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(320, 64);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(58, 17);
            this.lblTotal.TabIndex = 93;
            this.lblTotal.Text = "TOTAL:";
            // 
            // txtdem
            // 
            this.txtdem.Location = new System.Drawing.Point(399, 61);
            this.txtdem.Margin = new System.Windows.Forms.Padding(4);
            this.txtdem.Name = "txtdem";
            this.txtdem.Size = new System.Drawing.Size(68, 22);
            this.txtdem.TabIndex = 94;
            // 
            // HomestayList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 511);
            this.Controls.Add(this.txtdem);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.cbxhomestayown);
            this.Controls.Add(this.lblhomestayown);
            this.Controls.Add(this.grdHomelist);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "HomestayList";
            this.Text = "Homestaylist";
            this.Load += new System.EventHandler(this.grdHomelist);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdHomelist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnCreate;
        private System.Windows.Forms.ToolStripMenuItem btnUpdate;
        private System.Windows.Forms.ToolStripMenuItem btnDelete;
        private System.Windows.Forms.ToolStripMenuItem btnRefesh;
        private System.Windows.Forms.ToolStripMenuItem btnDisplay;
        private System.Windows.Forms.DataGridView grdHomelist;
        private System.Windows.Forms.Label lblhomestayown;
        private System.Windows.Forms.ComboBox cbxhomestayown;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtdem;
    }
}

