namespace Automotive_Resource_Management
{
    partial class Forgetpassword
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
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.verotp_btn = new System.Windows.Forms.Button();
            this.sendotp_btn = new System.Windows.Forms.Button();
            this.fgt_entotp_tbl = new System.Windows.Forms.TextBox();
            this.fgt_regemail_tbl = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(709, 565);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(119, 20);
            this.linkLabel1.TabIndex = 17;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Return to Login";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // verotp_btn
            // 
            this.verotp_btn.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verotp_btn.Location = new System.Drawing.Point(608, 388);
            this.verotp_btn.Name = "verotp_btn";
            this.verotp_btn.Size = new System.Drawing.Size(173, 50);
            this.verotp_btn.TabIndex = 16;
            this.verotp_btn.Text = "VERIFY OTP";
            this.verotp_btn.UseVisualStyleBackColor = true;
            this.verotp_btn.Click += new System.EventHandler(this.verotp_btn_Click);
            // 
            // sendotp_btn
            // 
            this.sendotp_btn.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendotp_btn.Location = new System.Drawing.Point(608, 255);
            this.sendotp_btn.Name = "sendotp_btn";
            this.sendotp_btn.Size = new System.Drawing.Size(173, 40);
            this.sendotp_btn.TabIndex = 15;
            this.sendotp_btn.Text = "SEND OTP";
            this.sendotp_btn.UseVisualStyleBackColor = true;
            this.sendotp_btn.Click += new System.EventHandler(this.sendotp_btn_Click);
            // 
            // fgt_entotp_tbl
            // 
            this.fgt_entotp_tbl.Location = new System.Drawing.Point(509, 342);
            this.fgt_entotp_tbl.Name = "fgt_entotp_tbl";
            this.fgt_entotp_tbl.Size = new System.Drawing.Size(209, 26);
            this.fgt_entotp_tbl.TabIndex = 14;
            // 
            // fgt_regemail_tbl
            // 
            this.fgt_regemail_tbl.Location = new System.Drawing.Point(496, 156);
            this.fgt_regemail_tbl.Name = "fgt_regemail_tbl";
            this.fgt_regemail_tbl.Size = new System.Drawing.Size(283, 26);
            this.fgt_regemail_tbl.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(143, 336);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 31);
            this.label2.TabIndex = 12;
            this.label2.Text = "ENTER OTP";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(141, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 31);
            this.label1.TabIndex = 11;
            this.label1.Text = "ENTER REGISTER EMAIL";
            // 
            // Forgetpassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 709);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.verotp_btn);
            this.Controls.Add(this.sendotp_btn);
            this.Controls.Add(this.fgt_entotp_tbl);
            this.Controls.Add(this.fgt_regemail_tbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Forgetpassword";
            this.Text = "Forgetpassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button verotp_btn;
        private System.Windows.Forms.Button sendotp_btn;
        private System.Windows.Forms.TextBox fgt_entotp_tbl;
        private System.Windows.Forms.TextBox fgt_regemail_tbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}