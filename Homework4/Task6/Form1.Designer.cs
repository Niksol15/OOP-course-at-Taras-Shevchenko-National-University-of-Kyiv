namespace Task6
{
    partial class Form1
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
            this.Hint = new System.Windows.Forms.Label();
            this.InputTriangle = new System.Windows.Forms.TextBox();
            this.OutputRightTriangle = new System.Windows.Forms.Label();
            this.OutputIsosceles = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Hint
            // 
            this.Hint.AutoSize = true;
            this.Hint.Location = new System.Drawing.Point(12, 9);
            this.Hint.Name = "Hint";
            this.Hint.Size = new System.Drawing.Size(95, 17);
            this.Hint.TabIndex = 0;
            this.Hint.Text = "Input Triangle";
            // 
            // InputTriangle
            // 
            this.InputTriangle.Location = new System.Drawing.Point(7, 46);
            this.InputTriangle.Name = "InputTriangle";
            this.InputTriangle.Size = new System.Drawing.Size(126, 22);
            this.InputTriangle.TabIndex = 1;
            this.InputTriangle.TextChanged += new System.EventHandler(this.InputTriangle_TextChanged);
            // 
            // OutputRightTriangle
            // 
            this.OutputRightTriangle.AutoSize = true;
            this.OutputRightTriangle.Location = new System.Drawing.Point(12, 103);
            this.OutputRightTriangle.Name = "OutputRightTriangle";
            this.OutputRightTriangle.Size = new System.Drawing.Size(97, 17);
            this.OutputRightTriangle.TabIndex = 2;
            this.OutputRightTriangle.Text = "Right Triangle";
            // 
            // OutputIsosceles
            // 
            this.OutputIsosceles.AutoSize = true;
            this.OutputIsosceles.Location = new System.Drawing.Point(297, 103);
            this.OutputIsosceles.Name = "OutputIsosceles";
            this.OutputIsosceles.Size = new System.Drawing.Size(126, 17);
            this.OutputIsosceles.TabIndex = 3;
            this.OutputIsosceles.Text = "Isosceles Triangle ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.OutputIsosceles);
            this.Controls.Add(this.OutputRightTriangle);
            this.Controls.Add(this.InputTriangle);
            this.Controls.Add(this.Hint);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Hint;
        private System.Windows.Forms.TextBox InputTriangle;
        private System.Windows.Forms.Label OutputRightTriangle;
        private System.Windows.Forms.Label OutputIsosceles;
    }
}

