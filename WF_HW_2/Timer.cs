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
    public partial class Timer : Form
    {
        
        int Counter = 0;
        public Timer()
        {
            InitializeComponent();
            bt_stop.Enabled = false;
            timer1.Tick += new EventHandler(ShowTimer);
        }

        private void ShowTimer(object sender, EventArgs e)
        {
            timer1.Stop();
            MessageBox.Show("Timer finishes the work", "Timer");
            bt_stop.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bt_stop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            MessageBox.Show("Timer stops before Time ends", "Timer");
            bt_stop.Enabled = false;
        }

        private void bt_start_Click(object sender, EventArgs e)
        {
            if (NumericSecond.Value <= 0)
            {
                MessageBox.Show("Warning! Enter seconds more than 0");
            }
            else
            {
                bt_stop.Enabled = true;
                timer1.Interval = Decimal.ToInt32(NumericSecond.Value) * 1000;
                timer1.Start();


            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
