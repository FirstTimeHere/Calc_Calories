
namespace calories
{
    partial class PasswordForm
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
            this.label_Login = new System.Windows.Forms.Label();
            this.label_password = new System.Windows.Forms.Label();
            this.textBox_Login = new System.Windows.Forms.TextBox();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.button_Accept = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_Login
            // 
            this.label_Login.AutoSize = true;
            this.label_Login.Location = new System.Drawing.Point(12, 60);
            this.label_Login.Name = "label_Login";
            this.label_Login.Size = new System.Drawing.Size(38, 13);
            this.label_Login.TabIndex = 0;
            this.label_Login.Text = "Логин";
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Location = new System.Drawing.Point(12, 120);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(45, 13);
            this.label_password.TabIndex = 1;
            this.label_password.Text = "Пароль";
            // 
            // textBox_Login
            // 
            this.textBox_Login.Location = new System.Drawing.Point(101, 60);
            this.textBox_Login.Name = "textBox_Login";
            this.textBox_Login.Size = new System.Drawing.Size(153, 20);
            this.textBox_Login.TabIndex = 2;
            // 
            // textBox_Password
            // 
            this.textBox_Password.Location = new System.Drawing.Point(101, 120);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.Size = new System.Drawing.Size(153, 20);
            this.textBox_Password.TabIndex = 3;
            this.textBox_Password.TextChanged += new System.EventHandler(this.textBox_Password_TextChanged);
            // 
            // button_Accept
            // 
            this.button_Accept.Location = new System.Drawing.Point(15, 201);
            this.button_Accept.Name = "button_Accept";
            this.button_Accept.Size = new System.Drawing.Size(75, 23);
            this.button_Accept.TabIndex = 4;
            this.button_Accept.Text = "Войти";
            this.button_Accept.UseVisualStyleBackColor = true;
            this.button_Accept.Click += new System.EventHandler(this.button_Accept_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_Cancel.Location = new System.Drawing.Point(179, 201);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(75, 23);
            this.button_Cancel.TabIndex = 5;
            this.button_Cancel.Text = "Отмена";
            this.button_Cancel.UseVisualStyleBackColor = true;
            // 
            // PasswordForm
            // 
            this.AcceptButton = this.button_Accept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button_Cancel;
            this.ClientSize = new System.Drawing.Size(266, 240);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_Accept);
            this.Controls.Add(this.textBox_Password);
            this.Controls.Add(this.textBox_Login);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.label_Login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "PasswordForm";
            this.Text = "Авторизация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Login;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.TextBox textBox_Login;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.Button button_Accept;
        private System.Windows.Forms.Button button_Cancel;
    }
}