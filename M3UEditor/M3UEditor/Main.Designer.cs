namespace M3UEditor
{
    partial class Main
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.mstMenue = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.cmsGrid = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToGroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chkAllChannels = new System.Windows.Forms.CheckBox();
            this.chkCreateFilePerGroup = new System.Windows.Forms.CheckBox();
            this.mstMenue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.cmsGrid.SuspendLayout();
            this.SuspendLayout();
            // 
            // mstMenue
            // 
            this.mstMenue.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.mstMenue.Location = new System.Drawing.Point(0, 0);
            this.mstMenue.Name = "mstMenue";
            this.mstMenue.Size = new System.Drawing.Size(819, 24);
            this.mstMenue.TabIndex = 0;
            this.mstMenue.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.ContextMenuStrip = this.cmsGrid;
            this.dgvData.Location = new System.Drawing.Point(12, 26);
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvData.Size = new System.Drawing.Size(795, 472);
            this.dgvData.TabIndex = 1;
            // 
            // cmsGrid
            // 
            this.cmsGrid.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToGroupToolStripMenuItem});
            this.cmsGrid.Name = "cmsGrid";
            this.cmsGrid.Size = new System.Drawing.Size(146, 26);
            // 
            // addToGroupToolStripMenuItem
            // 
            this.addToGroupToolStripMenuItem.Name = "addToGroupToolStripMenuItem";
            this.addToGroupToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.addToGroupToolStripMenuItem.Text = "Add to group";
            this.addToGroupToolStripMenuItem.Click += new System.EventHandler(this.addToGroupToolStripMenuItem_Click);
            // 
            // chkAllChannels
            // 
            this.chkAllChannels.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkAllChannels.AutoSize = true;
            this.chkAllChannels.Location = new System.Drawing.Point(12, 504);
            this.chkAllChannels.Name = "chkAllChannels";
            this.chkAllChannels.Size = new System.Drawing.Size(172, 17);
            this.chkAllChannels.TabIndex = 3;
            this.chkAllChannels.Text = "Unvisible channels with groups";
            this.chkAllChannels.UseVisualStyleBackColor = true;
            this.chkAllChannels.CheckedChanged += new System.EventHandler(this.chkAllChannels_CheckedChanged);
            // 
            // chkCreateFilePerGroup
            // 
            this.chkCreateFilePerGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkCreateFilePerGroup.AutoSize = true;
            this.chkCreateFilePerGroup.Location = new System.Drawing.Point(190, 504);
            this.chkCreateFilePerGroup.Name = "chkCreateFilePerGroup";
            this.chkCreateFilePerGroup.Size = new System.Drawing.Size(121, 17);
            this.chkCreateFilePerGroup.TabIndex = 4;
            this.chkCreateFilePerGroup.Text = "Create file per group";
            this.chkCreateFilePerGroup.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 533);
            this.Controls.Add(this.chkCreateFilePerGroup);
            this.Controls.Add(this.chkAllChannels);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.mstMenue);
            this.MainMenuStrip = this.mstMenue;
            this.Name = "Main";
            this.Text = "M3UEditor";
            this.mstMenue.ResumeLayout(false);
            this.mstMenue.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.cmsGrid.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mstMenue;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.ContextMenuStrip cmsGrid;
        private System.Windows.Forms.ToolStripMenuItem addToGroupToolStripMenuItem;
        private System.Windows.Forms.CheckBox chkAllChannels;
        private System.Windows.Forms.CheckBox chkCreateFilePerGroup;
    }
}

