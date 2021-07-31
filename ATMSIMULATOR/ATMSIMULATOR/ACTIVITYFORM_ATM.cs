using System;
using System.Windows.Forms;

namespace ATMSIMULATOR
{
    public partial class Account_Type : Form
    {
        public Account_Type()
        {
            InitializeComponent();
        }

        private void Account_TypeButton(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string buttonvalue = btn.Text;
            switch (buttonvalue.ToLower())
            {
                case "savings":
                    SavingsMethod();
                    break;
                case "current":
                    CurrentMethod();
                    break;
                case "fixed":
                    FixedMethod();
                    break;
                default:
                    break;
            }
        }
        public void SavingsMethod()
        {
            Choose_Operation choose_Operation = new Choose_Operation();
            choose_Operation.Show();
            this.Hide();
        }
        public void CurrentMethod()
        {
            Choose_Operation choose_Operation = new Choose_Operation();
            choose_Operation.Show();
            this.Hide();
        }
        public void FixedMethod()
        {
            Choose_Operation choose_Operation = new Choose_Operation();
            choose_Operation.Show();
            this.Hide();
        }

        private void btn_Cancel_Operation_Click(object sender, EventArgs e)
        {
            ATMFORM aTMFORM = new ATMFORM();
            aTMFORM.Show();
            this.Hide();
        }
    }
}
