using System;
using System.Windows.Forms;

namespace ATMSIMULATOR
{
    public partial class Enter_amount : Form
    {
        public Enter_amount()
        {
            InitializeComponent();
        }
        float price;
        string buttonchosen;
        ATMFORM aTMFORM = new ATMFORM();
        DepositMoney DepositMoney = new DepositMoney();
        Choose_Amount choose_Amount = new Choose_Amount();
        Choose_Operation Choose_Operation = new Choose_Operation();
        private void btneyeview_Click(object sender, EventArgs e)
        {
            if (txtboxcardpin.UseSystemPasswordChar == true)
            {
                txtboxcardpin.UseSystemPasswordChar = false;
            }
            else
            {
                txtboxcardpin.UseSystemPasswordChar = true;
            }
        }
        private void btnamountclear_Click(object sender, EventArgs e)
        {
            txtboxcardpin.Text = "";
        }
        private void btnamountenter_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(txtboxcardpin.Text) >= 500 && int.Parse(txtboxcardpin.Text) < 50000)
                {
                    price = float.Parse(txtboxcardpin.Text);
                    if(buttonchosen == "withdraw")
                    {
                        aTMFORM.initialUserAmount =- price;
                        Cashout cashout = new Cashout();
                        cashout.Show(); 
                        this.Hide();
                    }
                    else if(buttonchosen == "deposit")
                    {
                        DepositMoney.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Your amount was either too low or too high.\nPlease check and resolve the error.\nThanks", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtboxcardpin.Text = "";
                }
            }
            catch
            {
                MessageBox.Show("You inputed a wrong input.\nPlease try again");
                txtboxcardpin.Text = "";
            }
        }

        private void btn_Cancel_Operation_Click(object sender, EventArgs e)
        {
            aTMFORM.Show();
            this.Hide();
        }

       
    }
}
