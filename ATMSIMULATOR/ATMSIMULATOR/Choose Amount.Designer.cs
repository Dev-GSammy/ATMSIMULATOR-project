
namespace ATMSIMULATOR
{
    partial class Choose_Amount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Choose_Amount));
            this.lblchooseamount = new System.Windows.Forms.Label();
            this.btn_Cancel_Operation = new System.Windows.Forms.Button();
            this.btn2000 = new System.Windows.Forms.Button();
            this.btn1000 = new System.Windows.Forms.Button();
            this.btn20000 = new System.Windows.Forms.Button();
            this.btn10000 = new System.Windows.Forms.Button();
            this.btn5000 = new System.Windows.Forms.Button();
            this.btn500 = new System.Windows.Forms.Button();
            this.btnothers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblchooseamount
            // 
            this.lblchooseamount.AutoSize = true;
            this.lblchooseamount.BackColor = System.Drawing.Color.Transparent;
            this.lblchooseamount.Font = new System.Drawing.Font("Baskerville Old Face", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblchooseamount.ForeColor = System.Drawing.Color.Yellow;
            this.lblchooseamount.Location = new System.Drawing.Point(252, 19);
            this.lblchooseamount.Name = "lblchooseamount";
            this.lblchooseamount.Size = new System.Drawing.Size(204, 24);
            this.lblchooseamount.TabIndex = 3;
            this.lblchooseamount.Text = "Please Choose Amount";
            // 
            // btn_Cancel_Operation
            // 
            this.btn_Cancel_Operation.BackColor = System.Drawing.Color.Yellow;
            this.btn_Cancel_Operation.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Cancel_Operation.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Cancel_Operation.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel_Operation.Location = new System.Drawing.Point(-5, 318);
            this.btn_Cancel_Operation.Name = "btn_Cancel_Operation";
            this.btn_Cancel_Operation.Size = new System.Drawing.Size(199, 55);
            this.btn_Cancel_Operation.TabIndex = 17;
            this.btn_Cancel_Operation.Text = "Cancel Operation";
            this.btn_Cancel_Operation.UseMnemonic = false;
            this.btn_Cancel_Operation.UseVisualStyleBackColor = false;
            this.btn_Cancel_Operation.Click += new System.EventHandler(this.btn_Cancel_Operation_Click);
            // 
            // btn2000
            // 
            this.btn2000.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn2000.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2000.Location = new System.Drawing.Point(-5, 237);
            this.btn2000.Name = "btn2000";
            this.btn2000.Size = new System.Drawing.Size(199, 55);
            this.btn2000.TabIndex = 16;
            this.btn2000.Text = "N2000";
            this.btn2000.UseMnemonic = false;
            this.btn2000.UseVisualStyleBackColor = true;
            this.btn2000.Click += new System.EventHandler(this.PriceChosen);
            // 
            // btn1000
            // 
            this.btn1000.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn1000.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1000.Location = new System.Drawing.Point(-5, 153);
            this.btn1000.Name = "btn1000";
            this.btn1000.Size = new System.Drawing.Size(199, 55);
            this.btn1000.TabIndex = 15;
            this.btn1000.Text = "N1000";
            this.btn1000.UseMnemonic = false;
            this.btn1000.UseVisualStyleBackColor = true;
            this.btn1000.Click += new System.EventHandler(this.PriceChosen);
            // 
            // btn20000
            // 
            this.btn20000.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn20000.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn20000.Location = new System.Drawing.Point(544, 239);
            this.btn20000.Name = "btn20000";
            this.btn20000.Size = new System.Drawing.Size(199, 55);
            this.btn20000.TabIndex = 14;
            this.btn20000.Text = "N20000";
            this.btn20000.UseMnemonic = false;
            this.btn20000.UseVisualStyleBackColor = true;
            this.btn20000.Click += new System.EventHandler(this.PriceChosen);
            // 
            // btn10000
            // 
            this.btn10000.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn10000.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn10000.Location = new System.Drawing.Point(544, 153);
            this.btn10000.Name = "btn10000";
            this.btn10000.Size = new System.Drawing.Size(199, 55);
            this.btn10000.TabIndex = 13;
            this.btn10000.Text = "N10000";
            this.btn10000.UseMnemonic = false;
            this.btn10000.UseVisualStyleBackColor = true;
            this.btn10000.Click += new System.EventHandler(this.PriceChosen);
            // 
            // btn5000
            // 
            this.btn5000.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn5000.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5000.Location = new System.Drawing.Point(544, 69);
            this.btn5000.Name = "btn5000";
            this.btn5000.Size = new System.Drawing.Size(199, 55);
            this.btn5000.TabIndex = 12;
            this.btn5000.Text = "N5000";
            this.btn5000.UseMnemonic = false;
            this.btn5000.UseVisualStyleBackColor = true;
            this.btn5000.Click += new System.EventHandler(this.PriceChosen);
            // 
            // btn500
            // 
            this.btn500.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn500.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn500.Location = new System.Drawing.Point(-5, 67);
            this.btn500.Name = "btn500";
            this.btn500.Size = new System.Drawing.Size(199, 59);
            this.btn500.TabIndex = 18;
            this.btn500.Text = "N500";
            this.btn500.UseMnemonic = false;
            this.btn500.UseVisualStyleBackColor = true;
            this.btn500.Click += new System.EventHandler(this.PriceChosen);
            // 
            // btnothers
            // 
            this.btnothers.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnothers.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnothers.Location = new System.Drawing.Point(544, 318);
            this.btnothers.Name = "btnothers";
            this.btnothers.Size = new System.Drawing.Size(204, 55);
            this.btnothers.TabIndex = 19;
            this.btnothers.Text = "OTHERS";
            this.btnothers.UseMnemonic = false;
            this.btnothers.UseVisualStyleBackColor = true;
            this.btnothers.Click += new System.EventHandler(this.PriceChosen);
            // 
            // Choose_Amount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(740, 427);
            this.Controls.Add(this.btnothers);
            this.Controls.Add(this.btn500);
            this.Controls.Add(this.btn_Cancel_Operation);
            this.Controls.Add(this.btn2000);
            this.Controls.Add(this.btn1000);
            this.Controls.Add(this.btn20000);
            this.Controls.Add(this.btn10000);
            this.Controls.Add(this.btn5000);
            this.Controls.Add(this.lblchooseamount);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Choose_Amount";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Choose Amount";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblchooseamount;
        private System.Windows.Forms.Button btn_Cancel_Operation;
        private System.Windows.Forms.Button btn2000;
        private System.Windows.Forms.Button btn1000;
        private System.Windows.Forms.Button btn20000;
        private System.Windows.Forms.Button btn10000;
        private System.Windows.Forms.Button btn5000;
        private System.Windows.Forms.Button btn500;
        private System.Windows.Forms.Button btnothers;
    }
}