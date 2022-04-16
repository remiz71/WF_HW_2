using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_HW_2
{
    public partial class Coordinates : Form
    {
        public Coordinates()
        {
            InitializeComponent();
        }

        private string CoordinatesToString(MouseEventArgs e)
        {
            return "Координаты мышки: X= " + e.X.ToString() + "; Y= "
                + e.Y.ToString();
        }




        private void Coordinates_MouseMove(object sender, MouseEventArgs e)
        {
            Text = CoordinatesToString(e);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            Text = CoordinatesToString(e);
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            Text = CoordinatesToString(e);
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            string message = " ";
            string caption = "Задание с координатами";
            if (e.Button == MouseButtons.Left) //ЛКМ
            {
                message = "Вы кликнули за пределами синей зоны";
                MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }
            if (e.Button == MouseButtons.Right) //ПКМ
            {
                caption = "\n" + panel1.Size.ToString();
                MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void panel2_MouseClick(object sender, MouseEventArgs e)
        {
            string message = " ";
            string caption = "Задание с координатами";
            if (e.Button == MouseButtons.Left)
            {
                if (e.X == 0 || e.Y == 0)
                {
                    message = "Клик на границе синей зоны";
                    MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    message = "Клик в синей зоне";
                    MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            if (e.Button == MouseButtons.Right)
            {

                caption = "\n" + panel2.Size.ToString();
                MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
