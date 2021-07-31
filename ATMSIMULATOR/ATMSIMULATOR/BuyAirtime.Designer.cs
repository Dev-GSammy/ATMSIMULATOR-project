
namespace ATMSIMULATOR
{
    partial class BuyAirtime
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuyAirtime));
            this.btn_Cancel_Operation = new System.Windows.Forms.Button();
            this.btnamountenter = new System.Windows.Forms.Button();
            this.btnamountclear = new System.Windows.Forms.Button();
            this.txtboxcardpin = new System.Windows.Forms.TextBox();
            this.lblcaution = new System.Windows.Forms.Label();
            this.lblenteramount = new System.Windows.Forms.Label();
            this.textboxphonenumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnphonenumberclear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Cancel_Operation
            // 
            this.btn_Cancel_Operation.BackColor = System.Drawing.Color.Yellow;
            this.btn_Cancel_Operation.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Cancel_Operation.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Cancel_Operation.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel_Operation.Location = new System.Drawing.Point(252, 321);
            this.btn_Cancel_Operation.Name = "btn_Cancel_Operation";
            this.btn_Cancel_Operation.Size = new System.Drawing.Size(199, 55);
            this.btn_Cancel_Operation.TabIndex = 25;
            this.btn_Cancel_Operation.Text = "Cancel Operation";
            this.btn_Cancel_Operation.UseMnemonic = false;
            this.btn_Cancel_Operation.UseVisualStyleBackColor = false;
            this.btn_Cancel_Operation.Click += new System.EventHandler(this.btn_Cancel_Operation_Click);
            // 
            // btnamountenter
            // 
            this.btnamountenter.BackColor = System.Drawing.Color.Yellow;
            this.btnamountenter.FlatAppearance.BorderSize = 0;
            this.btnamountenter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnamountenter.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnamountenter.ForeColor = System.Drawing.Color.Black;
            this.btnamountenter.Location = new System.Drawing.Point(286, 267);
            this.btnamountenter.Name = "btnamountenter";
            this.btnamountenter.Size = new System.Drawing.Size(123, 48);
            this.btnamountenter.TabIndex = 23;
            this.btnamountenter.Text = "ENTER";
            this.btnamountenter.UseVisualStyleBackColor = false;
            this.btnamountenter.Click += new System.EventHandler(this.btnamountenter_Click);
            // 
            // btnamountclear
            // 
            this.btnamountclear.BackColor = System.Drawing.Color.Yellow;
            this.btnamountclear.FlatAppearance.BorderSize = 0;
            this.btnamountclear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnamountclear.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnamountclear.ForeColor = System.Drawing.Color.Black;
            this.btnamountclear.Location = new System.Drawing.Point(481, 198);
            this.btnamountclear.Name = "btnamountclear";
            this.btnamountclear.Size = new System.Drawing.Size(86, 34);
            this.btnamountclear.TabIndex = 22;
            this.btnamountclear.Text = "CLEAR";
            this.btnamountclear.UseVisualStyleBackColor = false;
            this.btnamountclear.Click += new System.EventHandler(this.btnamountclear_Click);
            // 
            // txtboxcardpin
            // 
            this.txtboxcardpin.Font = new System.Drawing.Font("DigifaceWide", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxcardpin.Location = new System.Drawing.Point(221, 198);
            this.txtboxcardpin.Name = "txtboxcardpin";
            this.txtboxcardpin.Size = new System.Drawing.Size(254, 34);
            this.txtboxcardpin.TabIndex = 21;
            // 
            // lblcaution
            // 
            this.lblcaution.AutoSize = true;
            this.lblcaution.BackColor = System.Drawing.Color.Transparent;
            this.lblcaution.Font = new System.Drawing.Font("Baskerville Old Face", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcaution.ForeColor = System.Drawing.Color.Yellow;
            this.lblcaution.Location = new System.Drawing.Point(94, 34);
            this.lblcaution.Name = "lblcaution";
            this.lblcaution.Size = new System.Drawing.Size(578, 24);
            this.lblcaution.TabIndex = 20;
            this.lblcaution.Text = "NOTE: You can\'t buy more than 1000 naira airtime in one purchase.";
            // 
            // lblenteramount
            // 
            this.lblenteramount.AutoSize = true;
            this.lblenteramount.BackColor = System.Drawing.Color.Transparent;
            this.lblenteramount.Font = new System.Drawing.Font("Baskerville Old Face", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblenteramount.ForeColor = System.Drawing.Color.Yellow;
            this.lblenteramount.Location = new System.Drawing.Point(216, 171);
            this.lblenteramount.Name = "lblenteramount";
            this.lblenteramount.Size = new System.Drawing.Size(259, 24);
            this.lblenteramount.TabIndex = 19;
            this.lblenteramount.Text = "Please Enter Airtime  Amount";
            // 
            // textboxphonenumber
            // 
            this.textboxphonenumber.Font = new System.Drawing.Font("DigifaceWide", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxphonenumber.Location = new System.Drawing.Point(220, 134);
            this.textboxphonenumber.Name = "textboxphonenumber";
            this.textboxphonenumber.Size = new System.Drawing.Size(254, 34);
            this.textboxphonenumber.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Baskerville Old Face", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(215, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 24);
            this.label1.TabIndex = 26;
            this.label1.Text = "Please Enter Phone Number";
            // 
            // btnphonenumberclear
            // 
            this.btnphonenumberclear.BackColor = System.Drawing.Color.Yellow;
            this.btnphonenumberclear.FlatAppearance.BorderSize = 0;
            this.btnphonenumberclear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnphonenumberclear.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnphonenumberclear.ForeColor = System.Drawing.Color.Black;
            this.btnphonenumberclear.Location = new System.Drawing.Point(481, 134);
            this.btnphonenumberclear.Name = "btnphonenumberclear";
            this.btnphonenumberclear.Size = new System.Drawing.Size(86, 34);
            this.btnphonenumberclear.TabIndex = 28;
            this.btnphonenumberclear.Text = "CLEAR";
            this.btnphonenumberclear.UseVisualStyleBackColor = false;
            this.btnphonenumberclear.Click += new System.EventHandler(this.btnphonenumberclear_Click);
            // 
            // BuyAirtime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(740, 427);
            this.Controls.Add(this.btnphonenumberclear);
            this.Controls.Add(this.textboxphonenumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Cancel_Operation);
            this.Controls.Add(this.btnamountenter);
            this.Controls.Add(this.btnamountclear);
            this.Controls.Add(this.txtboxcardpin);
            this.Controls.Add(this.lblcaution);
            this.Controls.Add(this.lblenteramount);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "BuyAirtime";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buy Airtime";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Cancel_Operation;
        private System.Windows.Forms.Button btnamountenter;
        private System.Windows.Forms.Button btnamountclear;
        private System.Windows.Forms.TextBox txtboxcardpin;
        private System.Windows.Forms.Label lblcaution;
        private System.Windows.Forms.Label lblenteramount;
        private System.Windows.Forms.TextBox textboxphonenumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnphonenumberclear;
    }
}