namespace Khalin_Kypcova_612pst
{
    partial class Login
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.LoginLabel = new System.Windows.Forms.Label();
            this.Log_in_email = new System.Windows.Forms.TextBox();
            this.Log_In_pasword = new System.Windows.Forms.TextBox();
            this.Log_in_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LoginLabel
            // 
            this.LoginLabel.BackColor = System.Drawing.Color.Transparent;
            this.LoginLabel.Font = new System.Drawing.Font("Cooper Black", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LoginLabel.Location = new System.Drawing.Point(70, 70);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(244, 77);
            this.LoginLabel.TabIndex = 0;
            this.LoginLabel.Text = "Log In";
            this.LoginLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Log_in_email
            // 
            this.Log_in_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Log_in_email.Location = new System.Drawing.Point(42, 175);
            this.Log_in_email.Name = "Log_in_email";
            this.Log_in_email.Size = new System.Drawing.Size(300, 30);
            this.Log_in_email.TabIndex = 1;
            this.Log_in_email.TabStop = false;
            this.Log_in_email.Text = "Email";
            this.Log_in_email.Enter += new System.EventHandler(this.Log_in_email_Enter);
            this.Log_in_email.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Log_in_email_KeyDown);
            this.Log_in_email.Leave += new System.EventHandler(this.Log_in_email_Leave);
            // 
            // Log_In_pasword
            // 
            this.Log_In_pasword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Log_In_pasword.Location = new System.Drawing.Point(42, 225);
            this.Log_In_pasword.Name = "Log_In_pasword";
            this.Log_In_pasword.Size = new System.Drawing.Size(300, 30);
            this.Log_In_pasword.TabIndex = 2;
            this.Log_In_pasword.TabStop = false;
            this.Log_In_pasword.Text = "Password";
            this.Log_In_pasword.Enter += new System.EventHandler(this.Log_In_pasword_Enter);
            this.Log_In_pasword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Log_In_pasword_KeyDown);
            this.Log_In_pasword.Leave += new System.EventHandler(this.Log_In_pasword_Leave);
            // 
            // Log_in_button
            // 
            this.Log_in_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Log_in_button.Location = new System.Drawing.Point(144, 280);
            this.Log_in_button.Name = "Log_in_button";
            this.Log_in_button.Size = new System.Drawing.Size(96, 40);
            this.Log_in_button.TabIndex = 3;
            this.Log_in_button.TabStop = false;
            this.Log_in_button.Text = "Log in";
            this.Log_in_button.UseVisualStyleBackColor = true;
            this.Log_in_button.Click += new System.EventHandler(this.Log_in_button_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(142, 323);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sign Up";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Log_in_button);
            this.Controls.Add(this.Log_In_pasword);
            this.Controls.Add(this.Log_in_email);
            this.Controls.Add(this.LoginLabel);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(400, 400);
            this.MinimumSize = new System.Drawing.Size(400, 400);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.TextBox Log_in_email;
        private System.Windows.Forms.TextBox Log_In_pasword;
        private System.Windows.Forms.Button Log_in_button;
        private System.Windows.Forms.Label label1;
    }
}

