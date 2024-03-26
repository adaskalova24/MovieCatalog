namespace WinFormsApp2
{
    partial class LogInForm
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
            password = new TextBox();
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
            username = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // password
            // 
            password.Location = new Point(123, 330);
            password.Name = "password";
            password.PasswordChar = '*';
            password.PlaceholderText = "password";
            password.Size = new Size(122, 23);
            password.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Javanese Text", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(123, 128);
            label1.Name = "label1";
            label1.Size = new Size(79, 34);
            label1.TabIndex = 4;
            label1.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Javanese Text", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(123, 279);
            label3.Name = "label3";
            label3.Size = new Size(75, 34);
            label3.TabIndex = 6;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Javanese Text", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(318, 47);
            label2.Name = "label2";
            label2.Size = new Size(102, 36);
            label2.TabIndex = 7;
            label2.Text = "Sign In Page";
            // 
            // username
            // 
            username.Location = new Point(123, 185);
            username.Name = "username";
            username.PlaceholderText = "username";
            username.Size = new Size(100, 23);
            username.TabIndex = 8;
            // 
            // button1
            // 
            button1.Location = new Point(511, 218);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 9;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // LogInForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Indigo;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(username);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(password);
            Name = "LogInForm";
            Text = "LogInForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox password;
        private Label label1;
        private Label label3;
        private Label label2;
        private TextBox username;
        private Button button1;
    }
}