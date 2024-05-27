using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Khalin_Kypcova_612pst.Classes
{
    public partial class Zapis : Form
    {
        List<Order> orders = new List<Order>();
        string[] Info = null;
        public Zapis()
        {
            InitializeComponent();
            Type_Name.Text = DataBank.TypeInfo.ToString();
            Text_info.Text = DataBank.TextInfo;
            if (DataBank.CurentUser is Guest) 
            {
                Date_Pick.Visible = true;
                Date_Pick.Value = DateTime.Now;
                Time_Pick.Visible = true;
                Time_Pick.SelectedIndex = -1;
                Zapis_button.Visible = true;
            }
            else Change_button.Visible = true;
            Date_Pick.MinDate = DateTime.Now;
            Serializacion.DeserializationFromJson(ref Info, "Type.json");
            Serializacion.DeserializationFromJson(ref orders, "Orders.json");
        }

        private void zapis_button_Click(object sender, EventArgs e)
        {   if (Time_Pick.SelectedIndex == -1)
                MessageBox.Show("Оберіть час запису");
            else
            {

                DateTime Datetime_ = new DateTime(Date_Pick.Value.Year, Date_Pick.Value.Month, Date_Pick.Value.Day, Int32.Parse(Time_Pick.Text.ToString().Substring(0, 2)), 00, 00);
                // if (!orders.Exists(order => order.Date == Datetime_))
                if (!orders.Any(order => order.Date == Datetime_ && order.type == DataBank.TypeInfo))
                {
                    orders.Add(new Order(orders.Last().Id+1,DataBank.CurentUser, DataBank.TypeInfo, Datetime_));
                    this.Close();
                }
                else MessageBox.Show("На цей час вже е запис");
            }
        }

        private void Change_button_Click(object sender, EventArgs e)
        {
            if (Change_button.Text.ToString() == "Редагувати")
                Change_button.Text = "Зберегти";
            else Change_button.Text = "Редагувати";
            if (Text_info.ReadOnly == false) Text_info.ReadOnly = true;
            else Text_info.ReadOnly = false;
            Text_info.SelectAll();
            Info[(int)DataBank.TypeInfo] = Text_info.Text.ToString();
        }

        private void Zapis_FormClosing(object sender, FormClosingEventArgs e)
        {
            Serializacion.SerialiazeToJson(ref Info, "Type.json");
            Serializacion.SerialiazeToJson(ref orders, "Orders.json");
        }
    }
}
