using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LenghtconverWFA
{
    public partial class Form1 : Form
    {
        int to = 0;

        string[] dataFormat = new string[4];
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            To();
        }

        private void To()
        {
            dataFormat[0] = "CM";
            dataFormat[1] = "MM";
            dataFormat[2] = "Meter";
            dataFormat[3] = "Feet";

            for (int i = 0; i < dataFormat.Length; i++)
            {
                BoxTo.Items.Add(dataFormat[i]);
            }
            BoxTo.SelectedIndex = 0;
        }

        private void BoxTo_SelectedIndexChanged(object sender, EventArgs e)
        {
            to = BoxTo.SelectedIndex;
        }

        private void BoxFrom_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnConver_Click(object sender, EventArgs e)
        {
            try
            {
                double quantity = Convert.ToDouble(BoxFrom.Text);
                if (to == 0)
                {
                    double CM = quantity / 0.39370;
                    lblresult.Text = CM.ToString();
                }
                if (to == 1)
                {
                    double MM = quantity / 0.039370;
                    lblresult.Text = MM.ToString();
                }
                if (to == 2)
                {
                    double Meter = quantity / 39.370;
                    lblresult.Text = Meter.ToString();
                }
                if (to == 3)
                {
                    double Feet = quantity / 12;
                    lblresult.Text = Feet.ToString();
                }
            }
            catch (Exception)
            {
                lblresult.Text = "You are wrong!";
            }
        }

        private void BoxFrom_MouseHover(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}