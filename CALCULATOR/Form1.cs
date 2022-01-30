using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Win32;

namespace CALCULATOR
{
    public static class DataStorage
    {
        public static string result = "";
        public static double num = 0;
        public static int op = 0;//  1 = +, 2 = -, 3 = *, 4 = /
        public static double memory = 0;
        public static Color color;
    }

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            colorScheme();
        }

        private void displayResult()
        {
            if (DataStorage.result.Length > 15)
            {
                MessageBox.Show("不能超過15個字元!", "超過字數", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DataStorage.result = DataStorage.result.Substring(0, 15);
            }
            if (DataStorage.result == "")
                Display.Text = "0";
            Display.Text = DataStorage.result; 
        }

        public void colorScheme()
        {
            var reg = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion");

            var currentBuildStr = (string)reg.GetValue("CurrentBuild");
            var currentBuild = int.Parse(currentBuildStr);

            if (currentBuild >= 22000) // Windows 11
            {
                DataStorage.color = ColorTranslator.FromHtml("#FAFAFA");
            }
            else
            {
                DataStorage.color = SystemColors.ControlText;
            }
        }

        private void K0_Click(object sender, EventArgs e)
        {
            if (DataStorage.result == "0")
                DataStorage.result += "";
            else if (DataStorage.result == "")
                DataStorage.result = "0";
            else
                DataStorage.result += "0";
            displayResult();
        }

        private void K1_Click(object sender, EventArgs e)
        {
            DataStorage.result += "1";
            displayResult();
        }

        private void K2_Click(object sender, EventArgs e)
        {
            DataStorage.result += "2";
            displayResult();
        }

        private void K3_Click(object sender, EventArgs e)
        {
            DataStorage.result += "3";
            displayResult();
        }

        private void K4_Click(object sender, EventArgs e)
        {
            DataStorage.result += "4";
            displayResult();
        }

        private void K5_Click(object sender, EventArgs e)
        {
            DataStorage.result += "5";
            displayResult();
        }

        private void K6_Click(object sender, EventArgs e)
        {
            DataStorage.result += "6";
            displayResult();
        }

        private void K7_Click(object sender, EventArgs e)
        {
            DataStorage.result += "7";
            displayResult();
        }

        private void K8_Click(object sender, EventArgs e)
        {
            DataStorage.result += "8";
            displayResult();
        }

        private void K9_Click(object sender, EventArgs e)
        {
            DataStorage.result += "9";
            displayResult();
        }

        private void Dot_Click(object sender, EventArgs e)
        {
            if (Display.Text == "0" || DataStorage.result == "")
                DataStorage.result = "0.";
            else if (DataStorage.result.Contains(".")) {}
            else
                DataStorage.result += ".";
            displayResult();
        }

        private void Bksp_Click(object sender, EventArgs e)
        {
            try
            {
                DataStorage.result = DataStorage.result.Substring(0, DataStorage.result.Length-1);
                displayResult();
                if (DataStorage.result == "")
                    Display.Text = "0";
            }
            catch (Exception exception)
            {
                Display.Text = "0";
            }
        }

        private void AC_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("確定要全部清除嗎？", "清除", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                Display.Text = "0";
                DataStorage.num = 0;
                DataStorage.op = 0;
                DataStorage.result = "";
                Pls.ForeColor = SystemColors.ControlText;
                Pls.BackColor = DataStorage.color;
                Min.ForeColor = SystemColors.ControlText;
                Min.BackColor = DataStorage.color;
                Mul.ForeColor = SystemColors.ControlText;
                Mul.BackColor = DataStorage.color;
                Div.ForeColor = SystemColors.ControlText;
                Div.BackColor = DataStorage.color;
                Eql.ForeColor = SystemColors.ControlText;
                Eql.BackColor = DataStorage.color;
            }
        }

        private void C_Click(object sender, EventArgs e)
        {
            Display.Text = "0";
            DataStorage.result = "";
            if (DataStorage.op == 0)
            {
                Display.Text = "0";
                DataStorage.num = 0;
                DataStorage.op = 0;
                DataStorage.result = "";
                Pls.ForeColor = SystemColors.ControlText;
                Pls.BackColor = DataStorage.color;
                Min.ForeColor = SystemColors.ControlText;
                Min.BackColor = DataStorage.color;
                Mul.ForeColor = SystemColors.ControlText;
                Mul.BackColor = DataStorage.color;
                Div.ForeColor = SystemColors.ControlText;
                Div.BackColor = DataStorage.color;
                Eql.ForeColor = SystemColors.ControlText;
                Eql.BackColor = DataStorage.color;
            }
        }
        
        private void Pls_Click(object sender, EventArgs e)
        {
            Pls.ForeColor = Color.White;
            Pls.BackColor = Color.Red;
            Min.ForeColor = SystemColors.ControlText;
            Min.BackColor = DataStorage.color;
            Mul.ForeColor = SystemColors.ControlText;
            Mul.BackColor = DataStorage.color;
            Div.ForeColor = SystemColors.ControlText;
            Div.BackColor = DataStorage.color;
            Eql.ForeColor = SystemColors.ControlText;
            Eql.BackColor = DataStorage.color;

            if (DataStorage.result == "" && Display.Text != "")
                DataStorage.num += Convert.ToDouble(Display.Text);
            else
                DataStorage.num = Convert.ToDouble(DataStorage.result);
            if (DataStorage.op != 1)
                DataStorage.op = 1;
            
            Display.Text = DataStorage.num.ToString();
            DataStorage.result = "";
        }

        private void Min_Click(object sender, EventArgs e)
        {
            Min.ForeColor = Color.White;
            Min.BackColor = Color.Red;
            Pls.ForeColor = SystemColors.ControlText;
            Pls.BackColor = DataStorage.color;
            Mul.ForeColor = SystemColors.ControlText;
            Mul.BackColor = DataStorage.color;
            Div.ForeColor = SystemColors.ControlText;
            Div.BackColor = DataStorage.color;
            Eql.ForeColor = SystemColors.ControlText;
            Eql.BackColor = DataStorage.color;
            
            if (DataStorage.result == "" && Display.Text != "")
                DataStorage.num -= Convert.ToDouble(Display.Text);
            else
                DataStorage.num = Convert.ToDouble(DataStorage.result);
            if (DataStorage.op != 2)
                DataStorage.op = 2;

            Display.Text = DataStorage.num.ToString();
            DataStorage.result = "";
        }

        private void Mul_Click(object sender, EventArgs e)
        {
            Mul.ForeColor = Color.White;
            Mul.BackColor = Color.Red;
            Pls.ForeColor = SystemColors.ControlText;
            Pls.BackColor = DataStorage.color;
            Min.ForeColor = SystemColors.ControlText;
            Min.BackColor = DataStorage.color;
            Div.ForeColor = SystemColors.ControlText;
            Div.BackColor = DataStorage.color;
            Eql.ForeColor = SystemColors.ControlText;
            Eql.BackColor = DataStorage.color;
            
            if (DataStorage.result == "" && Display.Text != "")
                DataStorage.num *= Convert.ToDouble(Display.Text);
            else
                DataStorage.num = Convert.ToDouble(DataStorage.result);
            if (DataStorage.op != 3)
                DataStorage.op = 3;

            Display.Text = DataStorage.num.ToString();
            DataStorage.result = "";
        }

        private void Div_Click(object sender, EventArgs e)
        {
            Div.ForeColor = Color.White;
            Div.BackColor = Color.Red;
            Pls.ForeColor = SystemColors.ControlText;
            Pls.BackColor = DataStorage.color;
            Min.ForeColor = SystemColors.ControlText;
            Min.BackColor = DataStorage.color;
            Mul.ForeColor = SystemColors.ControlText;
            Mul.BackColor = DataStorage.color;
            Eql.ForeColor = SystemColors.ControlText;
            Eql.BackColor = DataStorage.color;

            if (DataStorage.op == 4 && Display.Text == "0")
            {
                MessageBox.Show("除數不能為0!", "表達式錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DataStorage.result = "";
            }
            else
            {
                if (DataStorage.result == "" && Display.Text != "")
                    DataStorage.num /= Convert.ToDouble(Display.Text);
                else
                    DataStorage.num = Convert.ToDouble(DataStorage.result);
                if (DataStorage.op != 4)
                    DataStorage.op = 4;
                Display.Text = DataStorage.num.ToString();
                DataStorage.result = "";
            }
        }

        private void Eql_Click(object sender, EventArgs e)
        {
            if (DataStorage.op == 4 && Display.Text == "0")
            {
                MessageBox.Show("除數不能為0!", "表達式錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DataStorage.result = "";
            }
            else
            {
                Pls.ForeColor = SystemColors.ControlText;
                Pls.BackColor = DataStorage.color;
                Min.ForeColor = SystemColors.ControlText;
                Min.BackColor = DataStorage.color;
                Mul.ForeColor = SystemColors.ControlText;
                Mul.BackColor = DataStorage.color;
                Div.ForeColor = SystemColors.ControlText;
                Div.BackColor = DataStorage.color;
                Eql.ForeColor = Color.White;
                Eql.BackColor = Color.Green;
                
                if (DataStorage.op == 1)
                    DataStorage.num += Convert.ToDouble(Display.Text);
                if (DataStorage.op == 2)
                    DataStorage.num -= Convert.ToDouble(Display.Text);
                if (DataStorage.op == 3)
                    DataStorage.num *= Convert.ToDouble(Display.Text);
                if (DataStorage.op == 4)
                    DataStorage.num /= Convert.ToDouble(Display.Text);

                DataStorage.result = DataStorage.num.ToString();
                Display.Text = DataStorage.result;
                DataStorage.op = 0;   
            }
        }

        private void MC_Click(object sender, EventArgs e)
        {
            DataStorage.memory = 0;
            MR.ForeColor = SystemColors.ControlText;
            MR.BackColor = DataStorage.color;
        }

        private void MR_Click(object sender, EventArgs e)
        {
            DataStorage.result = DataStorage.memory.ToString();
            Display.Text = DataStorage.result;
        }

        private void MN_Click(object sender, EventArgs e)
        {
            DataStorage.memory -= Convert.ToDouble(Display.Text);
            if (DataStorage.memory != 0)
            {
                MR.ForeColor = Color.White;
                MR.BackColor = Color.MediumPurple;
            }
            else
            {
                MR.ForeColor = SystemColors.ControlText;
                MR.BackColor = DataStorage.color;
            }
        }

        private void MP_Click(object sender, EventArgs e)
        {
            DataStorage.memory += Convert.ToDouble(Display.Text);
            if (DataStorage.memory != 0)
            {
                MR.ForeColor = Color.White;
                MR.BackColor = Color.MediumPurple;
            }
            else
            {
                MR.ForeColor = SystemColors.ControlText;
                MR.BackColor = DataStorage.color;
            }
        }
    }
}