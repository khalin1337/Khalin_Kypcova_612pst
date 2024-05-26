using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Khalin_Kypcova_612pst.Forms
{
    public partial class Beauty : Form
    {
        public Beauty()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }

        private void Picture_Strizhka_Click(object sender, EventArgs e)
        {

        }

        private void Picture_Ukladka_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Picture_Brovi_Click(object sender, EventArgs e)
        {

        }

        private void Picture_Nigti_Click(object sender, EventArgs e)
        {

        }

        private void Picture_Farbuvanya_Click(object sender, EventArgs e)
        {

        }

        private void Picture_Vii_Click(object sender, EventArgs e)
        {

        }

        private void Picture_Kosmet_Click(object sender, EventArgs e)
        {

        }

        private void Picture_Ukladka_MouseMove(object sender, MouseEventArgs e)
        {
            label_Ukladka.Visible = true;
        }

        private void Picture_Ukladka_MouseLeave(object sender, EventArgs e)
        {
            label_Ukladka.Visible = false;
        }

        private void Picture_Strizhka_MouseMove(object sender, MouseEventArgs e)
        {
            label_strizhka.Visible = true;
        }

        private void Picture_Strizhka_MouseLeave(object sender, EventArgs e)
        {
            label_strizhka.Visible = false;
        }

        private void Picture_Nigti_MouseMove(object sender, MouseEventArgs e)
        {
            label_Nigti.Visible = true;
        }

        private void Picture_Nigti_MouseLeave(object sender, EventArgs e)
        {
            label_Nigti.Visible= false;
        }

        private void Picture_Farbuvanya_MouseMove(object sender, MouseEventArgs e)
        {
            label_Farbuvanya.Visible = true;
        }

        private void Picture_Farbuvanya_MouseLeave(object sender, EventArgs e)
        {
            label_Farbuvanya.Visible= false;
        }

        private void Picture_Vii_MouseMove(object sender, MouseEventArgs e)
        {
            label_Vii.Visible = true;
        }

        private void Picture_Vii_MouseLeave(object sender, EventArgs e)
        {
            label_Vii.Visible = false;
        }

        private void Picture_Brovi_MouseMove(object sender, MouseEventArgs e)
        {
            label_Brovi.Visible = true;
        }

        private void Picture_Brovi_MouseLeave(object sender, EventArgs e)
        {
            label_Brovi.Visible = false;
        }

        private void Picture_Kosmet_MouseMove(object sender, MouseEventArgs e)
        {
            label_Kosmetolog.Visible = true;
        }

        private void Picture_Kosmet_MouseLeave(object sender, EventArgs e)
        {
            label_Kosmetolog.Visible = false;
        }
    }
}
