using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Khalin_Kypcova_612pst.Classes;

namespace Khalin_Kypcova_612pst.Forms
{
    public partial class SignUp : Form
    {
        List<IUser> users = new List<IUser>();
        public SignUp()
        {
            InitializeComponent();
            Serializacion.DeserializationFromJson(ref users, "Users.json");
        }

        private void Sign_Up_email_Enter(object sender, EventArgs e)
        {
            if (Sign_Up_email.Text == "Email") Sign_Up_email.Text = string.Empty;
        }

        private void Sign_Up_email_Leave(object sender, EventArgs e)
        {
            if (Sign_Up_email.Text.Length == 0) Sign_Up_email.Text = "Email";
            else if (!Sign_Up_email.Text.Contains('@')) Sign_Up_email.Text += "@gmail.com";
        }

        private void Sign_Up_pasword_Leave(object sender, EventArgs e)
        {
            if (Sign_Up_pasword.Text.Length == 0)
            {
                Sign_Up_pasword.UseSystemPasswordChar = false;
                Sign_Up_pasword.Text = "Password";
            }
        }

        private void Sign_Up_pasword_Enter(object sender, EventArgs e)
        {
            Sign_Up_pasword.UseSystemPasswordChar = true;
            if (Sign_Up_pasword.Text == "Password") Sign_Up_pasword.Text = string.Empty;
        }

        private void Sign_up_phone_Leave(object sender, EventArgs e)
        {
            if (Sign_up_phone.Text.Length == 0) Sign_up_phone.Text = "Phone";
        }

        private void Sign_up_phone_Enter(object sender, EventArgs e)
        {
            if (Sign_up_phone.Text == "Phone") Sign_up_phone.Text = string.Empty;
        }

        private void Sign_Up_Name_Enter(object sender, EventArgs e)
        {
            if (Sign_Up_Name.Text == "Name") Sign_Up_Name.Text = string.Empty;

        }

        private void Sign_Up_Name_Leave(object sender, EventArgs e)
        {
            if (Sign_Up_Name.Text.Length == 0) Sign_Up_Name.Text = "Name";
        }

        private void SignUp_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Sign_Up_Name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                Sign_Up_button_Click(Sign_Up_button, null);
            }
        }

        private void Sign_Up_button_Click(object sender, EventArgs e)
        {
            if (Sign_Up_email.Text.Contains('@') && Sign_Up_email.Text.Contains(".")) 
            {
                if (Sign_Up_pasword.Text.Length > 8)
                {
                    if (Sign_up_phone.Text.Length == 13)
                    {
                        if (Sign_Up_Name.Text.Trim().Length> 4)
                        {
                            if (Admin_chek.Checked)
                            {
                                users.Add(new Admin(users.Last().Id + 1, Sign_Up_email.Text, Sign_Up_Name.Text, Sign_Up_pasword.Text, Sign_up_phone.Text));
                                DataBank.CurentUser = users.Last();
                                Serializacion.SerialiazeToJson(ref users, "Users.json");
                                Beauty beauty = new Beauty();
                                beauty.Show();
                                this.Hide();
                            }
                            else
                            {
                                users.Add(new Guest(users.Last().Id + 1, Sign_Up_email.Text, Sign_Up_Name.Text, Sign_Up_pasword.Text, Sign_up_phone.Text));
                                DataBank.CurentUser = users.Last();
                                Serializacion.SerialiazeToJson(ref users, "Users.json");
                                Beauty beauty = new Beauty();
                                beauty.Show();
                                this.Hide();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Ім'я має бути щонайменше 4 символи");
                            Sign_Up_Name.Text = "";
                        }
                    }
                    else
                    {
                        MessageBox.Show("Неправильний формат телефону");
                        Sign_Up_pasword.Text = "+380";
                    }
                }
                else
                {
                    MessageBox.Show("У паролі має бути щонайменше 8 символів");
                    Sign_Up_pasword.Text = string.Empty;
                }
            }
            else
            {
                MessageBox.Show("Формат Email неправильний");
                Sign_Up_email.Text = string.Empty;
            }
            
           
           

        }

        private void Sign_Up_email_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                Sign_Up_pasword.Focus();
            }
        }

        private void Sign_Up_pasword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                Sign_up_phone.Focus();
            }
        }

        private void Sign_up_phone_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                Sign_Up_Name.Focus();
            }
        }
    }
}
