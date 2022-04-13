using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calories
{
    
    public partial class Form_Add_Items : Form
    {
        #region переменные для работы с базой через класс
        private List<string> names;
        private List<string> names_in_table;
        private string connect;
        private SqlConnection sqlConn = null;
        private string str = "";
        SqlCommand command = null;
        #endregion
        public Form_Add_Items()
        {
            InitializeComponent();
        }

        private  async  void button_Add_Click(object sender, EventArgs e)
        {
            Data_base_manager db = new Data_base_manager(ref connect);
            sqlConn = new SqlConnection(connect);
            await
             sqlConn.OpenAsync();
            db.Add_In_table(str,ref sqlConn, ref command, textBox_Name.Text, textBox_Weight.Text, textBox_Fats.Text,textBox_Cholesterol.Text, textBox_Carbohydrates.Text, textBox_Kilocalories.Text);
              Close();
            sqlConn.Close();
            
        }

        private void comboBox_table_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            Data_base_manager db = new Data_base_manager();
            db.Load_Chek(comboBox_table_name.SelectedIndex, names_in_table, ref str);
            
        }

        private void Form_Add_Items_Load(object sender, EventArgs e)
        {
            Data_base_manager db = new Data_base_manager(ref names, ref names_in_table);
            comboBox_table_name.Items.AddRange(names.ToArray());
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
