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

namespace calories
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
           // CheckConnection();
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            calc calc = new calc();
            calc.Show();
            
        }
    }
}
