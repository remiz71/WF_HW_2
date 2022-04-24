using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WF_HW_2
{
    public partial class Anketa : Form
    {
        public Anketa()
        {
            InitializeComponent();
        }

        

        string[] Russia_list = new string[]
        {
            "Москва",
            "Новомосковск",
            "Питер"
        };
        string[] Ukraine_list = new string[]
        {
            "Киев",
            "Мариуполь",
            "Львов"
        };
        string[] Belorus_list = new string[]
        {
            "Гомель",
            "Минск",
            "Могилёв"
        };
        string[] China_list = new string[]
        {
            "Пекин",
            "Тайвань",
            "Шенгжень"
        };

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int _res = comboBox1.SelectedIndex;
            switch (_res)
            {
                case 0:
                    comboBox2.Items.Clear();
                    comboBox2.Items.AddRange(Russia_list);
                    break;
                case 1:
                    comboBox2.Items.Clear();
                    comboBox2.Items.AddRange(Ukraine_list);
                    break;
                case 2:
                    comboBox2.Items.Clear();
                    comboBox2.Items.AddRange(Belorus_list);
                    break;
                case 3:
                    comboBox2.Items.Clear();
                    comboBox2.Items.AddRange(China_list);
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_surname.Text == "" || _fName.Text == "" || comboBox1.Text == "" || comboBox2.Text == "" || _phone.Text == "")
                MessageBox.Show("Вы не заполнили все обязательные поля");
            else
            {
                string UserData = "ФИО: " + _surname.Text + "  " + _fName.Text
                    + "  " + _sName.Text + "\n";
                UserData += "Место жительства: " + comboBox1.Text + "  "
                    + comboBox2.Text + "\n";
                UserData += "Телефон: " + "  " + _phone.Text + "\n";
                UserData += "Дата рождения: " + "  " + dateTimePicker1.Value.ToShortDateString()
                    + "\n";
                if (_male.Checked == true) UserData += "Пол: мужской" + "\n";
                else UserData += "Пол: женский" + "\n";
                MessageBox.Show(UserData, "Анкетные данные");
                try
                    {
                    StreamWriter sw = new StreamWriter($"{_surname.Text}.dat");
                    sw.WriteLine(UserData);
                    sw.Close();
                    MessageBox.Show($"Cохранено в файл {_surname.Text}.dat","Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("Ошибка сохранения в файл", "ERROR", MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                    
                
            }
        }
    }
}
