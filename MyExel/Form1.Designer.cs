namespace MyExel
{
    partial class MyExel
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyExel));
            this.InputBox = new System.Windows.Forms.TextBox();
            this.AddRowBotton = new System.Windows.Forms.Button();
            this.DeleteRowBotton = new System.Windows.Forms.Button();
            this.AddColumnBotton = new System.Windows.Forms.Button();
            this.DeleteColumnBotton = new System.Windows.Forms.Button();
            this.DGVTable = new System.Windows.Forms.DataGridView();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ApplyBottom = new System.Windows.Forms.Button();
            this.addRowMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteRowMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addColumnMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteColumnMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.DGVTable)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // InputBox
            // 
            this.InputBox.Location = new System.Drawing.Point(12, 40);
            this.InputBox.Name = "InputBox";
            this.InputBox.Size = new System.Drawing.Size(346, 27);
            this.InputBox.TabIndex = 0;
            this.InputBox.TextChanged += new System.EventHandler(this.InputBox_TextChanged);
            // 
            // AddRowBotton
            // 
            this.AddRowBotton.Location = new System.Drawing.Point(483, 39);
            this.AddRowBotton.Name = "AddRowBotton";
            this.AddRowBotton.Size = new System.Drawing.Size(115, 29);
            this.AddRowBotton.TabIndex = 2;
            this.AddRowBotton.Text = "Add row";
            this.AddRowBotton.UseVisualStyleBackColor = true;
            this.AddRowBotton.Click += new System.EventHandler(this.AddRowBotton_Click);
            // 
            // DeleteRowBotton
            // 
            this.DeleteRowBotton.Location = new System.Drawing.Point(604, 38);
            this.DeleteRowBotton.Name = "DeleteRowBotton";
            this.DeleteRowBotton.Size = new System.Drawing.Size(115, 29);
            this.DeleteRowBotton.TabIndex = 3;
            this.DeleteRowBotton.Text = "Delete row";
            this.DeleteRowBotton.UseVisualStyleBackColor = true;
            this.DeleteRowBotton.Click += new System.EventHandler(this.DeleteRowBotton_Click);
            // 
            // AddColumnBotton
            // 
            this.AddColumnBotton.Location = new System.Drawing.Point(725, 38);
            this.AddColumnBotton.Name = "AddColumnBotton";
            this.AddColumnBotton.Size = new System.Drawing.Size(115, 29);
            this.AddColumnBotton.TabIndex = 4;
            this.AddColumnBotton.Text = "Add column";
            this.AddColumnBotton.UseVisualStyleBackColor = true;
            this.AddColumnBotton.Click += new System.EventHandler(this.AddColumnBotton_Click);
            // 
            // DeleteColumnBotton
            // 
            this.DeleteColumnBotton.Location = new System.Drawing.Point(846, 39);
            this.DeleteColumnBotton.Name = "DeleteColumnBotton";
            this.DeleteColumnBotton.Size = new System.Drawing.Size(115, 29);
            this.DeleteColumnBotton.TabIndex = 5;
            this.DeleteColumnBotton.Text = "Delete column";
            this.DeleteColumnBotton.UseVisualStyleBackColor = true;
            this.DeleteColumnBotton.Click += new System.EventHandler(this.DeleteColumnBotton_Click);
            // 
            // DGVTable
            // 
            this.DGVTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVTable.Location = new System.Drawing.Point(12, 93);
            this.DGVTable.Name = "DGVTable";
            this.DGVTable.RowHeadersWidth = 51;
            this.DGVTable.Size = new System.Drawing.Size(949, 339);
            this.DGVTable.TabIndex = 6;
            this.DGVTable.Text = "dataGridView1";
            this.DGVTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVTable_CellClick);
            this.DGVTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVTable_CellContentClick);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.newToolStripMenuItem.Text = "&New";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.openToolStripMenuItem.Text = "&Open";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.saveToolStripMenuItem.Text = "&Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.saveAsToolStripMenuItem.Text = "Save &As";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.printToolStripMenuItem.Text = "&Print";
            // 
            // printPreviewToolStripMenuItem
            // 
            this.printPreviewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
            this.printPreviewToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.printPreviewToolStripMenuItem.Text = "Print Pre&view";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.exitToolStripMenuItem.Text = "E&xit";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // customizeToolStripMenuItem
            // 
            this.customizeToolStripMenuItem.Name = "customizeToolStripMenuItem";
            this.customizeToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.customizeToolStripMenuItem.Text = "&Customize";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.optionsToolStripMenuItem.Text = "&Options";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(974, 28);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem2,
            this.openToolStripMenuItem2,
            this.toolStripSeparator3,
            this.saveToolStripMenuItem2,
            this.saveAsToolStripMenuItem2,
            this.toolStripSeparator4,
            this.exitToolStripMenuItem2});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem2
            // 
            this.newToolStripMenuItem2.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem2.Image")));
            this.newToolStripMenuItem2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripMenuItem2.Name = "newToolStripMenuItem2";
            this.newToolStripMenuItem2.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem2.Size = new System.Drawing.Size(181, 26);
            this.newToolStripMenuItem2.Text = "&New";
            // 
            // openToolStripMenuItem2
            // 
            this.openToolStripMenuItem2.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem2.Image")));
            this.openToolStripMenuItem2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem2.Name = "openToolStripMenuItem2";
            this.openToolStripMenuItem2.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem2.Size = new System.Drawing.Size(181, 26);
            this.openToolStripMenuItem2.Text = "&Open";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(178, 6);
            // 
            // saveToolStripMenuItem2
            // 
            this.saveToolStripMenuItem2.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem2.Image")));
            this.saveToolStripMenuItem2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem2.Name = "saveToolStripMenuItem2";
            this.saveToolStripMenuItem2.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem2.Size = new System.Drawing.Size(181, 26);
            this.saveToolStripMenuItem2.Text = "&Save";
            // 
            // saveAsToolStripMenuItem2
            // 
            this.saveAsToolStripMenuItem2.Name = "saveAsToolStripMenuItem2";
            this.saveAsToolStripMenuItem2.Size = new System.Drawing.Size(181, 26);
            this.saveAsToolStripMenuItem2.Text = "Save &As";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(178, 6);
            // 
            // exitToolStripMenuItem2
            // 
            this.exitToolStripMenuItem2.Name = "exitToolStripMenuItem2";
            this.exitToolStripMenuItem2.Size = new System.Drawing.Size(181, 26);
            this.exitToolStripMenuItem2.Text = "E&xit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addRowMenuItem,
            this.deleteRowMenuItem,
            this.addColumnMenuItem,
            this.deleteColumnMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.CheckOnClick = true;
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutMenuItem
            // 
            this.aboutMenuItem.Name = "aboutMenuItem";
            this.aboutMenuItem.Size = new System.Drawing.Size(142, 26);
            this.aboutMenuItem.Text = "&About...";
            this.aboutMenuItem.Click += new System.EventHandler(this.aboutMenuItem_Click);
            // 
            // ApplyBottom
            // 
            this.ApplyBottom.Location = new System.Drawing.Point(364, 39);
            this.ApplyBottom.Name = "ApplyBottom";
            this.ApplyBottom.Size = new System.Drawing.Size(115, 29);
            this.ApplyBottom.TabIndex = 8;
            this.ApplyBottom.Text = "Apply";
            this.ApplyBottom.UseVisualStyleBackColor = true;
            this.ApplyBottom.Click += new System.EventHandler(this.ApplyBottom_Click);
            // 
            // addRowMenuItem
            // 
            this.addRowMenuItem.Name = "addRowMenuItem";
            this.addRowMenuItem.Size = new System.Drawing.Size(191, 26);
            this.addRowMenuItem.Text = "Add Row";
            this.addRowMenuItem.Click += new System.EventHandler(this.addRowMenuItem_Click);
            // 
            // deleteRowMenuItem
            // 
            this.deleteRowMenuItem.Name = "deleteRowMenuItem";
            this.deleteRowMenuItem.Size = new System.Drawing.Size(191, 26);
            this.deleteRowMenuItem.Text = "Delete Row";
            this.deleteRowMenuItem.Click += new System.EventHandler(this.deleteRowMenuItem_Click);
            // 
            // addColumnMenuItem
            // 
            this.addColumnMenuItem.Name = "addColumnMenuItem";
            this.addColumnMenuItem.Size = new System.Drawing.Size(191, 26);
            this.addColumnMenuItem.Text = "Add Column";
            this.addColumnMenuItem.Click += new System.EventHandler(this.addColumnMenuItem_Click);
            // 
            // deleteColumnMenuItem
            // 
            this.deleteColumnMenuItem.Name = "deleteColumnMenuItem";
            this.deleteColumnMenuItem.Size = new System.Drawing.Size(191, 26);
            this.deleteColumnMenuItem.Text = "Delete Column";
            this.deleteColumnMenuItem.Click += new System.EventHandler(this.deleteColumnMenuItem_Click);
            // 
            // MyExel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 444);
            this.Controls.Add(this.ApplyBottom);
            this.Controls.Add(this.DGVTable);
            this.Controls.Add(this.DeleteColumnBotton);
            this.Controls.Add(this.AddColumnBotton);
            this.Controls.Add(this.DeleteRowBotton);
            this.Controls.Add(this.AddRowBotton);
            this.Controls.Add(this.InputBox);
            this.Controls.Add(this.menuStrip1);
            this.Name = "MyExel";
            this.Text = "MyExel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MyExel_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVTable)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InputBox;
        private System.Windows.Forms.Button AddRowBotton;
        private System.Windows.Forms.Button DeleteRowBotton;
        private System.Windows.Forms.Button AddColumnBotton;
        private System.Windows.Forms.Button DeleteColumnBotton;
        private System.Windows.Forms.DataGridView DGVTable;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printPreviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutMenuItem;
        private System.Windows.Forms.Button ApplyBottom;
        private System.Windows.Forms.ToolStripMenuItem addRowMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteRowMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addColumnMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteColumnMenuItem;
    }
}

