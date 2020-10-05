namespace Task4
{
    partial class TriangleForm
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
            this.InputSide = new System.Windows.Forms.TextBox();
            this.HintForUser = new System.Windows.Forms.Label();
            this.OutPut = new System.Windows.Forms.Label();
            this.ProccesTriangle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InputSide
            // 
            this.InputSide.Location = new System.Drawing.Point(29, 89);
            this.InputSide.Name = "InputSide";
            this.InputSide.Size = new System.Drawing.Size(100, 22);
            this.InputSide.TabIndex = 0;
            this.InputSide.TextChanged += new System.EventHandler(this.InputTriangle_TextChanged);
            // 
            // HintForUser
            // 
            this.HintForUser.AutoSize = true;
            this.HintForUser.Location = new System.Drawing.Point(26, 37);
            this.HintForUser.Name = "HintForUser";
            this.HintForUser.Size = new System.Drawing.Size(198, 17);
            this.HintForUser.TabIndex = 1;
            this.HintForUser.Text = "Input side of euilateral triangle";
            this.HintForUser.Click += new System.EventHandler(this.label1_Click);
            // 
            // OutPut
            // 
            this.OutPut.AutoSize = true;
            this.OutPut.Location = new System.Drawing.Point(29, 175);
            this.OutPut.Name = "OutPut";
            this.OutPut.Size = new System.Drawing.Size(0, 17);
            this.OutPut.TabIndex = 2;
            // 
            // ProccesTriangle
            // 
            this.ProccesTriangle.Location = new System.Drawing.Point(29, 128);
            this.ProccesTriangle.Name = "ProccesTriangle";
            this.ProccesTriangle.Size = new System.Drawing.Size(128, 23);
            this.ProccesTriangle.TabIndex = 3;
            this.ProccesTriangle.Text = "Procces Triangle";
            this.ProccesTriangle.UseVisualStyleBackColor = true;
            this.ProccesTriangle.Click += new System.EventHandler(this.ProccesTriangle_Click);
            // 
            // TriangleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ProccesTriangle);
            this.Controls.Add(this.OutPut);
            this.Controls.Add(this.HintForUser);
            this.Controls.Add(this.InputSide);
            this.Name = "TriangleForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.TriangleForm_Load);
            this.TextChanged += new System.EventHandler(this.InputTriangle_TextChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InputSide;
        private System.Windows.Forms.Label HintForUser;
        private System.Windows.Forms.Label OutPut;
        private System.Windows.Forms.Button ProccesTriangle;
    }
}

