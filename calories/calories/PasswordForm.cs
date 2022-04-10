using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calories
{
    public partial class PasswordForm : Form
    {
        public PasswordForm()
        {
            InitializeComponent();
        }

        private void textBox_Password_TextChanged(object sender, EventArgs e)
        {
            textBox_Password.PasswordChar = '*';
        }

        private void button_Accept_Click(object sender, EventArgs e)
        {
            if (textBox_Password.Text=="admin" && textBox_Login.Text=="admin") //сделано на будущее, добавить шифрование (на крайний случай сохранение и сравнение в файл)
            {
               
                Admin_form admin_ = new Admin_form();
                admin_.Show();
                Close();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль");
            }
        }

      
    }
}
