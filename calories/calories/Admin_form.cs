using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calories
{
    public partial class Admin_form : Form
    {
        // private string strConnect = ConfigurationManager.ConnectionStrings["TestDB"].ConnectionString;
        private SqlConnection sqlConn = null;
        private List<string> names = new List<string>();
        private List<string> names_in_table = new List<string>();
        private string strConnect;
       private DataSet dataSet;
       private SqlDataAdapter adapter;
        SqlCommand sqlCommand = null;//грубо говоря он используется как sqladapter
        



        public Admin_form()
        {
            InitializeComponent();
        }
        private async void SqlConnect()
        {
            Data_base_manager db = new Data_base_manager(ref strConnect);
            sqlConn = new SqlConnection(strConnect);
            await sqlConn.OpenAsync();
            
        }
        private void Admin_form_Load(object sender, EventArgs e)
        {
           
            SqlConnect();         
            Data_base_manager db = new Data_base_manager(ref names, ref names_in_table);
            comboBox1.Items.AddRange(names.ToArray());
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnect();
            Data_base_manager db = new Data_base_manager();
           string str = "";
            db.Load_Chek(comboBox1.SelectedIndex, names_in_table,ref str);
            db.Select_in_table(str, ref adapter, ref dataSet, strConnect);
           
            /* SqlDataAdapter adapter = new SqlDataAdapter($"SELECT * FROM {str}", strConnect);
             DataSet dataSet = new DataSet();
             adapter.Fill(dataSet);*/
            dataGridView_edit_table.DataSource = dataSet.Tables[0];
            dataGridView_edit_table.Columns[0].Visible = false;
            text_box_VIsible_and_Enable(1);
            sqlConn.Close();

        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            Form_Add_Items form_Add_Items = new Form_Add_Items();
            form_Add_Items.Show();
            
        }

        private void button_Edit_Click(object sender, EventArgs e)
        {
            SqlConnect();
            Data_base_manager db = new Data_base_manager(ref strConnect);
            string str = "";
            db.Load_Chek(comboBox1.SelectedIndex, names_in_table, ref str);
            int id =Convert.ToInt32( dataGridView_edit_table.CurrentRow.Cells[$"Id{str}"].Value.ToString());
            db.Edit_In_table(str, ref sqlConn, ref sqlCommand,
                id, textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text);
            //name, weight, fats, cholesterol, carbohydrates, kilocalories
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            text_box_VIsible_and_Enable(1);
            db.Select_in_table(str, ref adapter,  ref dataSet, strConnect);
            dataGridView_edit_table.DataSource = dataSet.Tables[0];
            dataGridView_edit_table.Columns[0].Visible = false;
            sqlConn.Close();
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            SqlConnect();
            Data_base_manager db = new Data_base_manager(ref strConnect);
            string str = "";


            db.Load_Chek(comboBox1.SelectedIndex, names_in_table, ref str);
            db.Remove_in_table(str, ref sqlConn, ref sqlCommand, dataGridView_edit_table.CurrentRow.Cells[$"Id{str}"].Value.ToString());
           //вместо рефреша
            db.Select_in_table(str, ref adapter, ref dataSet, strConnect);
            dataGridView_edit_table.DataSource = dataSet.Tables[0];
            dataGridView_edit_table.Columns[0].Visible = false;
            sqlConn.Close();
        }
        private int text_box_VIsible_and_Enable(int x)
        {
            if (x==0)
            {
                textBox1.Visible = textBox1.Enabled = true;
                textBox2.Visible = textBox2.Enabled = true;
                textBox3.Visible = textBox3.Enabled = true;
                textBox4.Visible = textBox4.Enabled = true;
                textBox5.Visible = textBox5.Enabled = true;
                textBox6.Visible = textBox6.Enabled = true;
            }
            else if(x==1)
            {
                textBox1.Visible = textBox1.Enabled = false;
                textBox2.Visible = textBox2.Enabled = false;
                textBox3.Visible = textBox3.Enabled = false;
                textBox4.Visible = textBox4.Enabled = false;
                textBox5.Visible = textBox5.Enabled = false;
                textBox6.Visible = textBox6.Enabled = false;
            }
            
            return x;
        }
        private void dataGridView_edit_table_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            text_box_VIsible_and_Enable(0);
            textBox1.Text = dataGridView_edit_table.CurrentRow.Cells["Name"].Value.ToString();
            textBox2.Text = dataGridView_edit_table.CurrentRow.Cells[2].Value.ToString();
            textBox3.Text = dataGridView_edit_table.CurrentRow.Cells[3].Value.ToString();
            textBox4.Text = dataGridView_edit_table.CurrentRow.Cells[4].Value.ToString();
            textBox5.Text = dataGridView_edit_table.CurrentRow.Cells[5].Value.ToString();
            textBox6.Text = dataGridView_edit_table.CurrentRow.Cells[6].Value.ToString();
   
        }
    }
}
