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
    public partial class Orders : Form
    {
        List<Order> orders = new List<Order>();

        public Orders()
        {
            InitializeComponent();
            Serializacion.DeserializationFromJson(ref orders, "Orders.json");
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Id", typeof(int));
            dataTable.Columns.Add("Дата та час", typeof(DateTime));
            dataTable.Columns.Add("Телефон клієнту", typeof(string));
            dataTable.Columns.Add("Вид послуги", typeof(Khalin_Kypcova_612pst.Classes.Type));
            if (DataBank.CurentUser is Admin)
            {
                foreach (Order order in orders) { dataTable.Rows.Add(order.Id, order.Date, order.user.Phone, order.type); }
            }
            else 
            {
                List<Order> GuestOrders = orders.Where(order => order.user.Id == DataBank.CurentUser.Id).ToList();
                foreach (Order order in GuestOrders) { dataTable.Rows.Add(order.Id, order.Date, order.user.Phone, order.type); } 
            }
            DataGrid_orders.DataSource = dataTable;
            DataGrid_orders.AllowUserToAddRows = false;
        }

        private void OrdersTime_button_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            //DataGrid_orders.DataSource = null;
            List<Order> GuestOrders = orders.Where(order => order.Date >= DateTime.Now).ToList();
            foreach (Order order in GuestOrders) { dataTable.Rows.Add(order.Id, order.Date, order.user.Phone, order.type); }
            DataGrid_orders.DataSource = dataTable;

        }

        private void Datetime_orders_ValueChanged(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            //DataGrid_orders.DataSource = null;
            List<Order> GuestOrders = orders.Where(order => order.Date == Datetime_orders.Value).ToList();
            foreach (Order order in GuestOrders) { dataTable.Rows.Add(order.Id, order.Date, order.user.Phone, order.type); }
            DataGrid_orders.DataSource = dataTable;
        }
    }
}
