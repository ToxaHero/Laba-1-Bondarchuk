using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лабораторна_робота_1_Авторизація
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            if (textBox_login.Text == "Anton" && textBox_password.Text =="qwas")
            {
                label_ok.BackColor = Color.Green;
                MessageBox.Show("Привіт, Антон!");
            }
            else
            {
                label_ok.BackColor = Color.Red;
                MessageBox.Show("Невірний логін або пароль");
            }
        }
    }
}
