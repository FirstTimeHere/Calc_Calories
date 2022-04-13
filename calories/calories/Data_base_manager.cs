using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calories
{
    // Этот класс нужен для будущей оптимизации, чтобы в нем проводились все операции по базе данных
   public class Data_base_manager
    {
        #region Переменные для работы с базой
        private List<string> Names_tables_list=new List<string>(){"Молоко","Кисломолочные продукты","Творожные изделия","Молочные консервы","Кулинарные изделия",
            "Мороженое", "Сыры", "Масло, маргарин, майонез", "Яйца", "Мясо", "Мясные субродукты", "Готовые блюда из мяса птицы", "Мясные готовые блюда",
            "Готовые морепродукты", "Морепродукты", "Хлеб", "Мучные изделия", "Супы", "Готовые блюда", "Каши", "Орехи", "Овощи", "Грибы", "Фрукты",
            "Ягоды", "Варенье", "Кондитерские изделия", "Соки", "Безалкогольные напитки", "Алкогольные напитки"};  
        private List<string> Names_tables_in_bd = new List<string>(){ "Milk","Dairy_products","Curd_products","Canned_milk","Culinary_products_from_dairy_products",
            "Ice_cream", "Cheese", "Butter_margarine_mayonnaise", "Eggs", "Meat", "Organ_meats", "Prepared_poultry_dishes", "Meat_ready_meals",
            "Ready_seafood", "Seafood", "Bread", "Flour_products", "Soups", "Ready_meals", "Porridges", "Nuts", "Vegetables", "Mushrooms", "Fruit",
            "Berries", "Jam", "Confectionery", "Juices", "Soft_drinks", "Alcoholic_drinks" };//доделать функционал программы, придумать как можно брать название таблиц из бд
        private readonly string strConnect = ConfigurationManager.ConnectionStrings["TestDB"].ConnectionString; //путь к базе, подробнее в APP.config
        #endregion
        public Data_base_manager(ref List<string> nametables,ref List<string> nametables_in_bd)
        {
            //конструктор названий таблиц в базе и их расшифровка на русском 
            //(в будщем благодаря list можно будет создавать таблицы и заносить имена сюда
            nametables = this.Names_tables_list;
            nametables_in_bd = this.Names_tables_in_bd;

        }
       
        public  Data_base_manager(ref string connect)
        {
            //конструктор строки подключения
            connect = strConnect;
           
        }
        public Data_base_manager()
        {

        }
        //метод Load_Chek добавляет в combobox названия таблиц
        public void Load_Chek(int combobox, List<string> names_in_table, ref string str)
        {        
            for (int i = 0; i < names_in_table.Count; i++)
            {
                str = names_in_table[combobox];
            }
        }
        //метод Add_In_table добавляет данные в выбранную таблицу, его можно использовать в любой форме
        public void  Add_In_table(string str_table,ref SqlConnection sqlcon, ref SqlCommand command, 
                                                  string name_text_box, string weight_text_box, string fats_text_box,
                                                  string Cholesterol_text_box, string Carbohydrates_text_box, string Kilocalories_text_box)
        {
            command = new SqlCommand($"INSERT INTO [{str_table}] (Name, Weight, Fats, Cholesterol,Carbohydrates, Kilocalories) VALUES (@Name, @Weight, @Fats, @Cholesterol,@Carbohydrates, @Kilocalories)", sqlcon);
            command.Parameters.AddWithValue("Name", name_text_box);
            command.Parameters.AddWithValue("Weight", weight_text_box);
            command.Parameters.AddWithValue("Fats", fats_text_box);
            command.Parameters.AddWithValue("Cholesterol", Cholesterol_text_box);
            command.Parameters.AddWithValue("Carbohydrates", Convert.ToDecimal(Carbohydrates_text_box));
            command.Parameters.AddWithValue("Kilocalories", Kilocalories_text_box);
            
            command.ExecuteNonQuery();
        }
        public  void Edit_In_table(string str_table, ref SqlConnection sqlcon, ref SqlCommand command,
                                                int id, string name_text_box, string weight_text_box, 
                                                string fats_text_box,  string Cholesterol_text_box, 
                                                string Carbohydrates_text_box, string Kilocalories_text_box)
        {
            command = new SqlCommand($"UPDATE  [{str_table}] SET Name=@Name, Weight=@Weight, Fats=@Fats,Cholesterol=@Cholesterol, Carbohydrates=@Carbohydrates, Kilocalories=@Kilocalories WHERE Id{str_table}={id}", sqlcon);
          
            command.Parameters.AddWithValue("Name", name_text_box);
            command.Parameters.AddWithValue("Weight", weight_text_box);
            command.Parameters.AddWithValue("Fats", fats_text_box);
            command.Parameters.AddWithValue("Cholesterol",  Cholesterol_text_box);
            command.Parameters.AddWithValue("Carbohydrates", Convert.ToDecimal(Carbohydrates_text_box));
            command.Parameters.AddWithValue("Kilocalories", Kilocalories_text_box);

            command.ExecuteNonQuery();
        }
        public void Select_in_table(string table_name, ref SqlDataAdapter adapter, ref DataSet dataSet,string strConnect)
        {
            adapter = new SqlDataAdapter($"SELECT * FROM {table_name}", strConnect);
            dataSet = new DataSet();
            adapter.Fill(dataSet);
            
        }
        public void Remove_in_table(string str_table, ref SqlConnection sqlcon, ref SqlCommand command, string Name )
        {
          

            command = new SqlCommand($"DELETE FROM [{str_table}] WHERE Id{str_table}=@Id{str_table}", sqlcon);
            command.Parameters.AddWithValue($"Id{str_table}", Name);

            command.ExecuteNonQuery();
        }
    }
}
