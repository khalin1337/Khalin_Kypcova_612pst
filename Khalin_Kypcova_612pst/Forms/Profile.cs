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
    public partial class Profile : Form
    {
        List<IUser> users = new List<IUser>();
        public Profile()
        {
            InitializeComponent();
            Serializacion.DeserializationFromJson(ref users, "Users.json");
            IUser user = users.FirstOrDefault(x=> x.Id == DataBank.CurentUser.Id);
            Profile_email.Text = user.Email;
            Profile_Name.Text = user.Name;
            Profile_pasword.Text = user.Password;
            Profile_phone.Text = user.Phone;
            
        }

        private void Profile_button_Click(object sender, EventArgs e)
        {
            int indextoupdate = users.FindIndex(x=>x.Id == DataBank.CurentUser.Id);
            if (Profile_email.Text.Contains('@') && Profile_email.Text.Contains("."))
            {
                if (Profile_pasword.Text.Length > 8)
                {
                    if (Profile_phone.Text.Length == 13)
                    {
                        if (Profile_Name.Text.Trim().Length > 4)
                        {
                            users[indextoupdate].Name = Profile_Name.Text;
                            users[indextoupdate].Email = Profile_email.Text;
                            users[indextoupdate].Password = Profile_pasword.Text;
                            users[indextoupdate].Phone = Profile_phone.Text;
                            Serializacion.SerialiazeToJson(ref users, "Users.json");
                        }
                        else
                        {
                            MessageBox.Show("Ім'я має бути щонайменше 4 символи");
                            Profile_Name.Text = "";
                        }
                    }
                    else
                    {
                        MessageBox.Show("Неправильний формат телефону");
                        Profile_phone.Text = "+380";
                    }
                }
                else
                {
                    MessageBox.Show("У паролі має бути щонайменше 8 символів");
                    Profile_pasword.Text = string.Empty;
                }
            }
            else
            {
                MessageBox.Show("Формат Email неправильний");
                Profile_email.Text = string.Empty;
            }
        }

        private void Profile_FormClosing(object sender, FormClosingEventArgs e)
        {
           // Serializacion.SerialiazeToJson(ref users, "User.json");
        }
    }
   
}
