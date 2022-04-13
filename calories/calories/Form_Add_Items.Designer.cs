
namespace calories
{
    partial class Form_Add_Items
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.textBox_Weight = new System.Windows.Forms.TextBox();
            this.textBox_Fats = new System.Windows.Forms.TextBox();
            this.textBox_Cholesterol = new System.Windows.Forms.TextBox();
            this.textBox_Carbohydrates = new System.Windows.Forms.TextBox();
            this.textBox_Kilocalories = new System.Windows.Forms.TextBox();
            this.label_Name = new System.Windows.Forms.Label();
            this.label_Weight = new System.Windows.Forms.Label();
            this.label_Fats = new System.Windows.Forms.Label();
            this.label_Cholesterol = new System.Windows.Forms.Label();
            this.label_Carbohydrates = new System.Windows.Forms.Label();
            this.label_Kilocalories = new System.Windows.Forms.Label();
            this.button_Add = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.comboBox_table_name = new System.Windows.Forms.ComboBox();
            this.label_Table = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(12, 63);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(192, 20);
            this.textBox_Name.TabIndex = 0;
            // 
            // textBox_Weight
            // 
            this.textBox_Weight.Location = new System.Drawing.Point(12, 103);
            this.textBox_Weight.Name = "textBox_Weight";
            this.textBox_Weight.Size = new System.Drawing.Size(192, 20);
            this.textBox_Weight.TabIndex = 1;
            // 
            // textBox_Fats
            // 
            this.textBox_Fats.Location = new System.Drawing.Point(12, 142);
            this.textBox_Fats.Name = "textBox_Fats";
            this.textBox_Fats.Size = new System.Drawing.Size(192, 20);
            this.textBox_Fats.TabIndex = 2;
            // 
            // textBox_Cholesterol
            // 
            this.textBox_Cholesterol.Location = new System.Drawing.Point(12, 185);
            this.textBox_Cholesterol.Name = "textBox_Cholesterol";
            this.textBox_Cholesterol.Size = new System.Drawing.Size(192, 20);
            this.textBox_Cholesterol.TabIndex = 3;
            // 
            // textBox_Carbohydrates
            // 
            this.textBox_Carbohydrates.Location = new System.Drawing.Point(12, 225);
            this.textBox_Carbohydrates.Name = "textBox_Carbohydrates";
            this.textBox_Carbohydrates.Size = new System.Drawing.Size(192, 20);
            this.textBox_Carbohydrates.TabIndex = 4;
            // 
            // textBox_Kilocalories
            // 
            this.textBox_Kilocalories.Location = new System.Drawing.Point(12, 264);
            this.textBox_Kilocalories.Name = "textBox_Kilocalories";
            this.textBox_Kilocalories.Size = new System.Drawing.Size(192, 20);
            this.textBox_Kilocalories.TabIndex = 5;
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Location = new System.Drawing.Point(69, 47);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(83, 13);
            this.label_Name.TabIndex = 6;
            this.label_Name.Text = "Наименование";
            // 
            // label_Weight
            // 
            this.label_Weight.AutoSize = true;
            this.label_Weight.Location = new System.Drawing.Point(59, 86);
            this.label_Weight.Name = "label_Weight";
            this.label_Weight.Size = new System.Drawing.Size(102, 13);
            this.label_Weight.TabIndex = 7;
            this.label_Weight.Text = "Количество грамм";
            // 
            // label_Fats
            // 
            this.label_Fats.AutoSize = true;
            this.label_Fats.Location = new System.Drawing.Point(60, 126);
            this.label_Fats.Name = "label_Fats";
            this.label_Fats.Size = new System.Drawing.Size(101, 13);
            this.label_Fats.TabIndex = 8;
            this.label_Fats.Text = "Количество жиров";
            // 
            // label_Cholesterol
            // 
            this.label_Cholesterol.AutoSize = true;
            this.label_Cholesterol.Location = new System.Drawing.Point(49, 169);
            this.label_Cholesterol.Name = "label_Cholesterol";
            this.label_Cholesterol.Size = new System.Drawing.Size(133, 13);
            this.label_Cholesterol.TabIndex = 9;
            this.label_Cholesterol.Text = "Количество холестерина";
            // 
            // label_Carbohydrates
            // 
            this.label_Carbohydrates.AutoSize = true;
            this.label_Carbohydrates.Location = new System.Drawing.Point(49, 208);
            this.label_Carbohydrates.Name = "label_Carbohydrates";
            this.label_Carbohydrates.Size = new System.Drawing.Size(121, 13);
            this.label_Carbohydrates.TabIndex = 10;
            this.label_Carbohydrates.Text = "Количество углеводов";
            // 
            // label_Kilocalories
            // 
            this.label_Kilocalories.AutoSize = true;
            this.label_Kilocalories.Location = new System.Drawing.Point(59, 248);
            this.label_Kilocalories.Name = "label_Kilocalories";
            this.label_Kilocalories.Size = new System.Drawing.Size(111, 13);
            this.label_Kilocalories.TabIndex = 11;
            this.label_Kilocalories.Text = "Количество калорий";
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(12, 294);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(69, 23);
            this.button_Add.TabIndex = 12;
            this.button_Add.Text = "Добавить";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_Cancel.Location = new System.Drawing.Point(129, 294);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(75, 23);
            this.button_Cancel.TabIndex = 13;
            this.button_Cancel.Text = "Отмена";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // comboBox_table_name
            // 
            this.comboBox_table_name.FormattingEnabled = true;
            this.comboBox_table_name.Location = new System.Drawing.Point(12, 23);
            this.comboBox_table_name.Name = "comboBox_table_name";
            this.comboBox_table_name.Size = new System.Drawing.Size(190, 21);
            this.comboBox_table_name.TabIndex = 14;
            this.comboBox_table_name.SelectedIndexChanged += new System.EventHandler(this.comboBox_table_name_SelectedIndexChanged);
            // 
            // label_Table
            // 
            this.label_Table.AutoSize = true;
            this.label_Table.Location = new System.Drawing.Point(84, 7);
            this.label_Table.Name = "label_Table";
            this.label_Table.Size = new System.Drawing.Size(50, 13);
            this.label_Table.TabIndex = 15;
            this.label_Table.Text = "Таблица";
            // 
            // Form_Add_Items
            // 
            this.AcceptButton = this.button_Add;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button_Cancel;
            this.ClientSize = new System.Drawing.Size(214, 324);
            this.Controls.Add(this.label_Table);
            this.Controls.Add(this.comboBox_table_name);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.label_Kilocalories);
            this.Controls.Add(this.label_Carbohydrates);
            this.Controls.Add(this.label_Cholesterol);
            this.Controls.Add(this.label_Fats);
            this.Controls.Add(this.label_Weight);
            this.Controls.Add(this.label_Name);
            this.Controls.Add(this.textBox_Kilocalories);
            this.Controls.Add(this.textBox_Carbohydrates);
            this.Controls.Add(this.textBox_Cholesterol);
            this.Controls.Add(this.textBox_Fats);
            this.Controls.Add(this.textBox_Weight);
            this.Controls.Add(this.textBox_Name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form_Add_Items";
            this.Text = "Добавление в таблицу";
            this.Load += new System.EventHandler(this.Form_Add_Items_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.TextBox textBox_Weight;
        private System.Windows.Forms.TextBox textBox_Fats;
        private System.Windows.Forms.TextBox textBox_Cholesterol;
        private System.Windows.Forms.TextBox textBox_Carbohydrates;
        private System.Windows.Forms.TextBox textBox_Kilocalories;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.Label label_Weight;
        private System.Windows.Forms.Label label_Fats;
        private System.Windows.Forms.Label label_Cholesterol;
        private System.Windows.Forms.Label label_Carbohydrates;
        private System.Windows.Forms.Label label_Kilocalories;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.ComboBox comboBox_table_name;
        private System.Windows.Forms.Label label_Table;
    }
}