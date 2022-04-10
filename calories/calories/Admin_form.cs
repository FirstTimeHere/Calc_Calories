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
        private ListViewItem item = null; //грубо говоря он используется как sqladapter


        public Admin_form()
        {
            InitializeComponent();
        }
        private async void SqlConnect()
        {
            Data_base_manager db = new Data_base_manager(ref strConnect);
            sqlConn = new SqlConnection(strConnect);
            await
             sqlConn.OpenAsync();
        }
        private void Admin_form_Load(object sender, EventArgs e)
        {
            
            Data_base_manager db = new Data_base_manager(ref names, ref names_in_table);
            SqlConnect();
            comboBox1.Items.AddRange(names.ToArray());
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
 
            string str = "";
            for (int i = 0; i < names_in_table.Count; i++)
            {

                str = names_in_table[comboBox1.SelectedIndex];
            }

            
            SqlDataReader sqlDataReader = null;
            try
            {
                listView_table.Items.Clear();
                SqlCommand sqlCommand = new SqlCommand($"SELECT * FROM {str}", sqlConn);
                sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    item = new ListViewItem(new string[] {Convert.ToString(sqlDataReader["Name"]),
                        Convert.ToString(sqlDataReader["Weight"]),
                        Convert.ToString(sqlDataReader["Fats"]),
                        Convert.ToString(sqlDataReader["Cholesterol"]),
                        Convert.ToString(sqlDataReader["Carbohydrates"]),
                        Convert.ToString(sqlDataReader["Kilocalories"])});
                    listView_table.Items.Add(item);
                    
                }
            }
            catch (Exception ep)
            {
                MessageBox.Show(ep.ToString());
               
            }
            finally
            {
                if (sqlDataReader!=null && !sqlDataReader.IsClosed)
                {
                    sqlDataReader.Close();
                }
            }
          
           // sqlConn.Close();
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            Form_Add_Items form_Add_Items = new Form_Add_Items();
            form_Add_Items.Show();
        }
    }
}
