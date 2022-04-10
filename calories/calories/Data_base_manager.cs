using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calories
{
    // Этот класс нужен для будущей оптимизации, чтобы в нем проводились все операции по базе данных
   public class Data_base_manager
    {
      private  List<string> Names_tables_list=new List<string>(){"Молоко","Кисломолочные продукты","Творожные изделия","Молочные консервы","Кулинарные изделия",
            "Мороженое", "Сыры", "Масло, маргарин, майонез", "Яйца", "Мясо", "Мясные субродукты", "Готовые блюда из мяса птицы", "Мясные готовые блюда",
            "Готовые морепродукты", "Морепродукты", "Хлеб", "Мучные изделия", "Супы", "Готовые блюда", "Каши", "Орехи", "Овощи", "Грибы", "Фрукты",
            "Ягоды", "Варенье", "Кондитерские изделия", "Соки", "Безалкогольные напитки", "Алкогольные напитки"};
      
        private List<string> Names_tables_in_bd = new List<string>(){ "Milk","Dairy_products","Curd_products","Canned_milk","Culinary_products_from_dairy_products",
            "Ice_cream", "Cheese", "Butter_margarine_mayonnaise", "Eggs", "Meat", "Organ_meats", "Prepared_poultry_dishes", "Meat_ready_meals",
            "Ready_seafood", "Seafood", "Bread", "Flour_products", "Soups", "Ready_meals", "Porridges", "Nuts", "Vegetables", "Mushrooms", "Fruit",
            "Berries", "Jam", "Confectionery", "Juices", "Soft_drinks", "Alcoholic_drinks" };//доделать функционал программы, придумать как можно брать название таблиц из бд
        private string strConnect = ConfigurationManager.ConnectionStrings["TestDB"].ConnectionString; //путь к базе, подробнее в APP.config
       
        public  Data_base_manager(ref List<string> nametables,ref List<string> nametables_in_bd)
        {
            nametables = this.Names_tables_list;
            nametables_in_bd = this.Names_tables_in_bd;

        }
       
        public Data_base_manager(ref string connect)
        {
            connect = strConnect;
        }
        public Data_base_manager()
        {

        }
    }
}
