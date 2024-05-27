using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Khalin_Kypcova_612pst.Classes;
using Khalin_Kypcova_612pst.Forms;

namespace Khalin_Kypcova_612pst
{
    public partial class Login : Form
    {
        List<IUser> users = new List<IUser>();
        

        public Login()
        {
            InitializeComponent();
            Serializacion.DeserializationFromJson(ref users,"Users.json");
        }

        private void Log_in_button_Click(object sender, EventArgs e)
        {
            IUser Buffer = users.FirstOrDefault(user => user.Email == Log_in_email.Text.ToString());

            if (Buffer != null)
            {
                if (Buffer.Password == Log_In_pasword.Text)
                {
                    DataBank.CurentUser = Buffer;
                    Beauty beauty = new Beauty();
                    beauty.Show();
                    this.Hide();
                }

            }
            else
            {
                MessageBox.Show("Hевірний Email або Пароль");
                Log_In_pasword.Text = "Password";
                Log_In_pasword.UseSystemPasswordChar = false;
                Log_in_email.Text = "Email";
            }
        }



        private void Log_in_email_Leave(object sender, EventArgs e)
        {
            if (Log_in_email.Text.Length == 0) Log_in_email.Text = "Email";
            else if (!Log_in_email.Text.Contains('@')) Log_in_email.Text += "@gmail.com";
        }

        private void Log_in_email_Enter(object sender, EventArgs e)
        {

            if (Log_in_email.Text == "Email") Log_in_email.Text = string.Empty;
        }

        private void Log_In_pasword_Leave(object sender, EventArgs e)
        {
            if (Log_In_pasword.Text.Length == 0)
            { 
                Log_In_pasword.UseSystemPasswordChar = false;
                Log_In_pasword.Text = "Password";
            }
        }

        private void Log_In_pasword_Enter(object sender, EventArgs e)
        {
            Log_In_pasword.UseSystemPasswordChar = true;
            if (Log_In_pasword.Text == "Password") Log_In_pasword.Text = string.Empty;
        }
    }
}
