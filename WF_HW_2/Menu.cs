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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Coordinates_Click(object sender, EventArgs e)
        {
            Coordinates CoordForm = new Coordinates();
            CoordForm.ShowDialog();
        }

        private void Timer_bt_Click(object sender, EventArgs e)
        {
            Timer timer = new Timer();
            timer.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Anketa anketa = new Anketa();
            anketa.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int Counter = 0;
            string _message = "Ремизов Дмитрий";
            string _caption = "О Себе";
            MessageBox.Show(_message, _caption);
            Counter += _message.Length + _caption.Length;
            _message = "Возраст: 28 лет";
            MessageBox.Show(_message, _caption);
            Counter += _message.Length + _caption.Length;
            _message = "Вид деятельности: Инженер линии финальной доработки кузова на автомобильном заводе";
            Counter += _message.Length + _caption.Length;
            _caption = (Counter / 3).ToString();
            MessageBox.Show(_message, _caption);
        }
    }
}
