using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProbabilityGameProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(textBox1.Text);
                if (a > 0)
                {
                    this.Hide();
                    Form2 frm = new Form2(textBox1.Text) { Width = 1700, Height = 600 };
                    frm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Please enter a postive integer");
                }
            }
            catch
            {
                MessageBox.Show("Please enter a valid number");
            }
        }

        private void btnInstruction_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You win 1x if you get a total under 19, 2x if you get a total of 30, and lose if your total is between 19 and 29");
        }
    }
}
