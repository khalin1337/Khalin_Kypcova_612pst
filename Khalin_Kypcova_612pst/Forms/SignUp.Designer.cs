namespace Khalin_Kypcova_612pst.Forms
{
    partial class SignUp
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
            this.SignUpLabel = new System.Windows.Forms.Label();
            this.Sign_Up_button = new System.Windows.Forms.Button();
            this.Sign_Up_pasword = new System.Windows.Forms.TextBox();
            this.Sign_Up_email = new System.Windows.Forms.TextBox();
            this.Sign_up_phone = new System.Windows.Forms.TextBox();
            this.Sign_Up_Name = new System.Windows.Forms.TextBox();
            this.Admin_chek = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // SignUpLabel
            // 
            this.SignUpLabel.BackColor = System.Drawing.Color.Transparent;
            this.SignUpLabel.Font = new System.Drawing.Font("Cooper Black", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SignUpLabel.Location = new System.Drawing.Point(50, 10);
            this.SignUpLabel.Name = "SignUpLabel";
            this.SignUpLabel.Size = new System.Drawing.Size(305, 75);
            this.SignUpLabel.TabIndex = 1;
            this.SignUpLabel.Text = "Sign Up";
            this.SignUpLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Sign_Up_button
            // 
            this.Sign_Up_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Sign_Up_button.Location = new System.Drawing.Point(150, 310);
            this.Sign_Up_button.Name = "Sign_Up_button";
            this.Sign_Up_button.Size = new System.Drawing.Size(100, 40);
            this.Sign_Up_button.TabIndex = 6;
            this.Sign_Up_button.TabStop = false;
            this.Sign_Up_button.Text = "Sign Up";
            this.Sign_Up_button.UseVisualStyleBackColor = true;
            this.Sign_Up_button.Click += new System.EventHandler(this.Sign_Up_button_Click);
            // 
            // Sign_Up_pasword
            // 
            this.Sign_Up_pasword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Sign_Up_pasword.Location = new System.Drawing.Point(65, 155);
            this.Sign_Up_pasword.Name = "Sign_Up_pasword";
            this.Sign_Up_pasword.Size = new System.Drawing.Size(270, 30);
            this.Sign_Up_pasword.TabIndex = 5;
            this.Sign_Up_pasword.TabStop = false;
            this.Sign_Up_pasword.Text = "Password";
            this.Sign_Up_pasword.Enter += new System.EventHandler(this.Sign_Up_pasword_Enter);
            this.Sign_Up_pasword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Sign_Up_pasword_KeyDown);
            this.Sign_Up_pasword.Leave += new System.EventHandler(this.Sign_Up_pasword_Leave);
            // 
            // Sign_Up_email
            // 
            this.Sign_Up_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Sign_Up_email.Location = new System.Drawing.Point(65, 110);
            this.Sign_Up_email.Name = "Sign_Up_email";
            this.Sign_Up_email.Size = new System.Drawing.Size(270, 30);
            this.Sign_Up_email.TabIndex = 4;
            this.Sign_Up_email.TabStop = false;
            this.Sign_Up_email.Text = "Email";
            this.Sign_Up_email.Enter += new System.EventHandler(this.Sign_Up_email_Enter);
            this.Sign_Up_email.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Sign_Up_email_KeyDown);
            this.Sign_Up_email.Leave += new System.EventHandler(this.Sign_Up_email_Leave);
            // 
            // Sign_up_phone
            // 
            this.Sign_up_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Sign_up_phone.Location = new System.Drawing.Point(65, 200);
            this.Sign_up_phone.Name = "Sign_up_phone";
            this.Sign_up_phone.Size = new System.Drawing.Size(270, 30);
            this.Sign_up_phone.TabIndex = 7;
            this.Sign_up_phone.TabStop = false;
            this.Sign_up_phone.Text = "Phone";
            this.Sign_up_phone.Enter += new System.EventHandler(this.Sign_up_phone_Enter);
            this.Sign_up_phone.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Sign_up_phone_KeyDown);
            this.Sign_up_phone.Leave += new System.EventHandler(this.Sign_up_phone_Leave);
            // 
            // Sign_Up_Name
            // 
            this.Sign_Up_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Sign_Up_Name.Location = new System.Drawing.Point(65, 250);
            this.Sign_Up_Name.Name = "Sign_Up_Name";
            this.Sign_Up_Name.Size = new System.Drawing.Size(270, 30);
            this.Sign_Up_Name.TabIndex = 8;
            this.Sign_Up_Name.TabStop = false;
            this.Sign_Up_Name.Text = "Name";
            this.Sign_Up_Name.Enter += new System.EventHandler(this.Sign_Up_Name_Enter);
            this.Sign_Up_Name.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Sign_Up_Name_KeyDown);
            this.Sign_Up_Name.Leave += new System.EventHandler(this.Sign_Up_Name_Leave);
            // 
            // Admin_chek
            // 
            this.Admin_chek.AutoSize = true;
            this.Admin_chek.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(188)))), ((int)(((byte)(204)))));
            this.Admin_chek.Location = new System.Drawing.Point(255, 287);
            this.Admin_chek.Name = "Admin_chek";
            this.Admin_chek.Size = new System.Drawing.Size(86, 17);
            this.Admin_chek.TabIndex = 9;
            this.Admin_chek.Text = "Administrator";
            this.Admin_chek.UseVisualStyleBackColor = false;
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Khalin_Kypcova_612pst.Properties.Resources._1617314616_46_p_salon_krasoti_fon_47__1_;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.Admin_chek);
            this.Controls.Add(this.Sign_Up_Name);
            this.Controls.Add(this.Sign_up_phone);
            this.Controls.Add(this.Sign_Up_button);
            this.Controls.Add(this.Sign_Up_pasword);
            this.Controls.Add(this.Sign_Up_email);
            this.Controls.Add(this.SignUpLabel);
            this.MaximumSize = new System.Drawing.Size(400, 400);
            this.MinimumSize = new System.Drawing.Size(400, 400);
            this.Name = "SignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SignUp_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SignUpLabel;
        private System.Windows.Forms.Button Sign_Up_button;
        private System.Windows.Forms.TextBox Sign_Up_pasword;
        private System.Windows.Forms.TextBox Sign_Up_email;
        private System.Windows.Forms.TextBox Sign_up_phone;
        private System.Windows.Forms.TextBox Sign_Up_Name;
        private System.Windows.Forms.CheckBox Admin_chek;
    }
}