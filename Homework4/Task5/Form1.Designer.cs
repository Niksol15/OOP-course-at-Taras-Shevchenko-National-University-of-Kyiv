namespace Task5
{
    partial class OutputRhombus
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
            this.RhombusHint = new System.Windows.Forms.Label();
            this.InputDiagonals = new System.Windows.Forms.TextBox();
            this.ProccesRhombus = new System.Windows.Forms.Button();
            this.OutputRhomb = new System.Windows.Forms.Label();
            this.HintCircle = new System.Windows.Forms.Label();
            this.InputRadius = new System.Windows.Forms.TextBox();
            this.ProcessCircle = new System.Windows.Forms.Button();
            this.OutputCircle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RhombusHint
            // 
            this.RhombusHint.AutoSize = true;
            this.RhombusHint.Location = new System.Drawing.Point(0, 9);
            this.RhombusHint.Name = "RhombusHint";
            this.RhombusHint.Size = new System.Drawing.Size(179, 17);
            this.RhombusHint.TabIndex = 0;
            this.RhombusHint.Text = "Input diagonals of rhombus";
            this.RhombusHint.Click += new System.EventHandler(this.label1_Click);
            // 
            // InputDiagonals
            // 
            this.InputDiagonals.Location = new System.Drawing.Point(3, 34);
            this.InputDiagonals.Name = "InputDiagonals";
            this.InputDiagonals.Size = new System.Drawing.Size(133, 22);
            this.InputDiagonals.TabIndex = 1;
            this.InputDiagonals.TextChanged += new System.EventHandler(this.InitialA_TextChanged);
            // 
            // ProccesRhombus
            // 
            this.ProccesRhombus.Location = new System.Drawing.Point(3, 83);
            this.ProccesRhombus.Name = "ProccesRhombus";
            this.ProccesRhombus.Size = new System.Drawing.Size(133, 23);
            this.ProccesRhombus.TabIndex = 4;
            this.ProccesRhombus.Text = "Procces Rhombus";
            this.ProccesRhombus.UseVisualStyleBackColor = true;
            this.ProccesRhombus.Click += new System.EventHandler(this.button1_Click);
            // 
            // OutputRhomb
            // 
            this.OutputRhomb.AutoSize = true;
            this.OutputRhomb.Location = new System.Drawing.Point(12, 136);
            this.OutputRhomb.Name = "OutputRhomb";
            this.OutputRhomb.Size = new System.Drawing.Size(110, 17);
            this.OutputRhomb.TabIndex = 5;
            this.OutputRhomb.Text = "Output rhombus";
            this.OutputRhomb.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // HintCircle
            // 
            this.HintCircle.AutoSize = true;
            this.HintCircle.Location = new System.Drawing.Point(234, 9);
            this.HintCircle.Name = "HintCircle";
            this.HintCircle.Size = new System.Drawing.Size(82, 17);
            this.HintCircle.TabIndex = 6;
            this.HintCircle.Text = "lnput radius";
            this.HintCircle.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // InputRadius
            // 
            this.InputRadius.Location = new System.Drawing.Point(237, 34);
            this.InputRadius.Name = "InputRadius";
            this.InputRadius.Size = new System.Drawing.Size(114, 22);
            this.InputRadius.TabIndex = 7;
            // 
            // ProcessCircle
            // 
            this.ProcessCircle.Location = new System.Drawing.Point(237, 83);
            this.ProcessCircle.Name = "ProcessCircle";
            this.ProcessCircle.Size = new System.Drawing.Size(114, 23);
            this.ProcessCircle.TabIndex = 8;
            this.ProcessCircle.Text = "Procces Circle";
            this.ProcessCircle.UseVisualStyleBackColor = true;
            this.ProcessCircle.Click += new System.EventHandler(this.ProcessCircle_Click);
            // 
            // OutputCircle
            // 
            this.OutputCircle.AutoSize = true;
            this.OutputCircle.Location = new System.Drawing.Point(251, 136);
            this.OutputCircle.Name = "OutputCircle";
            this.OutputCircle.Size = new System.Drawing.Size(88, 17);
            this.OutputCircle.TabIndex = 9;
            this.OutputCircle.Text = "Output circle";
            this.OutputCircle.Click += new System.EventHandler(this.OutputCircle_Click);
            // 
            // OutputRhombus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.OutputCircle);
            this.Controls.Add(this.ProcessCircle);
            this.Controls.Add(this.InputRadius);
            this.Controls.Add(this.HintCircle);
            this.Controls.Add(this.OutputRhomb);
            this.Controls.Add(this.ProccesRhombus);
            this.Controls.Add(this.InputDiagonals);
            this.Controls.Add(this.RhombusHint);
            this.Name = "OutputRhombus";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RhombusHint;
        private System.Windows.Forms.TextBox InputDiagonals;
        private System.Windows.Forms.Button ProccesRhombus;
        private System.Windows.Forms.Label OutputRhomb;
        private System.Windows.Forms.Label HintCircle;
        private System.Windows.Forms.TextBox InputRadius;
        private System.Windows.Forms.Button ProcessCircle;
        private System.Windows.Forms.Label OutputCircle;
    }
}

