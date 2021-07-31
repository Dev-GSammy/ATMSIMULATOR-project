using System;
using System.Windows.Forms;

namespace ATMSIMULATOR
{
    public partial class Choose_Amount : Form
    {
        public static string chosenbutton;
        public Choose_Amount()
        {
            InitializeComponent();
        }
        public static float price;
        Cashout Cashout = new Cashout();
        DepositMoney DepositMoney = new DepositMoney();
        ATMFORM aTMFORM = new ATMFORM();
        //Choose_Operation Choose_Operation = new Choose_Operation();
       
        private void btn_Cancel_Operation_Click(object sender, EventArgs e)
        {
            aTMFORM.Show();
            this.Hide();
        }
        private void PriceChosen(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string buttonvalue = button.Text;
            if (chosenbutton == "withdraw")
            {
                switch (buttonvalue)
                {
                    case "N500":
                        price = 500;
                        aTMFORM.initialUserAmount -=price;
                        Cashout.Show();
                        this.Hide();
                        break;
                    case "N1000":
                        price = 1000;
                        aTMFORM.initialUserAmount -= price;
                        Cashout.Show();
                        this.Hide();
                        break;
                    case "N2000":
                        price = 2000;
                        aTMFORM.initialUserAmount -= price;
                        Cashout.Show();
                        this.Hide();
                        break;
                    case "N5000":
                        price = 5000;
                        aTMFORM.initialUserAmount -= price;
                        Cashout.Show();
                        this.Hide();
                        break;
                    case "N10000":
                        price = 10000;
                        aTMFORM.initialUserAmount -= price;
                        Cashout.Show();
                        this.Hide();
                        break;
                    case "N20000":
                        price = 20000;
                        aTMFORM.initialUserAmount -= price;
                        Cashout.Show();
                        this.Hide();
                        break;
                    case "OTHERS":
                        Enter_amount enter_Amount = new Enter_amount();
                        enter_Amount.Show();
                        this.Hide();
                        break;
                    default:
                        break;
                }
            }
            else if(chosenbutton == "deposit")
            {
                switch (buttonvalue)
                {
                    case "N500":
                        price = 500;
                        aTMFORM.initialUserAmount += price;
                        DepositMoney.Show();
                        this.Hide();
                        break;
                    case "N1000":
                        price = 1000;
                        aTMFORM.initialUserAmount += price;
                        DepositMoney.Show();
                        this.Hide();
                        break;
                    case "N2000":
                        price = 2000;
                        aTMFORM.initialUserAmount += price;
                        DepositMoney.Show();
                        this.Hide();
                        break;
                    case "N5000":
                        price = 5000;
                        aTMFORM.initialUserAmount += price;
                        DepositMoney.Show();
                        this.Hide();
                        break;
                    case "N10000":
                        price = 10000;
                        aTMFORM.initialUserAmount += price;
                        DepositMoney.Show();
                        this.Hide();
                        break;
                    case "N20000":
                        price = 20000;
                        aTMFORM.initialUserAmount =+ price;
                        DepositMoney.Show();
                        this.Hide();
                        break;
                    case "OTHERS":
                        Enter_amount enter_Amount = new Enter_amount();
                        enter_Amount.Show();
                        this.Hide();
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
