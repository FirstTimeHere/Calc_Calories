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
   
    public partial class User_input_form : Form
    {
       
        public User_input_form()
        {
            InitializeComponent();
        }

       

        private void buttonSave_Click(object sender, EventArgs e)
        {
            //Save_new_lines.SaveName = this.textBox_name.Text;
              calc calc = this.Owner as calc;

              if (calc !=null)
              {
                  calc.SaveName = textBox_name.Text;
                calc.SaveWeight = textBox_weight.Text;
                double weighnt_convet_text = Convert.ToDouble(textBox_weight.Text);
                double kkal_convert_text = Convert.ToDouble(textBox_kkal.Text);
                double answer= (kkal_convert_text * weighnt_convet_text) / 100;
                calc.SaveKkal += answer ;
                calc.Savekkalfromlabel = answer.ToString();
                
              }
            Close();
            
        }
    }
}
