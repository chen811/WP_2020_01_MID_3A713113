using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WP_2020_01_MID_3A713113.Properties;

namespace WP_2020_01_MID_3A713113
{
    public partial class Form1 : Form
    {
        List<Image> gp = new List<Image>();

        public Form1()

       
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            switch (tex.Text)
            {
                case "a":
                    pic.Image = gp[0];
                    break;
                case "b":
                    pic.Image = gp[1];
                    break;
                case "o":
                    pic.Image = gp[2];
                    break;
                case "ab":
                    pic.Image = gp[3];
                    break;
                case "A":
                    pic.Image = gp[0];
                    break;
                case "B":
                    pic.Image = gp[1];
                    break;
                case "O":
                    pic.Image = gp[2];
                    break;
                case "AB":
                    pic.Image = gp[3];
                    break;
            }
         }

        private void Form1_Load(object sender, EventArgs e)
        {
            gp.Add(Resources._1);
            gp.Add(Resources._2);
            gp.Add(Resources._3);
            gp.Add(Resources._4);


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
