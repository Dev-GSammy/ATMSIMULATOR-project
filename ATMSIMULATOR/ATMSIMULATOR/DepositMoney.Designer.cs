
namespace ATMSIMULATOR
{
    partial class DepositMoney
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DepositMoney));
            this.TakeCard = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnwithdraw = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TakeCard
            // 
            this.TakeCard.BackColor = System.Drawing.Color.Yellow;
            this.TakeCard.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.TakeCard.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TakeCard.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TakeCard.Location = new System.Drawing.Point(291, 269);
            this.TakeCard.Name = "TakeCard";
            this.TakeCard.Size = new System.Drawing.Size(164, 55);
            this.TakeCard.TabIndex = 11;
            this.TakeCard.Text = "Take Card";
            this.TakeCard.UseMnemonic = false;
            this.TakeCard.UseVisualStyleBackColor = false;
            this.TakeCard.Click += new System.EventHandler(this.TakeCard_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Baskerville Old Face", 17F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(240, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(299, 26);
            this.label2.TabIndex = 10;
            this.label2.Text = "Thank you for banking with us.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Baskerville Old Face", 17F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(122, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(487, 26);
            this.label1.TabIndex = 9;
            this.label1.Text = "Your money has been added to your initial amount.";
            // 
            // btnwithdraw
            // 
            this.btnwithdraw.AutoSize = true;
            this.btnwithdraw.BackColor = System.Drawing.Color.Transparent;
            this.btnwithdraw.Font = new System.Drawing.Font("Baskerville Old Face", 17F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnwithdraw.ForeColor = System.Drawing.Color.Yellow;
            this.btnwithdraw.Location = new System.Drawing.Point(252, 103);
            this.btnwithdraw.Name = "btnwithdraw";
            this.btnwithdraw.Size = new System.Drawing.Size(239, 26);
            this.btnwithdraw.TabIndex = 8;
            this.btnwithdraw.Text = "Thanks for your Deposit";
            // 
            // DepositMoney
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(740, 427);
            this.Controls.Add(this.TakeCard);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnwithdraw);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "DepositMoney";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Deposit Money";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button TakeCard;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label btnwithdraw;
    }
}