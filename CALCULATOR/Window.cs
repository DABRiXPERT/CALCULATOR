using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CALCULATOR
{
    public class DataStorage
    {
        public static string result = "";
        public static double memory = 0;
    }

    public partial class Window : Form
    {
        public Window()
        {
            InitializeComponent();
        }

        private void displayResult()
        {
            if (DataStorage.result.Length > 15)
            {
                DataStorage.result.Substring(15);
                MessageBox.Show("不能超過15個字元!", "超過字數", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        }

        private void K0_Click(object sender, EventArgs e)
        {
            if (DataStorage.result == "0")
                DataStorage.result += "";
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
            DataStorage.result += ".";
            displayResult();
        }
        private void Bksp_Click(object sender, EventArgs e)
        {
            DataStorage.result += "B";
            displayResult();
        }

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.K7 = new System.Windows.Forms.Button();
            this.K8 = new System.Windows.Forms.Button();
            this.K9 = new System.Windows.Forms.Button();
            this.K4 = new System.Windows.Forms.Button();
            this.K5 = new System.Windows.Forms.Button();
            this.K6 = new System.Windows.Forms.Button();
            this.K1 = new System.Windows.Forms.Button();
            this.K2 = new System.Windows.Forms.Button();
            this.K3 = new System.Windows.Forms.Button();
            this.K0 = new System.Windows.Forms.Button();
            this.Dot = new System.Windows.Forms.Button();
            this.Div = new System.Windows.Forms.Button();
            this.Mul = new System.Windows.Forms.Button();
            this.Min = new System.Windows.Forms.Button();
            this.Pls = new System.Windows.Forms.Button();
            this.Bksp = new System.Windows.Forms.Button();
            this.MR = new System.Windows.Forms.Button();
            this.MC = new System.Windows.Forms.Button();
            this.MP = new System.Windows.Forms.Button();
            this.MN = new System.Windows.Forms.Button();
            this.Display = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // K7
            // 
            this.K7.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.K7.Location = new System.Drawing.Point(13, 75);
            this.K7.Name = "K7";
            this.K7.Size = new System.Drawing.Size(87, 74);
            this.K7.TabIndex = 1;
            this.K7.Text = "7";
            this.K7.UseVisualStyleBackColor = true;
            this.K7.Click += new System.EventHandler(this.K7_Click);
            // 
            // K8
            // 
            this.K8.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.K8.Location = new System.Drawing.Point(106, 75);
            this.K8.Name = "K8";
            this.K8.Size = new System.Drawing.Size(87, 74);
            this.K8.TabIndex = 2;
            this.K8.Text = "8";
            this.K8.UseVisualStyleBackColor = true;
            this.K8.Click += new System.EventHandler(this.K8_Click);
            // 
            // K9
            // 
            this.K9.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.K9.Location = new System.Drawing.Point(199, 75);
            this.K9.Name = "K9";
            this.K9.Size = new System.Drawing.Size(87, 74);
            this.K9.TabIndex = 3;
            this.K9.Text = "9";
            this.K9.UseVisualStyleBackColor = true;
            this.K9.Click += new System.EventHandler(this.K9_Click);
            // 
            // K4
            // 
            this.K4.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.K4.Location = new System.Drawing.Point(13, 155);
            this.K4.Name = "K4";
            this.K4.Size = new System.Drawing.Size(87, 74);
            this.K4.TabIndex = 4;
            this.K4.Text = "4";
            this.K4.UseVisualStyleBackColor = true;
            this.K4.Click += new System.EventHandler(this.K4_Click);
            // 
            // K5
            // 
            this.K5.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.K5.Location = new System.Drawing.Point(106, 155);
            this.K5.Name = "K5";
            this.K5.Size = new System.Drawing.Size(87, 74);
            this.K5.TabIndex = 5;
            this.K5.Text = "5";
            this.K5.UseVisualStyleBackColor = true;
            this.K5.Click += new System.EventHandler(this.K5_Click);
            // 
            // K6
            // 
            this.K6.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.K6.Location = new System.Drawing.Point(199, 155);
            this.K6.Name = "K6";
            this.K6.Size = new System.Drawing.Size(87, 74);
            this.K6.TabIndex = 6;
            this.K6.Text = "6";
            this.K6.UseVisualStyleBackColor = true;
            this.K6.Click += new System.EventHandler(this.K6_Click);
            // 
            // K1
            // 
            this.K1.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.K1.Location = new System.Drawing.Point(13, 235);
            this.K1.Name = "K1";
            this.K1.Size = new System.Drawing.Size(87, 74);
            this.K1.TabIndex = 7;
            this.K1.Text = "1";
            this.K1.UseVisualStyleBackColor = true;
            this.K1.Click += new System.EventHandler(this.K1_Click);
            // 
            // K2
            // 
            this.K2.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.K2.Location = new System.Drawing.Point(106, 235);
            this.K2.Name = "K2";
            this.K2.Size = new System.Drawing.Size(87, 74);
            this.K2.TabIndex = 8;
            this.K2.Text = "2";
            this.K2.UseVisualStyleBackColor = true;
            this.K2.Click += new System.EventHandler(this.K2_Click);
            // 
            // K3
            // 
            this.K3.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.K3.Location = new System.Drawing.Point(199, 235);
            this.K3.Name = "K3";
            this.K3.Size = new System.Drawing.Size(87, 74);
            this.K3.TabIndex = 9;
            this.K3.Text = "3";
            this.K3.UseVisualStyleBackColor = true;
            this.K3.Click += new System.EventHandler(this.K3_Click);
            // 
            // K0
            // 
            this.K0.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.K0.Location = new System.Drawing.Point(13, 315);
            this.K0.Name = "K0";
            this.K0.Size = new System.Drawing.Size(180, 74);
            this.K0.TabIndex = 10;
            this.K0.Text = "0";
            this.K0.UseVisualStyleBackColor = true;
            this.K0.Click += new System.EventHandler(this.K0_Click);
            // 
            // Dot
            // 
            this.Dot.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.Dot.Location = new System.Drawing.Point(199, 315);
            this.Dot.Name = "Dot";
            this.Dot.Size = new System.Drawing.Size(87, 74);
            this.Dot.TabIndex = 11;
            this.Dot.Text = ".";
            this.Dot.UseVisualStyleBackColor = true;
            this.Dot.Click += new System.EventHandler(this.Dot_Click);
            // 
            // Div
            // 
            this.Div.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.Div.Location = new System.Drawing.Point(292, 75);
            this.Div.Name = "Div";
            this.Div.Size = new System.Drawing.Size(87, 74);
            this.Div.TabIndex = 12;
            this.Div.Text = "/";
            this.Div.UseVisualStyleBackColor = true;
            // 
            // Mul
            // 
            this.Mul.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.Mul.Location = new System.Drawing.Point(292, 155);
            this.Mul.Name = "Mul";
            this.Mul.Size = new System.Drawing.Size(87, 74);
            this.Mul.TabIndex = 13;
            this.Mul.Text = "*";
            this.Mul.UseVisualStyleBackColor = true;
            // 
            // Min
            // 
            this.Min.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.Min.Location = new System.Drawing.Point(292, 235);
            this.Min.Name = "Min";
            this.Min.Size = new System.Drawing.Size(87, 74);
            this.Min.TabIndex = 14;
            this.Min.Text = "-";
            this.Min.UseVisualStyleBackColor = true;
            // 
            // Pls
            // 
            this.Pls.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.Pls.Location = new System.Drawing.Point(292, 315);
            this.Pls.Name = "Pls";
            this.Pls.Size = new System.Drawing.Size(87, 74);
            this.Pls.TabIndex = 15;
            this.Pls.Text = "+";
            this.Pls.UseVisualStyleBackColor = true;
            // 
            // Bksp
            // 
            this.Bksp.Font = new System.Drawing.Font("Consolas", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.Bksp.Location = new System.Drawing.Point(385, 75);
            this.Bksp.Name = "Bksp";
            this.Bksp.Size = new System.Drawing.Size(87, 74);
            this.Bksp.TabIndex = 16;
            this.Bksp.Text = "🠐";
            this.Bksp.UseVisualStyleBackColor = true;
            this.Bksp.Click += new System.EventHandler(this.Bksp_Click);
            // 
            // MR
            // 
            this.MR.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.MR.Location = new System.Drawing.Point(385, 155);
            this.MR.Name = "MR";
            this.MR.Size = new System.Drawing.Size(87, 74);
            this.MR.TabIndex = 17;
            this.MR.Text = "MR";
            this.MR.UseVisualStyleBackColor = true;
            // 
            // MC
            // 
            this.MC.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.MC.Location = new System.Drawing.Point(385, 235);
            this.MC.Name = "MC";
            this.MC.Size = new System.Drawing.Size(87, 74);
            this.MC.TabIndex = 18;
            this.MC.Text = "MC";
            this.MC.UseVisualStyleBackColor = true;
            // 
            // MP
            // 
            this.MP.Font = new System.Drawing.Font("Consolas", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.MP.Location = new System.Drawing.Point(385, 315);
            this.MP.Name = "MP";
            this.MP.Size = new System.Drawing.Size(87, 33);
            this.MP.TabIndex = 19;
            this.MP.Text = "M+";
            this.MP.UseVisualStyleBackColor = true;
            // 
            // MN
            // 
            this.MN.Font = new System.Drawing.Font("Consolas", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.MN.Location = new System.Drawing.Point(385, 355);
            this.MN.Name = "MN";
            this.MN.Size = new System.Drawing.Size(87, 34);
            this.MN.TabIndex = 20;
            this.MN.Text = "M-";
            this.MN.UseVisualStyleBackColor = true;
            // 
            // Display
            // 
            this.Display.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Display.Font = new System.Drawing.Font("Consolas", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.Display.Location = new System.Drawing.Point(12, 9);
            this.Display.Name = "Display";
            this.Display.Size = new System.Drawing.Size(460, 53);
            this.Display.TabIndex = 21;
            this.Display.Text = "0";
            this.Display.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 394);
            this.Controls.Add(this.Display);
            this.Controls.Add(this.MN);
            this.Controls.Add(this.MP);
            this.Controls.Add(this.MC);
            this.Controls.Add(this.MR);
            this.Controls.Add(this.Bksp);
            this.Controls.Add(this.Pls);
            this.Controls.Add(this.Min);
            this.Controls.Add(this.Mul);
            this.Controls.Add(this.Div);
            this.Controls.Add(this.Dot);
            this.Controls.Add(this.K0);
            this.Controls.Add(this.K3);
            this.Controls.Add(this.K2);
            this.Controls.Add(this.K1);
            this.Controls.Add(this.K6);
            this.Controls.Add(this.K5);
            this.Controls.Add(this.K4);
            this.Controls.Add(this.K9);
            this.Controls.Add(this.K8);
            this.Controls.Add(this.K7);
            this.Name = "Window";
            this.Text = "計算機(ver: 220126dev)";
            this.ResumeLayout(false);
        }
    }
}