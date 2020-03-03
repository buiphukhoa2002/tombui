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
    public partial class Form2 : Form
    {
        private string _message;
        private int sum=0;
        private int count = 0;
        private int own = 0;
        private string random="";
        
        public Form2()
        {
            InitializeComponent();
            SetOriginalPicture();
            Original();
        }
        public Form2(string Message) : this()
        {
            _message = Message;
            lblBet.Text += _message;
        }

        private string RandomCard()
        {
            List<string> listCard = new List<string>() {"2H","2C","2S","2D", "3H", "3C", "3S", "3D", "4H", "4C", "4S", "4D", "5H", "5C", "5S", "5D", "6H", "6C", "6S", "6D", "7H", "7C", "7S", "7D",
            "8H","8C","8S","8D","9H","9C","9S","9D","10H","10C","10S","10D", "AH","AC","AS","AD","JH","JC","JS","JD", "QH","QC","QS","QD", "KH","KC","KS","KD"};
            Random rand = new Random();
            string cardchosen = listCard[rand.Next(0, listCard.Count-1)];
            return cardchosen;
        }

        private int ValueCard(string cardchosen)
        {
            if(cardchosen.Contains("Q") || cardchosen.Contains("K") || cardchosen.Contains("J") || cardchosen.Contains("10"))
            {
                return 10;
            }
            else if(cardchosen.Contains("A"))
            {
                return 1;
            }
            else
            {
                string a = cardchosen[0].ToString();
                return int.Parse(a);
            }
        }

        private void GetSum(PictureBox ptb, Button btn)
        {
            string card = RandomCard();
            while(random==card)
            {
                card = RandomCard();
            }
            random = card;
            ptb.Image = new Bitmap(Application.StartupPath + "\\Resources\\" + card + ".png");
            btn.Enabled = false;
            lblSum.Text = "Sum:";
            sum += ValueCard(card);
            lblSum.Text += sum.ToString();
            count++;
            btnChangeBet.Enabled = false;
            btnNew.Enabled = false;
            if(count==3)
            {
                if (sum < 19)
                {
                    lblResult.Text = "You win $" + _message;
                    own += int.Parse(_message);
                    lblOwnValue.Text = own.ToString();
                }
                else if (sum == 30)
                {
                    int bet = int.Parse(_message);
                    own += bet * 2;
                    lblResult.Text = "You win $" + own.ToString();
                    lblOwnValue.Text = own.ToString();
                }
                else
                {
                    lblResult.Text = "You lose $" + _message;
                    own -= int.Parse(_message);
                    lblOwnValue.Text = own.ToString();
                }
                btnNew.Enabled = true;
                btnChangeBet.Enabled = true;
            }
        }
        private void btnOpenA_Click(object sender, EventArgs e)
        {
            GetSum(pictureBox1, btnOpenA);
        }

        private void btnOpenB_Click(object sender, EventArgs e)
        {
            GetSum(pictureBox2, btnOpenB);
        }

        private void btnOpen3_Click(object sender, EventArgs e)
        {
            GetSum(pictureBox3, btnOpen3);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            SetOriginalPicture();
            btnOpen3.Enabled = true;
            btnOpenA.Enabled = true;
            btnOpenB.Enabled = true;
            count = 0;
            sum = 0;
            lblSum.Text = "Sum:";
            lblResult.Text = "";
        }

        private void SetOriginalPicture()
        {
            Bitmap map = new Bitmap(Application.StartupPath + "\\Resources\\card back red.png");
            pictureBox1.Image = map;
            pictureBox2.Image = map;
            pictureBox3.Image = map;
        }

        private void btnChangeBet_Click(object sender, EventArgs e)
        {
            txbChange.Enabled = true;
            btnOK.Visible = true;
            btnCancel.Visible = true;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            _message = txbChange.Text;
            lblBet.Text = "Bet: $" + _message;
            Original();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Original();
        }

        private void Original()
        {
            txbChange.Enabled = false;
            btnOK.Visible = false;
            btnCancel.Visible = false;
            txbChange.Text = "";
        }
    }
}
