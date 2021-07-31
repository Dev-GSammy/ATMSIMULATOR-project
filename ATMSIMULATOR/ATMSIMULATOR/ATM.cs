using System;
using System.Windows.Forms;

namespace ATMSIMULATOR
{
    public partial class ATMFORM : Form
    {
        public ATMFORM()
        {
            InitializeComponent();
        }
        public float initialUserAmount = 50000F;
        #region Code portion for welcome form
        /// <summary>
        ///  Edit with care and consent of the original writer.
        /// </summary>
        Account_Type Account_Type = new Account_Type();
        private void btncardpinclear_Click(object sender, EventArgs e)
        {
            txtboxcardpin.Text = "";
            txtboxcardpin.UseSystemPasswordChar = true;
        }

        private void btneyeview_Click(object sender, EventArgs e)
        {
            if(txtboxcardpin.UseSystemPasswordChar == true)
            {
                txtboxcardpin.UseSystemPasswordChar = false;
            }
            else
            {
                txtboxcardpin.UseSystemPasswordChar = true;
            }
        }

        private void btncardpinenter_Click(object sender, EventArgs e)
        {
            string pin = txtboxcardpin.Text;
            try
            {
                int pinagain = int.Parse(pin);
                if (pin == "" || pin.Length != 4)
                {
                    MessageBox.Show("Input is either not 4 digit or void", "Caution", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    Account_Type.Show();
                    this.Hide();
                }
            }
            catch
            {
                MessageBox.Show("Your input is not digit,\nPlease try again.");
                txtboxcardpin.Text = "";
            }
            
        }
        #endregion

        
    }
}
