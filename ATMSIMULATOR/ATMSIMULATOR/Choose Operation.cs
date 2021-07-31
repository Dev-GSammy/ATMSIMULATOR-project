using System;
using System.Windows.Forms;

namespace ATMSIMULATOR
{
    public partial class Choose_Operation : Form
    {
        
        public Choose_Operation()
        {
            InitializeComponent();
        }
        //Choose_Amount Choose_Amount = new Choose_Amount();
        ATMFORM aTMFORM = new ATMFORM();
        private void btn_Cancel_Operation_Click(object sender, EventArgs e)
        {
            aTMFORM.Show();
            this.Hide();
        }
        public void ChooseOperationClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string buttonclick = button.Text;
            Choose_Amount.chosenbutton = buttonclick.ToLower();
            switch (buttonclick.ToLower())
            {
                case "activate card":
                    ActivateCard();
                    break;
                case "pay via card":
                    PayViaCard();
                    break;
                case "buy airtime":
                    BuyAirtime();
                    break;
                case "withdraw":
                    Withdraw();
                    break;
                case "deposit":
                    Deposit();
                    break;
                case "check balance":
                    CheckBalance();
                    break;
                default:
                    break;
            }
        }
        private void ActivateCard()
        {
            DialogResult dr = MessageBox.Show("Your Card has been successfully activated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (dr == DialogResult.OK)
            {
                aTMFORM.Show();
                this.Hide();
            }
        }
        private void PayViaCard()
        {
            DialogResult dr = MessageBox.Show("No Internet Connection\nPlease Try Again in 24 hours.\nThank you.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if(dr == DialogResult.OK)
            {
                aTMFORM.Show();
                this.Hide();
            }
        }
        
        private void BuyAirtime()
        {
            BuyAirtime BuyAirtime = new BuyAirtime();
            BuyAirtime.Show();
            this.Hide();
        }
        private void Withdraw()
        {
            Choose_Amount choose_Amount = new Choose_Amount();
            choose_Amount.Show();
            this.Hide();
        }
        private void Deposit()
        {
            Choose_Amount choose_Amount = new Choose_Amount();
            choose_Amount.Show();
            this.Hide();
        }
        private void CheckBalance()
        {
            MessageBox.Show("Your Account Balance is " + aTMFORM.initialUserAmount + "\nThanks for Banking with us.\nDo have a nice day.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult dr = MessageBox.Show("Would you like to perform another operation?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dr == DialogResult.Yes)
            {
                aTMFORM.Show();
                this.Hide();
            }
            else
            {
                this.Hide();
            }
        }
    }

}
