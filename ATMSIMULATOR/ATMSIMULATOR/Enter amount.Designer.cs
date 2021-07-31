
namespace ATMSIMULATOR
{
    partial class Enter_amount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Enter_amount));
            this.lblenteramount = new System.Windows.Forms.Label();
            this.lblcaution = new System.Windows.Forms.Label();
            this.btneyeview = new System.Windows.Forms.Button();
            this.btnamountenter = new System.Windows.Forms.Button();
            this.btnamountclear = new System.Windows.Forms.Button();
            this.txtboxcardpin = new System.Windows.Forms.TextBox();
            this.btn_Cancel_Operation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblenteramount
            // 
            this.lblenteramount.AutoSize = true;
            this.lblenteramount.BackColor = System.Drawing.Color.Transparent;
            this.lblenteramount.Font = new System.Drawing.Font("Baskerville Old Face", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblenteramount.ForeColor = System.Drawing.Color.Yellow;
            this.lblenteramount.Location = new System.Drawing.Point(262, 71);
            this.lblenteramount.Name = "lblenteramount";
            this.lblenteramount.Size = new System.Drawing.Size(186, 24);
            this.lblenteramount.TabIndex = 4;
            this.lblenteramount.Text = "Please Enter Amount";
            // 
            // lblcaution
            // 
            this.lblcaution.AutoSize = true;
            this.lblcaution.BackColor = System.Drawing.Color.Transparent;
            this.lblcaution.Font = new System.Drawing.Font("Baskerville Old Face", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcaution.ForeColor = System.Drawing.Color.Yellow;
            this.lblcaution.Location = new System.Drawing.Point(107, 106);
            this.lblcaution.Name = "lblcaution";
            this.lblcaution.Size = new System.Drawing.Size(555, 24);
            this.lblcaution.TabIndex = 5;
            this.lblcaution.Text = "NOTE: Amount should not exceed N50,000 limit in a withdrawal.";
            // 
            // btneyeview
            // 
            this.btneyeview.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btneyeview.BackgroundImage")));
            this.btneyeview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btneyeview.Location = new System.Drawing.Point(487, 185);
            this.btneyeview.Name = "btneyeview";
            this.btneyeview.Size = new System.Drawing.Size(41, 33);
            this.btneyeview.TabIndex = 9;
            this.btneyeview.UseVisualStyleBackColor = true;
            this.btneyeview.Click += new System.EventHandler(this.btneyeview_Click);
            // 
            // btnamountenter
            // 
            this.btnamountenter.BackColor = System.Drawing.Color.Yellow;
            this.btnamountenter.FlatAppearance.BorderSize = 0;
            this.btnamountenter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnamountenter.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnamountenter.ForeColor = System.Drawing.Color.Black;
            this.btnamountenter.Location = new System.Drawing.Point(440, 259);
            this.btnamountenter.Name = "btnamountenter";
            this.btnamountenter.Size = new System.Drawing.Size(123, 48);
            this.btnamountenter.TabIndex = 8;
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
            this.btnamountclear.Location = new System.Drawing.Point(171, 259);
            this.btnamountclear.Name = "btnamountclear";
            this.btnamountclear.Size = new System.Drawing.Size(123, 48);
            this.btnamountclear.TabIndex = 7;
            this.btnamountclear.Text = "CLEAR";
            this.btnamountclear.UseVisualStyleBackColor = false;
            this.btnamountclear.Click += new System.EventHandler(this.btnamountclear_Click);
            // 
            // txtboxcardpin
            // 
            this.txtboxcardpin.Font = new System.Drawing.Font("DigifaceWide", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxcardpin.Location = new System.Drawing.Point(227, 184);
            this.txtboxcardpin.Name = "txtboxcardpin";
            this.txtboxcardpin.Size = new System.Drawing.Size(254, 34);
            this.txtboxcardpin.TabIndex = 6;
            this.txtboxcardpin.UseSystemPasswordChar = true;
            // 
            // btn_Cancel_Operation
            // 
            this.btn_Cancel_Operation.BackColor = System.Drawing.Color.Yellow;
            this.btn_Cancel_Operation.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Cancel_Operation.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Cancel_Operation.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel_Operation.Location = new System.Drawing.Point(266, 342);
            this.btn_Cancel_Operation.Name = "btn_Cancel_Operation";
            this.btn_Cancel_Operation.Size = new System.Drawing.Size(199, 55);
            this.btn_Cancel_Operation.TabIndex = 18;
            this.btn_Cancel_Operation.Text = "Cancel Operation";
            this.btn_Cancel_Operation.UseMnemonic = false;
            this.btn_Cancel_Operation.UseVisualStyleBackColor = false;
            this.btn_Cancel_Operation.Click += new System.EventHandler(this.btn_Cancel_Operation_Click);
            // 
            // Enter_amount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(740, 427);
            this.Controls.Add(this.btn_Cancel_Operation);
            this.Controls.Add(this.btneyeview);
            this.Controls.Add(this.btnamountenter);
            this.Controls.Add(this.btnamountclear);
            this.Controls.Add(this.txtboxcardpin);
            this.Controls.Add(this.lblcaution);
            this.Controls.Add(this.lblenteramount);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Enter_amount";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enter amount";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblenteramount;
        private System.Windows.Forms.Label lblcaution;
        private System.Windows.Forms.Button btneyeview;
        private System.Windows.Forms.Button btnamountenter;
        private System.Windows.Forms.Button btnamountclear;
        private System.Windows.Forms.TextBox txtboxcardpin;
        private System.Windows.Forms.Button btn_Cancel_Operation;
    }
}