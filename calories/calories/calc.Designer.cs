
namespace calories
{
    partial class calc
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.score_jym = new System.Windows.Forms.Label();
            this.score_food = new System.Windows.Forms.Label();
            this.text_calories = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.User_input_button = new System.Windows.Forms.Button();
            this.Label_score_food = new System.Windows.Forms.Label();
            this.label_score_jym = new System.Windows.Forms.Label();
            this.text_calories_jym = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_name_from_table = new System.Windows.Forms.Label();
            this.label_weight_from_table = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_weight_user = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox_Visible_Textbox_calories = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label_save_calories = new System.Windows.Forms.Label();
            this.button_save_sum = new System.Windows.Forms.Button();
            this.button_Clear = new System.Windows.Forms.Button();
            this.textBox_Search = new System.Windows.Forms.TextBox();
            this.label_Search = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(49, 39);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(358, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // score_jym
            // 
            this.score_jym.AutoSize = true;
            this.score_jym.Location = new System.Drawing.Point(123, 289);
            this.score_jym.Name = "score_jym";
            this.score_jym.Size = new System.Drawing.Size(13, 13);
            this.score_jym.TabIndex = 2;
            this.score_jym.Text = "0";
            this.score_jym.UseMnemonic = false;
            // 
            // score_food
            // 
            this.score_food.AutoSize = true;
            this.score_food.Location = new System.Drawing.Point(425, 289);
            this.score_food.Name = "score_food";
            this.score_food.Size = new System.Drawing.Size(13, 13);
            this.score_food.TabIndex = 3;
            this.score_food.Text = "0";
            // 
            // text_calories
            // 
            this.text_calories.Location = new System.Drawing.Point(494, 360);
            this.text_calories.Name = "text_calories";
            this.text_calories.Size = new System.Drawing.Size(206, 20);
            this.text_calories.TabIndex = 4;
            this.text_calories.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_calories_KeyPress);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.Location = new System.Drawing.Point(12, 93);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(855, 150);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // User_input_button
            // 
            this.User_input_button.Location = new System.Drawing.Point(12, 469);
            this.User_input_button.Name = "User_input_button";
            this.User_input_button.Size = new System.Drawing.Size(142, 43);
            this.User_input_button.TabIndex = 6;
            this.User_input_button.Text = "Ввод произвольных данных";
            this.User_input_button.UseVisualStyleBackColor = true;
            this.User_input_button.Click += new System.EventHandler(this.User_input_button_Click);
            // 
            // Label_score_food
            // 
            this.Label_score_food.AutoSize = true;
            this.Label_score_food.Location = new System.Drawing.Point(221, 289);
            this.Label_score_food.Name = "Label_score_food";
            this.Label_score_food.Size = new System.Drawing.Size(186, 13);
            this.Label_score_food.TabIndex = 7;
            this.Label_score_food.Text = "Количество потребленных калорий";
            // 
            // label_score_jym
            // 
            this.label_score_jym.AutoSize = true;
            this.label_score_jym.Location = new System.Drawing.Point(12, 289);
            this.label_score_jym.Name = "label_score_jym";
            this.label_score_jym.Size = new System.Drawing.Size(105, 13);
            this.label_score_jym.TabIndex = 8;
            this.label_score_jym.Text = "Сожженно калорий";
            this.label_score_jym.UseMnemonic = false;
            // 
            // text_calories_jym
            // 
            this.text_calories_jym.Location = new System.Drawing.Point(494, 399);
            this.text_calories_jym.Name = "text_calories_jym";
            this.text_calories_jym.Size = new System.Drawing.Size(206, 20);
            this.text_calories_jym.TabIndex = 9;
            this.text_calories_jym.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_calories_jym_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(491, 383);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Введите количество соженных калорий";
            this.label1.UseMnemonic = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(491, 344);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Введите количество набранных калорий";
            this.label2.UseMnemonic = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(221, 343);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Название";
            // 
            // label_name_from_table
            // 
            this.label_name_from_table.AutoSize = true;
            this.label_name_from_table.Location = new System.Drawing.Point(284, 343);
            this.label_name_from_table.Name = "label_name_from_table";
            this.label_name_from_table.Size = new System.Drawing.Size(0, 13);
            this.label_name_from_table.TabIndex = 13;
            // 
            // label_weight_from_table
            // 
            this.label_weight_from_table.AutoSize = true;
            this.label_weight_from_table.Location = new System.Drawing.Point(271, 366);
            this.label_weight_from_table.Name = "label_weight_from_table";
            this.label_weight_from_table.Size = new System.Drawing.Size(0, 13);
            this.label_weight_from_table.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(221, 366);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Грамм:";
            // 
            // textBox_weight_user
            // 
            this.textBox_weight_user.Location = new System.Drawing.Point(494, 321);
            this.textBox_weight_user.Name = "textBox_weight_user";
            this.textBox_weight_user.Size = new System.Drawing.Size(206, 20);
            this.textBox_weight_user.TabIndex = 17;
            this.textBox_weight_user.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_weight_user_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(528, 305);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Введите количество грамм";
            this.label4.UseMnemonic = false;
            // 
            // checkBox_Visible_Textbox_calories
            // 
            this.checkBox_Visible_Textbox_calories.AutoSize = true;
            this.checkBox_Visible_Textbox_calories.Location = new System.Drawing.Point(706, 362);
            this.checkBox_Visible_Textbox_calories.Name = "checkBox_Visible_Textbox_calories";
            this.checkBox_Visible_Textbox_calories.Size = new System.Drawing.Size(194, 17);
            this.checkBox_Visible_Textbox_calories.TabIndex = 19;
            this.checkBox_Visible_Textbox_calories.TabStop = false;
            this.checkBox_Visible_Textbox_calories.Text = "Разблокировать набор калорий?";
            this.checkBox_Visible_Textbox_calories.UseVisualStyleBackColor = true;
            this.checkBox_Visible_Textbox_calories.CheckedChanged += new System.EventHandler(this.checkBox_Visible_Textbox_calories_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(224, 456);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Всего каллорий:";
            // 
            // label_save_calories
            // 
            this.label_save_calories.AutoSize = true;
            this.label_save_calories.Location = new System.Drawing.Point(321, 456);
            this.label_save_calories.Name = "label_save_calories";
            this.label_save_calories.Size = new System.Drawing.Size(13, 13);
            this.label_save_calories.TabIndex = 21;
            this.label_save_calories.Text = "0";
            // 
            // button_save_sum
            // 
            this.button_save_sum.Location = new System.Drawing.Point(757, 469);
            this.button_save_sum.Name = "button_save_sum";
            this.button_save_sum.Size = new System.Drawing.Size(143, 41);
            this.button_save_sum.TabIndex = 22;
            this.button_save_sum.Text = "Записать в дневник ТОЛЬКО общее число каллорий";
            this.button_save_sum.UseVisualStyleBackColor = true;
            this.button_save_sum.Click += new System.EventHandler(this.button_save_sum_Click);
            // 
            // button_Clear
            // 
            this.button_Clear.Location = new System.Drawing.Point(227, 470);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(88, 41);
            this.button_Clear.TabIndex = 23;
            this.button_Clear.Text = "Очистить все";
            this.button_Clear.UseVisualStyleBackColor = true;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // textBox_Search
            // 
            this.textBox_Search.Location = new System.Drawing.Point(562, 40);
            this.textBox_Search.Name = "textBox_Search";
            this.textBox_Search.Size = new System.Drawing.Size(305, 20);
            this.textBox_Search.TabIndex = 24;
            this.textBox_Search.TextChanged += new System.EventHandler(this.textBox_Search_TextChanged);
            // 
            // label_Search
            // 
            this.label_Search.AutoSize = true;
            this.label_Search.Location = new System.Drawing.Point(517, 42);
            this.label_Search.Name = "label_Search";
            this.label_Search.Size = new System.Drawing.Size(39, 13);
            this.label_Search.TabIndex = 25;
            this.label_Search.Text = "Поиск";
            // 
            // calc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 524);
            this.Controls.Add(this.label_Search);
            this.Controls.Add(this.textBox_Search);
            this.Controls.Add(this.button_Clear);
            this.Controls.Add(this.button_save_sum);
            this.Controls.Add(this.label_save_calories);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.checkBox_Visible_Textbox_calories);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_weight_user);
            this.Controls.Add(this.label_weight_from_table);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label_name_from_table);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text_calories_jym);
            this.Controls.Add(this.label_score_jym);
            this.Controls.Add(this.Label_score_food);
            this.Controls.Add(this.User_input_button);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.text_calories);
            this.Controls.Add(this.score_food);
            this.Controls.Add(this.score_jym);
            this.Controls.Add(this.comboBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "calc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "calc";
            this.Load += new System.EventHandler(this.calc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label score_jym;
        private System.Windows.Forms.Label score_food;
        private System.Windows.Forms.TextBox text_calories;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button User_input_button;
        private System.Windows.Forms.Label Label_score_food;
        private System.Windows.Forms.Label label_score_jym;
        private System.Windows.Forms.TextBox text_calories_jym;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_name_from_table;
        private System.Windows.Forms.Label label_weight_from_table;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_weight_user;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox_Visible_Textbox_calories;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label_save_calories;
        private System.Windows.Forms.Button button_save_sum;
        private System.Windows.Forms.Button button_Clear;
        private System.Windows.Forms.TextBox textBox_Search;
        private System.Windows.Forms.Label label_Search;
    }
}