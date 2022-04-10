using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace calories
{
    public partial class calc : Form
    {

        private string filename = "D://дневник.txt";//сохранение в "дневник"
        private double foodcalories { get; set; } //калории еды
        private double jymcalories { get; set; }       
        private double Weight_calories { get; set; }
        private double savecalories { get; set; }
        private double savecaloriesforjym { get; set; }//счетчики сохранения
        private List<string> names;
        private List<string> names_in_table;
        private string strConnect=null;
        private SqlConnection sqlConn = null; //строка подключения
        public string SaveName //в данном случая мне НЕ надо перезапускать(закрывать форму)
        {
            get { return label_name_from_table.Text; }
            set { label_name_from_table.Text = value; }
        }
        public string SaveWeight //в данном случая мне НЕ надо перезапускать(закрывать форму)
        {
            get { return label_weight_from_table.Text; }
            set { label_weight_from_table.Text = value; }
        }
        public double SaveKkal //в данном случая мне НЕ надо перезапускать(закрывать форму)
        {
            get { return savecalories; }
            set { savecalories = value; }
        }
        public string Savekkalfromlabel // отображаем полученные вычисления
        {
            get { return score_food.Text; }
            set { score_food.Text = value; }
        }

        private void SELECTSqlCheckBox()
        {
            Data_base_manager db = new Data_base_manager(ref names,ref names_in_table);
            comboBox1.Items.AddRange(names.ToArray());
        }
        private async void CheckConnection()
        {
            Data_base_manager db = new Data_base_manager(ref strConnect);
            //надо понять как правильно работает асинхронный метод
            sqlConn = new SqlConnection(strConnect);
            await
             sqlConn.OpenAsync();
        }
        public calc()
        {
            InitializeComponent();

        }

        private void calc_Load(object sender, EventArgs e)
        {
            text_calories.ReadOnly = true;
            SELECTSqlCheckBox();
            CheckConnection();

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            string str = "";
            for (int i = 0; i < names_in_table.Count; i++)
            {

                str = names_in_table[comboBox1.SelectedIndex];
            }

            SqlDataAdapter adapter = new SqlDataAdapter($"SELECT * FROM {str}", strConnect);
            DataSet dataSet = new DataSet();

            adapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
            dataGridView1.Columns[0].Visible = false;
            sqlConn.Close();
        }

        private void score_calories()
        {
            try
            {

                foodcalories = Convert.ToDouble(text_calories.Text);
               
                savecalories += foodcalories;
                score_food.Text = foodcalories.ToString();
                label_save_calories.Text = savecalories.ToString();
                

            }
            catch (Exception e)
            {

                MessageBox.Show(e.ToString(), "Ошибка форматирования");
            }


        }
        private void score_Weight()
        {
            try
            {
                 double weight_score=
                  Convert.ToDouble(textBox_weight_user.Text);
                Weight_calories = Convert.ToDouble(label_weight_from_table.Text);

                //стандарт веса таблицы*x=текущий вес* стандарт количества калорий в таблице
                double food_score_text = (weight_score * Convert.ToDouble(dataGridView1.CurrentRow.Cells["Kilocalories"].Value.ToString()) / Weight_calories);
                score_food.Text = food_score_text.ToString();
                savecalories +=food_score_text;
                label_save_calories.Text = savecalories.ToString();
                
                

            }
            catch (Exception e)
            {

                MessageBox.Show(e.ToString(), "Ошибка форматирования");
            }


        }
        private void jym_calories()
        {
            try
            {

                jymcalories = Convert.ToDouble(text_calories_jym.Text);
                savecaloriesforjym += jymcalories;
                score_jym.Text = savecaloriesforjym.ToString();
                

            }
            catch (Exception e)
            {

                MessageBox.Show(e.ToString(), "Ошибка форматирования");
            }

        }

        private void text_calories_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                score_calories();
                Save_In_File();
                text_calories.Clear();
            }

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            text_calories.Text = dataGridView1.CurrentRow.Cells["Kilocalories"].Value.ToString();
            label_name_from_table.Text = dataGridView1.CurrentRow.Cells["Name"].Value.ToString();
            label_weight_from_table.Text = dataGridView1.CurrentRow.Cells["Weight"].Value.ToString();
        }

        private void User_input_button_Click(object sender, EventArgs e)
        {
            User_input_form user_Input_Form = new User_input_form();
            //делаем родителем форму calc чтобы данные передавались из формы userinput...
            user_Input_Form.Owner = this;
            user_Input_Form.ShowDialog();
            score_food.Text = Savekkalfromlabel;
            textBox_weight_user.Text = SaveWeight; 
            Save_In_File();
            label_save_calories.Text = savecalories.ToString();
            textBox_weight_user.Clear();


        }

        private void text_calories_jym_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                jym_calories();
                Save_In_File_jym();
                text_calories_jym.Clear();
            }
        }

        private async void Save_In_File_jym()
        {
            try
            {
                DateTime time = DateTime.Now;
                FileInfo fileInfo = new FileInfo(filename);
                StreamWriter write_text_in_file = new StreamWriter(filename, true);
                if (!fileInfo.Exists)
                {
                    File.Create(filename);
                    write_text_in_file.Close();
                }
               
                await write_text_in_file.WriteLineAsync($"{time}|{label_score_jym.Text} - {score_jym.Text}");
                write_text_in_file.Close();
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        private async  void Save_In_File()
        {
            try
            {
                StreamWriter write_text_in_file = new StreamWriter(filename, true);
                DateTime time = DateTime.Now;
                FileInfo fileInfo = new FileInfo(filename);
                if (!fileInfo.Exists)
                {
                    fileInfo.Create();
                    write_text_in_file.Close();
                }
              
                
                    await write_text_in_file.WriteLineAsync($"{time}|{label_name_from_table.Text} - Грамм : {textBox_weight_user.Text}, Калорий: {score_food.Text}");
                    write_text_in_file.Close();
                
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        private   void textBox_weight_user_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                score_Weight();
                Save_In_File();
                textBox_weight_user.Clear();
            }
        }

        private void checkBox_Visible_Textbox_calories_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Visible_Textbox_calories.Checked==true)
            {
                text_calories.ReadOnly = false;
            }
            else
            {
                text_calories.ReadOnly = true;
            }
        }
        private void Clear_All_results()//для очистки всех полей
        {
            textBox_weight_user.Clear();
            score_food.Text = "0";
            score_jym.Text = "0";
            label_name_from_table.Text = "";
            label_weight_from_table.Text = "0";
            text_calories.Clear();
            text_calories_jym.Clear();
            label_save_calories.Text = "0";
            savecalories = 0;

        }
    private async void button_save_sum_Click(object sender, EventArgs e)
    {
       
            try
            {

                FileInfo fileInfo = new FileInfo(filename);
                    StreamWriter write_text_in_file = new StreamWriter(filename, true);
                    if (!fileInfo.Exists)
                {
                    File.Create(filename);
                        write_text_in_file.Close();
                    }
               
                await write_text_in_file.WriteLineAsync($"{label6.Text} - {label_save_calories.Text}\n");
                write_text_in_file.Close();
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        
    }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите очистить все данные? После очистки все введеные вами данные будут удалены","Очистка данных",MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                Clear_All_results();
            }
        }

        private void textBox_Search_TextChanged(object sender, EventArgs e)
        {
            if (dataGridView1.DataSource == null)
            {
                MessageBox.Show("Предупреждение!\n" +
               "Поиск работает ТОЛЬКО с выбранной таблицей\n" +
               "Пожалуйста убедитесь что вы выбрали таблицу\n","Ошибка поискового запроса");  
            }
            else
            {
                try
                {
                    (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"Name LIKE '%{textBox_Search.Text}%'";
                }
                catch (Exception eq)
                {
                    MessageBox.Show(eq.ToString());

                }
            }
            
            
        }

       
    }
}
