using System;
using System.Windows.Forms;

namespace ATMSIMULATOR
{
    public partial class Cashout : Form
    {
        public Cashout()
        {
            InitializeComponent();
        }
        ATMFORM aTMFORM = new ATMFORM();
        private void TakeCard(object sender, EventArgs e)
        {
           DialogResult dr =  MessageBox.Show("Would you like to perform another transaction?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
    }
}
