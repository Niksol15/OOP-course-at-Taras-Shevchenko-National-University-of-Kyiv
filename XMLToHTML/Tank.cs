﻿using System;
using System.Collections.Generic;
using System.Text;

namespace XMLToHTML
{
    public class Tank
    {
        private string _name = "";
        private string _country = "";
        private string _year = "";
        private string _caliber = "";
        private string _armor = "";
        private string _weight = "";
        public string Name { get { return _name; } set { if (value != null) _name = value; } }
        public string Country { get { return _country; } set { if (value != null) _country = value; } }
        public string YearOfIssue { get { return _year; } set { if (value != null) _year = value; } }
        public string MainCaliber { get { return _caliber; } set { if (value != null) _caliber = value; } }
        public string Armor { get { return _armor; } set { if (value != null) _armor = value; } }
        public string Weight { get { return _weight; } set { if (value != null) _weight = value; } }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Name: " + Name + "\n");
            sb.Append("Coutnry: " + Country + "\n");
            sb.Append("YearOfIssue: " + YearOfIssue + "\n");
            sb.Append("MainCaliber: " + MainCaliber + "\n");
            sb.Append("Armor: " + Armor + "\n");
            sb.Append("Weight: " + Weight + "\n");
            return sb.ToString();
        }

        public string ToXPath()
        {
            StringBuilder sb = new StringBuilder();
            bool isFirst = true;
            sb.Append("Tank[");
            if (Name.Length != 0)
            {
                sb.Append("@Name='" + Name + "'");
                isFirst = false;
            }
            if (Country.Length != 0)
            {
                if (!isFirst)
                {
                    sb.Append(" and ");
                }
                sb.Append("@Country='" + Country + "'");
                isFirst = false;
            }
            if (YearOfIssue.Length != 0)
            {
                if (!isFirst)
                {
                    sb.Append(" and ");
                }
                sb.Append("@YearOfIssue='" + YearOfIssue + "'");
                isFirst = false;
            }
            if (MainCaliber.Length != 0)
            {
                if (!isFirst)
                {
                    sb.Append(" and ");
                }
                sb.Append("@MainCaliber='" + MainCaliber + "'");
                isFirst = false;
            }
            if (Armor.Length != 0)
            {
                if (!isFirst)
                {
                    sb.Append(" and ");
                }
                sb.Append("@Armor='" + Armor + "'");
                isFirst = false;
            }
            if (Weight.Length != 0)
            {
                if (!isFirst)
                {
                    sb.Append(" and ");
                }
                sb.Append("@Weight='" + Weight + "'");
                isFirst = false;
            }
            sb.Append("]");
            if (isFirst)
            {
                sb.Clear();
                sb.Append("Tank");
            }
            return sb.ToString();
        }

        public void SetProperty(string key, string value)
        {
            if (key == "Name")
            {
                Name = value;
            }
            else if (key == "Country")
            {
                Country = value;
            }
            else if (key == "YearOfIssue")
            {
                YearOfIssue = value;
            }
            else if (key == "MainCaliber")
            {
                MainCaliber = value;
            }
            else if (key == "Armor")
            {
                Armor = value;
            }
            else if (key == "Weight")
            {
                Weight = value;
            }
        }
        public bool Equals(Tank other)
        {
            return (Name.Length == 0 || other.Name.Length == 0 || Name.Equals(other.Name)) &&
                (Country.Length == 0 || other.Country.Length == 0 || Country.Equals(other.Country)) &&
                (YearOfIssue.Length == 0 || other.YearOfIssue.Length == 0 || YearOfIssue.Equals(other.YearOfIssue)) &&
                (MainCaliber.Length == 0 || other.MainCaliber.Length == 0 || MainCaliber.Equals(other.MainCaliber)) &&
                (Armor.Length == 0 || other.Armor.Length == 0 || Armor.Equals(other.Armor)) &&
                (Weight.Length == 0 || other.Weight.Length == 0 || Weight.Equals(other.Weight));
        }
    }
}
