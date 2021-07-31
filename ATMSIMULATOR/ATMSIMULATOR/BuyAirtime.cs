using System;
using System.Windows.Forms;

namespace ATMSIMULATOR
{
    public partial class BuyAirtime : Form
    {
        public BuyAirtime()
        {
            InitializeComponent();
        }
        ATMFORM aTMFORM = new ATMFORM();
        float airtimePrice;
        private void btnamountclear_Click(object sender, EventArgs e)
        {
            txtboxcardpin.Text = "";
        }

        private void btnamountenter_Click(object sender, EventArgs e)
        {
            try
            {
                long phonenumber = long.Parse(textboxphonenumber.Text);
                if ((int.Parse(txtboxcardpin.Text) >= 100) && (int.Parse(txtboxcardpin.Text) <= 1000) && (phonenumber >= 1000000000) && (phonenumber <= 9999999999))
                {
                    airtimePrice = float.Parse(txtboxcardpin.Text);
                    if (airtimePrice < (aTMFORM.initialUserAmount - 1000))
                    {
                        aTMFORM.initialUserAmount = -airtimePrice;
                        MessageBox.Show("Your Phone Number (0"+phonenumber+") has been credited with N"+airtimePrice+" airtime.\nThanks for banking with us", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DialogResult dr = MessageBox.Show("Would you like to perform another transaction?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dr == DialogResult.Yes)
                        {
                            aTMFORM.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Thank you for Banking with us\nWe'd like to have you next time");
                            this.Hide();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Insufficient account balance.\nPlease enter a lower amount or Cancel Operation.");
                        txtboxcardpin.Text = "";
                        textboxphonenumber.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Your amount was either not in range\n or your phone number is not valid.\nPlease check and resolve the error.\nThanks", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtboxcardpin.Text = "";
                    textboxphonenumber.Text = "";
                }
            }
            catch
            {
                MessageBox.Show("You inputed a wrong input.\nPlease try again");
                txtboxcardpin.Text = "";
                textboxphonenumber.Text = "";
            }
        }

        private void btn_Cancel_Operation_Click(object sender, EventArgs e)
        {
            aTMFORM.Show();
            this.Hide();
        }

        private void btnphonenumberclear_Click(object sender, EventArgs e)
        {
            textboxphonenumber.Text = "";
        }
    }
}
