using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace Khalin_Kypcova_612pst.Classes
{
    public class Admin: User
    {
        public int Id { get => id; set { id = value; } }
        public string Email { get => this.email; set { email = value; } }
        public string Name { get => this.name; set { name = value; } }
        public string Password { get => this.password; set { password = value; } }
        public string Phone { get => this.phone; set { phone = value; } }

        public Admin(int _id, string _email, string _name, string _password, string _phone)
        {
            Id++;
            Email = _email;
            Name = _name;
            Password = _password;
            Phone = _phone;
        }
    }
}
