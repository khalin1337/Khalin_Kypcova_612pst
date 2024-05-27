namespace Khalin_Kypcova_612pst.Classes
{
    partial class Zapis
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
            this.Text_info = new System.Windows.Forms.TextBox();
            this.Type_Name = new System.Windows.Forms.TextBox();
            this.Date_Pick = new System.Windows.Forms.DateTimePicker();
            this.Time_Pick = new System.Windows.Forms.ComboBox();
            this.Zapis_button = new System.Windows.Forms.Button();
            this.Change_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Text_info
            // 
            this.Text_info.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Text_info.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Text_info.Font = new System.Drawing.Font("Cooper Black", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text_info.ForeColor = System.Drawing.SystemColors.Window;
            this.Text_info.Location = new System.Drawing.Point(100, 50);
            this.Text_info.Multiline = true;
            this.Text_info.Name = "Text_info";
            this.Text_info.ReadOnly = true;
            this.Text_info.Size = new System.Drawing.Size(400, 300);
            this.Text_info.TabIndex = 0;
            this.Text_info.TabStop = false;
            this.Text_info.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Type_Name
            // 
            this.Type_Name.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Type_Name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Type_Name.Dock = System.Windows.Forms.DockStyle.Top;
            this.Type_Name.Font = new System.Drawing.Font("Cooper Black", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Type_Name.ForeColor = System.Drawing.SystemColors.Window;
            this.Type_Name.Location = new System.Drawing.Point(0, 0);
            this.Type_Name.Name = "Type_Name";
            this.Type_Name.ReadOnly = true;
            this.Type_Name.Size = new System.Drawing.Size(584, 38);
            this.Type_Name.TabIndex = 1;
            this.Type_Name.TabStop = false;
            this.Type_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Date_Pick
            // 
            this.Date_Pick.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Date_Pick.CustomFormat = "";
            this.Date_Pick.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Date_Pick.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Date_Pick.Location = new System.Drawing.Point(100, 375);
            this.Date_Pick.MinDate = new System.DateTime(2024, 5, 27, 0, 0, 0, 0);
            this.Date_Pick.Name = "Date_Pick";
            this.Date_Pick.Size = new System.Drawing.Size(150, 22);
            this.Date_Pick.TabIndex = 2;
            this.Date_Pick.TabStop = false;
            this.Date_Pick.Visible = false;
            // 
            // Time_Pick
            // 
            this.Time_Pick.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Time_Pick.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Time_Pick.FormattingEnabled = true;
            this.Time_Pick.Items.AddRange(new object[] {
            "12 00",
            "13 00",
            "14 00",
            "15 00",
            "16 00",
            "17 00",
            "18 00",
            "19 00"});
            this.Time_Pick.Location = new System.Drawing.Point(275, 374);
            this.Time_Pick.Name = "Time_Pick";
            this.Time_Pick.Size = new System.Drawing.Size(100, 24);
            this.Time_Pick.TabIndex = 3;
            this.Time_Pick.TabStop = false;
            this.Time_Pick.Visible = false;
            // 
            // Zapis_button
            // 
            this.Zapis_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Zapis_button.Location = new System.Drawing.Point(404, 374);
            this.Zapis_button.Name = "Zapis_button";
            this.Zapis_button.Size = new System.Drawing.Size(100, 23);
            this.Zapis_button.TabIndex = 4;
            this.Zapis_button.TabStop = false;
            this.Zapis_button.Text = "Записатися";
            this.Zapis_button.UseVisualStyleBackColor = true;
            this.Zapis_button.Visible = false;
            this.Zapis_button.Click += new System.EventHandler(this.zapis_button_Click);
            // 
            // Change_button
            // 
            this.Change_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Change_button.Location = new System.Drawing.Point(250, 375);
            this.Change_button.Name = "Change_button";
            this.Change_button.Size = new System.Drawing.Size(100, 30);
            this.Change_button.TabIndex = 5;
            this.Change_button.TabStop = false;
            this.Change_button.Text = "Редагувати";
            this.Change_button.UseVisualStyleBackColor = true;
            this.Change_button.Visible = false;
            this.Change_button.Click += new System.EventHandler(this.Change_button_Click);
            // 
            // Zapis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.Change_button);
            this.Controls.Add(this.Zapis_button);
            this.Controls.Add(this.Time_Pick);
            this.Controls.Add(this.Date_Pick);
            this.Controls.Add(this.Type_Name);
            this.Controls.Add(this.Text_info);
            this.MaximumSize = new System.Drawing.Size(600, 500);
            this.MinimumSize = new System.Drawing.Size(600, 500);
            this.Name = "Zapis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zapis";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Zapis_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Text_info;
        private System.Windows.Forms.TextBox Type_Name;
        private System.Windows.Forms.DateTimePicker Date_Pick;
        private System.Windows.Forms.ComboBox Time_Pick;
        private System.Windows.Forms.Button Zapis_button;
        private System.Windows.Forms.Button Change_button;
    }
}