
namespace XMLToHTML
{
    partial class Form1
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
            this.NameCheckBox = new System.Windows.Forms.CheckBox();
            this.CountryCheckBox = new System.Windows.Forms.CheckBox();
            this.YearOfIssueCheckBox = new System.Windows.Forms.CheckBox();
            this.MainCaliberCheckBox = new System.Windows.Forms.CheckBox();
            this.ArmorCheckBox = new System.Windows.Forms.CheckBox();
            this.WeightCheckBox = new System.Windows.Forms.CheckBox();
            this.NameComboBox = new System.Windows.Forms.ComboBox();
            this.CountryComboBox = new System.Windows.Forms.ComboBox();
            this.YearOfIssueComboBox = new System.Windows.Forms.ComboBox();
            this.MainCaliberComboBox = new System.Windows.Forms.ComboBox();
            this.ArmorComboBox = new System.Windows.Forms.ComboBox();
            this.WeightComboBox = new System.Windows.Forms.ComboBox();
            this.SAXButton = new System.Windows.Forms.RadioButton();
            this.LINQButton = new System.Windows.Forms.RadioButton();
            this.DOMButton = new System.Windows.Forms.RadioButton();
            this.LoadButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.СlearBotton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.MainTextBox = new System.Windows.Forms.RichTextBox();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // NameCheckBox
            // 
            this.NameCheckBox.AutoSize = true;
            this.NameCheckBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NameCheckBox.Location = new System.Drawing.Point(12, 35);
            this.NameCheckBox.Name = "NameCheckBox";
            this.NameCheckBox.Size = new System.Drawing.Size(78, 27);
            this.NameCheckBox.TabIndex = 0;
            this.NameCheckBox.Text = "Name";
            this.NameCheckBox.UseVisualStyleBackColor = true;
            this.NameCheckBox.CheckedChanged += new System.EventHandler(this.NameCheckBox_CheckedChanged);
            // 
            // CountryCheckBox
            // 
            this.CountryCheckBox.AutoSize = true;
            this.CountryCheckBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CountryCheckBox.Location = new System.Drawing.Point(12, 70);
            this.CountryCheckBox.Name = "CountryCheckBox";
            this.CountryCheckBox.Size = new System.Drawing.Size(93, 27);
            this.CountryCheckBox.TabIndex = 1;
            this.CountryCheckBox.Text = "Country";
            this.CountryCheckBox.UseVisualStyleBackColor = true;
            this.CountryCheckBox.CheckedChanged += new System.EventHandler(this.CountryCheckBox_CheckedChanged);
            // 
            // YearOfIssueCheckBox
            // 
            this.YearOfIssueCheckBox.AutoSize = true;
            this.YearOfIssueCheckBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.YearOfIssueCheckBox.Location = new System.Drawing.Point(12, 104);
            this.YearOfIssueCheckBox.Name = "YearOfIssueCheckBox";
            this.YearOfIssueCheckBox.Size = new System.Drawing.Size(126, 27);
            this.YearOfIssueCheckBox.TabIndex = 2;
            this.YearOfIssueCheckBox.Text = "Year of issue";
            this.YearOfIssueCheckBox.UseVisualStyleBackColor = true;
            this.YearOfIssueCheckBox.CheckedChanged += new System.EventHandler(this.YearOfIssueCheckBox_CheckedChanged);
            // 
            // MainCaliberCheckBox
            // 
            this.MainCaliberCheckBox.AutoSize = true;
            this.MainCaliberCheckBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MainCaliberCheckBox.Location = new System.Drawing.Point(12, 138);
            this.MainCaliberCheckBox.Name = "MainCaliberCheckBox";
            this.MainCaliberCheckBox.Size = new System.Drawing.Size(125, 27);
            this.MainCaliberCheckBox.TabIndex = 3;
            this.MainCaliberCheckBox.Text = "Main caliber";
            this.MainCaliberCheckBox.UseVisualStyleBackColor = true;
            this.MainCaliberCheckBox.CheckedChanged += new System.EventHandler(this.MainCaliberCheckBox_CheckedChanged);
            // 
            // ArmorCheckBox
            // 
            this.ArmorCheckBox.AutoSize = true;
            this.ArmorCheckBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ArmorCheckBox.Location = new System.Drawing.Point(12, 172);
            this.ArmorCheckBox.Name = "ArmorCheckBox";
            this.ArmorCheckBox.Size = new System.Drawing.Size(80, 27);
            this.ArmorCheckBox.TabIndex = 4;
            this.ArmorCheckBox.Text = "Armor";
            this.ArmorCheckBox.UseVisualStyleBackColor = true;
            this.ArmorCheckBox.CheckedChanged += new System.EventHandler(this.ArmorCheckBox_CheckedChanged);
            // 
            // WeightCheckBox
            // 
            this.WeightCheckBox.AutoSize = true;
            this.WeightCheckBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WeightCheckBox.Location = new System.Drawing.Point(12, 206);
            this.WeightCheckBox.Name = "WeightCheckBox";
            this.WeightCheckBox.Size = new System.Drawing.Size(86, 27);
            this.WeightCheckBox.TabIndex = 5;
            this.WeightCheckBox.Text = "Weight";
            this.WeightCheckBox.UseVisualStyleBackColor = true;
            this.WeightCheckBox.CheckedChanged += new System.EventHandler(this.WeightCheckBox_CheckedChanged);
            // 
            // NameComboBox
            // 
            this.NameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NameComboBox.Enabled = false;
            this.NameComboBox.FormattingEnabled = true;
            this.NameComboBox.Location = new System.Drawing.Point(152, 35);
            this.NameComboBox.Name = "NameComboBox";
            this.NameComboBox.Size = new System.Drawing.Size(186, 28);
            this.NameComboBox.TabIndex = 6;
            // 
            // CountryComboBox
            // 
            this.CountryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CountryComboBox.Enabled = false;
            this.CountryComboBox.FormattingEnabled = true;
            this.CountryComboBox.Location = new System.Drawing.Point(152, 69);
            this.CountryComboBox.Name = "CountryComboBox";
            this.CountryComboBox.Size = new System.Drawing.Size(186, 28);
            this.CountryComboBox.TabIndex = 7;
            // 
            // YearOfIssueComboBox
            // 
            this.YearOfIssueComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.YearOfIssueComboBox.Enabled = false;
            this.YearOfIssueComboBox.FormattingEnabled = true;
            this.YearOfIssueComboBox.Location = new System.Drawing.Point(152, 103);
            this.YearOfIssueComboBox.Name = "YearOfIssueComboBox";
            this.YearOfIssueComboBox.Size = new System.Drawing.Size(186, 28);
            this.YearOfIssueComboBox.TabIndex = 8;
            // 
            // MainCaliberComboBox
            // 
            this.MainCaliberComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MainCaliberComboBox.Enabled = false;
            this.MainCaliberComboBox.FormattingEnabled = true;
            this.MainCaliberComboBox.Location = new System.Drawing.Point(152, 137);
            this.MainCaliberComboBox.Name = "MainCaliberComboBox";
            this.MainCaliberComboBox.Size = new System.Drawing.Size(186, 28);
            this.MainCaliberComboBox.TabIndex = 9;
            // 
            // ArmorComboBox
            // 
            this.ArmorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ArmorComboBox.Enabled = false;
            this.ArmorComboBox.FormattingEnabled = true;
            this.ArmorComboBox.Location = new System.Drawing.Point(152, 171);
            this.ArmorComboBox.Name = "ArmorComboBox";
            this.ArmorComboBox.Size = new System.Drawing.Size(186, 28);
            this.ArmorComboBox.TabIndex = 10;
            // 
            // WeightComboBox
            // 
            this.WeightComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.WeightComboBox.Enabled = false;
            this.WeightComboBox.FormattingEnabled = true;
            this.WeightComboBox.Location = new System.Drawing.Point(152, 205);
            this.WeightComboBox.Name = "WeightComboBox";
            this.WeightComboBox.Size = new System.Drawing.Size(186, 28);
            this.WeightComboBox.TabIndex = 11;
            // 
            // SAXButton
            // 
            this.SAXButton.AutoSize = true;
            this.SAXButton.Location = new System.Drawing.Point(152, 267);
            this.SAXButton.Name = "SAXButton";
            this.SAXButton.Size = new System.Drawing.Size(57, 24);
            this.SAXButton.TabIndex = 12;
            this.SAXButton.Text = "SAX";
            this.SAXButton.UseVisualStyleBackColor = true;
            this.SAXButton.CheckedChanged += new System.EventHandler(this.SAXButton_CheckedChanged);
            // 
            // LINQButton
            // 
            this.LINQButton.AutoSize = true;
            this.LINQButton.Location = new System.Drawing.Point(12, 267);
            this.LINQButton.Name = "LINQButton";
            this.LINQButton.Size = new System.Drawing.Size(63, 24);
            this.LINQButton.TabIndex = 13;
            this.LINQButton.Text = "LINQ";
            this.LINQButton.UseVisualStyleBackColor = true;
            this.LINQButton.CheckedChanged += new System.EventHandler(this.LINQButton_CheckedChanged);
            // 
            // DOMButton
            // 
            this.DOMButton.AutoSize = true;
            this.DOMButton.Checked = true;
            this.DOMButton.Location = new System.Drawing.Point(273, 267);
            this.DOMButton.Name = "DOMButton";
            this.DOMButton.Size = new System.Drawing.Size(65, 24);
            this.DOMButton.TabIndex = 14;
            this.DOMButton.TabStop = true;
            this.DOMButton.Text = "DOM";
            this.DOMButton.UseVisualStyleBackColor = true;
            this.DOMButton.CheckedChanged += new System.EventHandler(this.DOMButton_CheckedChanged);
            // 
            // LoadButton
            // 
            this.LoadButton.Location = new System.Drawing.Point(12, 297);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(326, 29);
            this.LoadButton.TabIndex = 15;
            this.LoadButton.Text = "Load XML";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(11, 332);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(327, 29);
            this.SearchButton.TabIndex = 16;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // СlearBotton
            // 
            this.СlearBotton.Location = new System.Drawing.Point(11, 367);
            this.СlearBotton.Name = "СlearBotton";
            this.СlearBotton.Size = new System.Drawing.Size(327, 29);
            this.СlearBotton.TabIndex = 17;
            this.СlearBotton.Text = "Clear";
            this.СlearBotton.UseVisualStyleBackColor = true;
            this.СlearBotton.Click += new System.EventHandler(this.СlearBotton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(11, 402);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(327, 29);
            this.SaveButton.TabIndex = 18;
            this.SaveButton.Text = "Save HTML";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // MainTextBox
            // 
            this.MainTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainTextBox.Location = new System.Drawing.Point(353, 35);
            this.MainTextBox.Name = "MainTextBox";
            this.MainTextBox.Size = new System.Drawing.Size(435, 396);
            this.MainTextBox.TabIndex = 19;
            this.MainTextBox.Text = "";
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MainTextBox);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.СlearBotton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.LoadButton);
            this.Controls.Add(this.DOMButton);
            this.Controls.Add(this.LINQButton);
            this.Controls.Add(this.SAXButton);
            this.Controls.Add(this.WeightComboBox);
            this.Controls.Add(this.ArmorComboBox);
            this.Controls.Add(this.MainCaliberComboBox);
            this.Controls.Add(this.YearOfIssueComboBox);
            this.Controls.Add(this.CountryComboBox);
            this.Controls.Add(this.NameComboBox);
            this.Controls.Add(this.WeightCheckBox);
            this.Controls.Add(this.ArmorCheckBox);
            this.Controls.Add(this.MainCaliberCheckBox);
            this.Controls.Add(this.YearOfIssueCheckBox);
            this.Controls.Add(this.CountryCheckBox);
            this.Controls.Add(this.NameCheckBox);
            this.Name = "Form1";
            this.Text = "Lab2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox NameCheckBox;
        private System.Windows.Forms.CheckBox CountryCheckBox;
        private System.Windows.Forms.CheckBox YearOfIssueCheckBox;
        private System.Windows.Forms.CheckBox MainCaliberCheckBox;
        private System.Windows.Forms.CheckBox ArmorCheckBox;
        private System.Windows.Forms.CheckBox WeightCheckBox;
        private System.Windows.Forms.ComboBox CountryComboBox;
        private System.Windows.Forms.ComboBox YearOfIssueComboBox;
        private System.Windows.Forms.ComboBox MainCaliberComboBox;
        private System.Windows.Forms.ComboBox ArmorComboBox;
        private System.Windows.Forms.ComboBox WeightComboBox;
        private System.Windows.Forms.RadioButton SAXButton;
        private System.Windows.Forms.RadioButton LINQButton;
        private System.Windows.Forms.RadioButton DOMButton;
        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button СlearBotton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.RichTextBox MainTextBox;
        private System.Windows.Forms.ComboBox NameComboBox;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog;
    }
}

