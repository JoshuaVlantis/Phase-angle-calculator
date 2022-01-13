using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_Phase_Rectifer_Testing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                float halfcycletime = float.Parse(halfcycle.Text);
                float hz = 1000 / halfcycletime;
                lblhz.Text = (hz.ToString() + " Hz");
            }
            catch
            {
                MessageBox.Show("Please enter a valid number");
                halfcycle.Text = "20";
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                float time = float.Parse(ttime.Text);
                float hz = float.Parse(frq.Text);

                float phaseangle = (360 * time * hz / 1000);
                lblangle.Text = ("Phase angle : " + phaseangle + "°");
            }
            catch
            {
                MessageBox.Show("Please enter valid numbers");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
