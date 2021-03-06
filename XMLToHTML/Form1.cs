﻿using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XMLToHTML
{
public partial class Form1 : Form
    {
        private string XMLFilePath;
        private DOMStrategy _dom = new DOMStrategy();
        private SAXStrategy _sax = new SAXStrategy();
        private LINQStratrgy _linq = new LINQStratrgy();
        private ISearch searcher;
        public Form1()
        {
            InitializeComponent();
            SaveFileDialog.DefaultExt = "html";
            OpenFileDialog.Filter = "xml files (*.xml)|*.xml";
            searcher = _dom;
        }

        private void NameCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            NameComboBox.Enabled = NameCheckBox.Checked;
        }

        private void CountryCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CountryComboBox.Enabled = CountryCheckBox.Checked;
        }

        private void YearOfIssueCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            YearOfIssueComboBox.Enabled = YearOfIssueCheckBox.Checked;
        }

        private void MainCaliberCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            MainCaliberComboBox.Enabled = MainCaliberCheckBox.Checked;
        }

        private void ArmorCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            ArmorComboBox.Enabled = ArmorCheckBox.Checked;
        }

        private void WeightCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            WeightComboBox.Enabled = WeightCheckBox.Checked;
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (OpenFileDialog.ShowDialog() == DialogResult.OK)
                {
                    XMLFilePath = OpenFileDialog.FileName;
                    Dictionary<string, HashSet<string>> atributes = XMLLoader.LoadXML(XMLFilePath);
                    SetComboBoxValues(atributes);
                }
            } 
            catch (Exception)
            {
                XMLFilePath = null;
                MessageBox.Show("Something wrong with file, try again");
            }            
        }

        private void SetComboBoxValues(Dictionary<string, HashSet<string>> dictionary)
        {
            foreach(string str in dictionary["Name"])
            {
                NameComboBox.Items.Add(str);
            }
            foreach (string str in dictionary["Country"])
            {
                CountryComboBox.Items.Add(str);
            } 
            foreach (string str in dictionary["YearOfIssue"])
            {
                YearOfIssueComboBox.Items.Add(str);
            }
            foreach (string str in dictionary["MainCaliber"])
            {
                MainCaliberComboBox.Items.Add(str);
            }
            foreach (string str in dictionary["Armor"])
            {
                ArmorComboBox.Items.Add(str);
            }
            foreach (string str in dictionary["Weight"])
            {
                WeightComboBox.Items.Add(str);
            }
        }
        private void SAXButton_CheckedChanged(object sender, EventArgs e)
        {
            searcher = _sax;
        }

        private void DOMButton_CheckedChanged(object sender, EventArgs e)
        {
            searcher = _dom;
        }

        private void LINQButton_CheckedChanged(object sender, EventArgs e)
        {
            searcher = _linq;
        }

        private Tank CreateTargetTank()
        {
            Tank tank = new Tank();
            if(NameCheckBox.Checked && NameComboBox.Enabled && NameComboBox.SelectedItem != null)
            {
                tank.Name = NameComboBox.SelectedItem.ToString();
            }
            if(CountryCheckBox.Checked && CountryComboBox.SelectedItem != null)
            {
                tank.Country = CountryComboBox.SelectedItem.ToString();
            }
            if(YearOfIssueCheckBox.Checked && YearOfIssueComboBox.SelectedItem != null)
            {
                tank.YearOfIssue = YearOfIssueComboBox.SelectedItem.ToString();
            }
            if(MainCaliberCheckBox.Checked && MainCaliberComboBox.SelectedItem != null)
            {
                tank.MainCaliber = MainCaliberComboBox.SelectedItem.ToString();
            }
            if(ArmorCheckBox.Checked && ArmorComboBox.SelectedItem != null)
            {
                tank.Armor = ArmorComboBox.SelectedItem.ToString();
            }
            if(WeightCheckBox.Checked && WeightComboBox.SelectedItem != null)
            {
                tank.Weight = WeightComboBox.SelectedItem.ToString();
            }         
            return tank;
        }
        private void SearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (XMLFilePath != null)
                {
                    Tank target = CreateTargetTank();
                    List<Tank> tanks = searcher.Search(target, XMLFilePath);
                    MainTextBox.Text = "";
                    foreach (Tank tank in tanks)
                    {
                        MainTextBox.Text += tank.ToString() + "\n";
                    }
                }
                else
                {
                    MessageBox.Show("Load the file first");
                }                
            }
            catch (Exception)
            {
                XMLFilePath = null;
                MessageBox.Show("Something wrong with file, try again");
            }                
        }

        private void СlearBotton_Click(object sender, EventArgs e)
        {
            MainTextBox.Text = "";
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (XMLFilePath == null)
            {
                MessageBox.Show("Load the file first");
                return;
            }
            try
            {
                if (SaveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string HTMLFilePath = SaveFileDialog.FileName;
                    HtmlSaver.SaveHTML(XMLFilePath, HTMLFilePath);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Something wrong with file, try again");
            }
        }
    }
}
