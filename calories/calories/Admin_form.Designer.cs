
namespace calories
{
    partial class Admin_form
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
            this.listView_table = new System.Windows.Forms.ListView();
            this.button_Add = new System.Windows.Forms.Button();
            this.button_Edit = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Name_in_bd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Weight = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Fats = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cholesterol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Carbohydrates = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Kilocalories = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listView_table
            // 
            this.listView_table.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Name_in_bd,
            this.Weight,
            this.Fats,
            this.Cholesterol,
            this.Carbohydrates,
            this.Kilocalories});
            this.listView_table.GridLines = true;
            this.listView_table.HideSelection = false;
            this.listView_table.Location = new System.Drawing.Point(12, 68);
            this.listView_table.Name = "listView_table";
            this.listView_table.Size = new System.Drawing.Size(713, 186);
            this.listView_table.TabIndex = 0;
            this.listView_table.UseCompatibleStateImageBehavior = false;
            this.listView_table.View = System.Windows.Forms.View.Details;
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(12, 260);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(81, 40);
            this.button_Add.TabIndex = 1;
            this.button_Add.Text = "Добавить";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // button_Edit
            // 
            this.button_Edit.Location = new System.Drawing.Point(99, 260);
            this.button_Edit.Name = "button_Edit";
            this.button_Edit.Size = new System.Drawing.Size(98, 40);
            this.button_Edit.TabIndex = 2;
            this.button_Edit.Text = "Редактировать";
            this.button_Edit.UseVisualStyleBackColor = true;
            // 
            // button_Delete
            // 
            this.button_Delete.Location = new System.Drawing.Point(203, 260);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(75, 40);
            this.button_Delete.TabIndex = 3;
            this.button_Delete.Text = "Удалить";
            this.button_Delete.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 29);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(241, 21);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Name_in_bd
            // 
            this.Name_in_bd.Text = "Name";
            this.Name_in_bd.Width = 162;
            // 
            // Weight
            // 
            this.Weight.Text = "Weight";
            this.Weight.Width = 48;
            // 
            // Fats
            // 
            this.Fats.Text = "Fats";
            this.Fats.Width = 45;
            // 
            // Cholesterol
            // 
            this.Cholesterol.Text = "Cholesterol";
            this.Cholesterol.Width = 67;
            // 
            // Carbohydrates
            // 
            this.Carbohydrates.Text = "Carbohydrates";
            this.Carbohydrates.Width = 82;
            // 
            // Kilocalories
            // 
            this.Kilocalories.Text = "Kilocalories";
            this.Kilocalories.Width = 86;
            // 
            // Admin_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 303);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.button_Edit);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.listView_table);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Admin_form";
            this.Text = "Admin_form";
            this.Load += new System.EventHandler(this.Admin_form_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView_table;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.Button button_Edit;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ColumnHeader Name_in_bd;
        private System.Windows.Forms.ColumnHeader Weight;
        private System.Windows.Forms.ColumnHeader Fats;
        private System.Windows.Forms.ColumnHeader Cholesterol;
        private System.Windows.Forms.ColumnHeader Carbohydrates;
        private System.Windows.Forms.ColumnHeader Kilocalories;
    }
}