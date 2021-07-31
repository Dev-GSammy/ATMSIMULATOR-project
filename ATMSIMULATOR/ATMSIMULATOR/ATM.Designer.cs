
namespace ATMSIMULATOR
{
    partial class ATMFORM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ATMFORM));
            this.Welcomelbl = new System.Windows.Forms.Label();
            this.lblcardpininput = new System.Windows.Forms.Label();
            this.txtboxcardpin = new System.Windows.Forms.TextBox();
            this.btncardpinclear = new System.Windows.Forms.Button();
            this.btncardpinenter = new System.Windows.Forms.Button();
            this.btneyeview = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Welcomelbl
            // 
            this.Welcomelbl.AutoSize = true;
            this.Welcomelbl.BackColor = System.Drawing.Color.Transparent;
            this.Welcomelbl.Font = new System.Drawing.Font("Arial", 25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Welcomelbl.ForeColor = System.Drawing.Color.Yellow;
            this.Welcomelbl.Location = new System.Drawing.Point(90, 43);
            this.Welcomelbl.Name = "Welcomelbl";
            this.Welcomelbl.Size = new System.Drawing.Size(557, 39);
            this.Welcomelbl.TabIndex = 0;
            this.Welcomelbl.Text = "Welcome to the ATM SIMULATOR";
            // 
            // lblcardpininput
            // 
            this.lblcardpininput.AutoSize = true;
            this.lblcardpininput.BackColor = System.Drawing.Color.Transparent;
            this.lblcardpininput.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcardpininput.ForeColor = System.Drawing.Color.Yellow;
            this.lblcardpininput.Location = new System.Drawing.Point(196, 180);
            this.lblcardpininput.Name = "lblcardpininput";
            this.lblcardpininput.Size = new System.Drawing.Size(342, 22);
            this.lblcardpininput.TabIndex = 1;
            this.lblcardpininput.Text = "Please input your 4 digit Card Pin Below";
            // 
            // txtboxcardpin
            // 
            this.txtboxcardpin.Font = new System.Drawing.Font("DigifaceWide", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxcardpin.Location = new System.Drawing.Point(256, 231);
            this.txtboxcardpin.Name = "txtboxcardpin";
            this.txtboxcardpin.Size = new System.Drawing.Size(213, 27);
            this.txtboxcardpin.TabIndex = 2;
            this.txtboxcardpin.UseSystemPasswordChar = true;
            // 
            // btncardpinclear
            // 
            this.btncardpinclear.BackColor = System.Drawing.Color.Yellow;
            this.btncardpinclear.FlatAppearance.BorderSize = 0;
            this.btncardpinclear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btncardpinclear.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncardpinclear.ForeColor = System.Drawing.Color.Black;
            this.btncardpinclear.Location = new System.Drawing.Point(200, 295);
            this.btncardpinclear.Name = "btncardpinclear";
            this.btncardpinclear.Size = new System.Drawing.Size(123, 48);
            this.btncardpinclear.TabIndex = 3;
            this.btncardpinclear.Text = "CLEAR";
            this.btncardpinclear.UseVisualStyleBackColor = false;
            this.btncardpinclear.Click += new System.EventHandler(this.btncardpinclear_Click);
            // 
            // btncardpinenter
            // 
            this.btncardpinenter.BackColor = System.Drawing.Color.Yellow;
            this.btncardpinenter.FlatAppearance.BorderSize = 0;
            this.btncardpinenter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btncardpinenter.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncardpinenter.ForeColor = System.Drawing.Color.Black;
            this.btncardpinenter.Location = new System.Drawing.Point(415, 295);
            this.btncardpinenter.Name = "btncardpinenter";
            this.btncardpinenter.Size = new System.Drawing.Size(123, 48);
            this.btncardpinenter.TabIndex = 4;
            this.btncardpinenter.Text = "ENTER";
            this.btncardpinenter.UseVisualStyleBackColor = false;
            this.btncardpinenter.Click += new System.EventHandler(this.btncardpinenter_Click);
            // 
            // btneyeview
            // 
            this.btneyeview.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btneyeview.BackgroundImage")));
            this.btneyeview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btneyeview.Location = new System.Drawing.Point(475, 231);
            this.btneyeview.Name = "btneyeview";
            this.btneyeview.Size = new System.Drawing.Size(35, 26);
            this.btneyeview.TabIndex = 5;
            this.btneyeview.UseVisualStyleBackColor = true;
            this.btneyeview.Click += new System.EventHandler(this.btneyeview_Click);
            // 
            // ATMFORM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(744, 431);
            this.Controls.Add(this.btneyeview);
            this.Controls.Add(this.btncardpinenter);
            this.Controls.Add(this.btncardpinclear);
            this.Controls.Add(this.txtboxcardpin);
            this.Controls.Add(this.lblcardpininput);
            this.Controls.Add(this.Welcomelbl);
            this.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "ATMFORM";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ATM";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Welcomelbl;
        private System.Windows.Forms.Label lblcardpininput;
        private System.Windows.Forms.TextBox txtboxcardpin;
        private System.Windows.Forms.Button btncardpinclear;
        private System.Windows.Forms.Button btncardpinenter;
        private System.Windows.Forms.Button btneyeview;
    }
}

