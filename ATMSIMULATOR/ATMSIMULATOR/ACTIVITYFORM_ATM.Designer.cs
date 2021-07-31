
namespace ATMSIMULATOR
{
    partial class Account_Type
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Account_Type));
            this.Welcomelbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnsavings = new System.Windows.Forms.Button();
            this.btncurrent = new System.Windows.Forms.Button();
            this.btnfixed = new System.Windows.Forms.Button();
            this.btn_Cancel_Operation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Welcomelbl
            // 
            this.Welcomelbl.AutoSize = true;
            this.Welcomelbl.BackColor = System.Drawing.Color.Transparent;
            this.Welcomelbl.Font = new System.Drawing.Font("Arial", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Welcomelbl.ForeColor = System.Drawing.Color.Yellow;
            this.Welcomelbl.Location = new System.Drawing.Point(225, 9);
            this.Welcomelbl.Name = "Welcomelbl";
            this.Welcomelbl.Size = new System.Drawing.Size(271, 24);
            this.Welcomelbl.TabIndex = 1;
            this.Welcomelbl.Text = "Welcome back Dear User,";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Baskerville Old Face", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(265, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Please Choose Account";
            // 
            // btnsavings
            // 
            this.btnsavings.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnsavings.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsavings.Location = new System.Drawing.Point(546, 105);
            this.btnsavings.Name = "btnsavings";
            this.btnsavings.Size = new System.Drawing.Size(199, 55);
            this.btnsavings.TabIndex = 3;
            this.btnsavings.Text = "SAVINGS";
            this.btnsavings.UseMnemonic = false;
            this.btnsavings.UseVisualStyleBackColor = true;
            this.btnsavings.Click += new System.EventHandler(this.Account_TypeButton);
            // 
            // btncurrent
            // 
            this.btncurrent.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btncurrent.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncurrent.Location = new System.Drawing.Point(546, 189);
            this.btncurrent.Name = "btncurrent";
            this.btncurrent.Size = new System.Drawing.Size(199, 55);
            this.btncurrent.TabIndex = 4;
            this.btncurrent.Text = "CURRENT";
            this.btncurrent.UseMnemonic = false;
            this.btncurrent.UseVisualStyleBackColor = true;
            this.btncurrent.Click += new System.EventHandler(this.Account_TypeButton);
            // 
            // btnfixed
            // 
            this.btnfixed.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnfixed.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfixed.Location = new System.Drawing.Point(546, 275);
            this.btnfixed.Name = "btnfixed";
            this.btnfixed.Size = new System.Drawing.Size(199, 55);
            this.btnfixed.TabIndex = 5;
            this.btnfixed.Text = "FIXED";
            this.btnfixed.UseMnemonic = false;
            this.btnfixed.UseVisualStyleBackColor = true;
            this.btnfixed.Click += new System.EventHandler(this.Account_TypeButton);
            // 
            // btn_Cancel_Operation
            // 
            this.btn_Cancel_Operation.BackColor = System.Drawing.Color.Yellow;
            this.btn_Cancel_Operation.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Cancel_Operation.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Cancel_Operation.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel_Operation.Location = new System.Drawing.Point(269, 349);
            this.btn_Cancel_Operation.Name = "btn_Cancel_Operation";
            this.btn_Cancel_Operation.Size = new System.Drawing.Size(199, 55);
            this.btn_Cancel_Operation.TabIndex = 6;
            this.btn_Cancel_Operation.Text = "Cancel Operation";
            this.btn_Cancel_Operation.UseMnemonic = false;
            this.btn_Cancel_Operation.UseVisualStyleBackColor = false;
            this.btn_Cancel_Operation.Click += new System.EventHandler(this.btn_Cancel_Operation_Click);
            // 
            // Account_Type
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(744, 431);
            this.Controls.Add(this.btn_Cancel_Operation);
            this.Controls.Add(this.btnfixed);
            this.Controls.Add(this.btncurrent);
            this.Controls.Add(this.btnsavings);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Welcomelbl);
            this.MaximizeBox = false;
            this.Name = "Account_Type";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Choose Account";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Welcomelbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnsavings;
        private System.Windows.Forms.Button btncurrent;
        private System.Windows.Forms.Button btnfixed;
        private System.Windows.Forms.Button btn_Cancel_Operation;
    }
}