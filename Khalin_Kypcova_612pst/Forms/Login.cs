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

namespace Khalin_Kypcova_612pst
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            
        }

        private void Log_in_button_Click(object sender, EventArgs e)
        {

        }



        private void Log_in_email_Leave(object sender, EventArgs e)
        {
            if (Log_in_email.Text.Length == 0) Log_in_email.Text = "Email";
        }

        private void Log_in_email_Enter(object sender, EventArgs e)
        {
            Log_in_email.Text = string.Empty;
        }

        private void Log_In_pasword_Leave(object sender, EventArgs e)
        {
            if (Log_In_pasword.Text.Length == 0) Log_In_pasword.Text = "Email";
        }

        private void Log_In_pasword_Enter(object sender, EventArgs e)
        {
            Log_In_pasword.Text = string.Empty;
        }
    }
}
