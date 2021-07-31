
namespace ATMSIMULATOR
{
    partial class Choose_Operation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Choose_Operation));
            this.btnwithdraw = new System.Windows.Forms.Label();
            this.btnbuyairtime = new System.Windows.Forms.Button();
            this.btndeposit = new System.Windows.Forms.Button();
            this.btnsavings = new System.Windows.Forms.Button();
            this.btn_pay_via_card = new System.Windows.Forms.Button();
            this.btn_activate_card = new System.Windows.Forms.Button();
            this.btn_Cancel_Operation = new System.Windows.Forms.Button();
            this.btnCheckbalance = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnwithdraw
            // 
            this.btnwithdraw.AutoSize = true;
            this.btnwithdraw.BackColor = System.Drawing.Color.Transparent;
            this.btnwithdraw.Font = new System.Drawing.Font("Baskerville Old Face", 17F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnwithdraw.ForeColor = System.Drawing.Color.Yellow;
            this.btnwithdraw.Location = new System.Drawing.Point(208, 18);
            this.btnwithdraw.Name = "btnwithdraw";
            this.btnwithdraw.Size = new System.Drawing.Size(326, 26);
            this.btnwithdraw.TabIndex = 3;
            this.btnwithdraw.Text = "What would you like to do today?";
            // 
            // btnbuyairtime
            // 
            this.btnbuyairtime.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnbuyairtime.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuyairtime.Location = new System.Drawing.Point(-1, 254);
            this.btnbuyairtime.Name = "btnbuyairtime";
            this.btnbuyairtime.Size = new System.Drawing.Size(199, 55);
            this.btnbuyairtime.TabIndex = 8;
            this.btnbuyairtime.Text = "BUY AIRTIME";
            this.btnbuyairtime.UseMnemonic = false;
            this.btnbuyairtime.UseVisualStyleBackColor = true;
            this.btnbuyairtime.Click += new System.EventHandler(this.ChooseOperationClick);
            // 
            // btndeposit
            // 
            this.btndeposit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btndeposit.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndeposit.Location = new System.Drawing.Point(529, 179);
            this.btndeposit.Name = "btndeposit";
            this.btndeposit.Size = new System.Drawing.Size(218, 55);
            this.btndeposit.TabIndex = 7;
            this.btndeposit.Text = "DEPOSIT";
            this.btndeposit.UseMnemonic = false;
            this.btndeposit.UseVisualStyleBackColor = true;
            this.btndeposit.Click += new System.EventHandler(this.ChooseOperationClick);
            // 
            // btnsavings
            // 
            this.btnsavings.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnsavings.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsavings.Location = new System.Drawing.Point(529, 95);
            this.btnsavings.Name = "btnsavings";
            this.btnsavings.Size = new System.Drawing.Size(218, 55);
            this.btnsavings.TabIndex = 6;
            this.btnsavings.Text = "WITHDRAW";
            this.btnsavings.UseMnemonic = false;
            this.btnsavings.UseVisualStyleBackColor = true;
            this.btnsavings.Click += new System.EventHandler(this.ChooseOperationClick);
            // 
            // btn_pay_via_card
            // 
            this.btn_pay_via_card.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_pay_via_card.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pay_via_card.Location = new System.Drawing.Point(-1, 179);
            this.btn_pay_via_card.Name = "btn_pay_via_card";
            this.btn_pay_via_card.Size = new System.Drawing.Size(199, 55);
            this.btn_pay_via_card.TabIndex = 10;
            this.btn_pay_via_card.Text = "PAY VIA CARD";
            this.btn_pay_via_card.UseMnemonic = false;
            this.btn_pay_via_card.UseVisualStyleBackColor = true;
            this.btn_pay_via_card.Click += new System.EventHandler(this.ChooseOperationClick);
            // 
            // btn_activate_card
            // 
            this.btn_activate_card.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_activate_card.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_activate_card.Location = new System.Drawing.Point(-1, 95);
            this.btn_activate_card.Name = "btn_activate_card";
            this.btn_activate_card.Size = new System.Drawing.Size(199, 55);
            this.btn_activate_card.TabIndex = 9;
            this.btn_activate_card.Text = "ACTIVATE CARD";
            this.btn_activate_card.UseMnemonic = false;
            this.btn_activate_card.UseVisualStyleBackColor = true;
            this.btn_activate_card.Click += new System.EventHandler(this.ChooseOperationClick);
            // 
            // btn_Cancel_Operation
            // 
            this.btn_Cancel_Operation.BackColor = System.Drawing.Color.Yellow;
            this.btn_Cancel_Operation.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Cancel_Operation.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Cancel_Operation.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel_Operation.Location = new System.Drawing.Point(274, 353);
            this.btn_Cancel_Operation.Name = "btn_Cancel_Operation";
            this.btn_Cancel_Operation.Size = new System.Drawing.Size(199, 55);
            this.btn_Cancel_Operation.TabIndex = 11;
            this.btn_Cancel_Operation.Text = "Cancel Operation";
            this.btn_Cancel_Operation.UseMnemonic = false;
            this.btn_Cancel_Operation.UseVisualStyleBackColor = false;
            this.btn_Cancel_Operation.Click += new System.EventHandler(this.btn_Cancel_Operation_Click);
            // 
            // btnCheckbalance
            // 
            this.btnCheckbalance.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCheckbalance.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckbalance.Location = new System.Drawing.Point(529, 254);
            this.btnCheckbalance.Name = "btnCheckbalance";
            this.btnCheckbalance.Size = new System.Drawing.Size(218, 55);
            this.btnCheckbalance.TabIndex = 12;
            this.btnCheckbalance.Text = "CHECK BALANCE";
            this.btnCheckbalance.UseMnemonic = false;
            this.btnCheckbalance.UseVisualStyleBackColor = true;
            this.btnCheckbalance.Click += new System.EventHandler(this.ChooseOperationClick);
            // 
            // Choose_Operation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(740, 427);
            this.Controls.Add(this.btnCheckbalance);
            this.Controls.Add(this.btn_Cancel_Operation);
            this.Controls.Add(this.btn_pay_via_card);
            this.Controls.Add(this.btn_activate_card);
            this.Controls.Add(this.btnbuyairtime);
            this.Controls.Add(this.btndeposit);
            this.Controls.Add(this.btnsavings);
            this.Controls.Add(this.btnwithdraw);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Choose_Operation";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Choose Operation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label btnwithdraw;
        private System.Windows.Forms.Button btnbuyairtime;
        private System.Windows.Forms.Button btndeposit;
        private System.Windows.Forms.Button btnsavings;
        private System.Windows.Forms.Button btn_pay_via_card;
        private System.Windows.Forms.Button btn_activate_card;
        private System.Windows.Forms.Button btn_Cancel_Operation;
        private System.Windows.Forms.Button btnCheckbalance;
    }
}