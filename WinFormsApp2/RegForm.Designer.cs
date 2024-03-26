namespace WinFormsApp2
{
    partial class RegForm
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
            label4 = new Label();
            listBox1 = new ListBox();
            DoB = new Label();
            birthdate = new DateTimePicker();
            password = new TextBox();
            label3 = new Label();
            button1 = new Button();
            label2 = new Label();
            username = new TextBox();
            label1 = new Label();
            rePassword = new Label();
            textBox1 = new TextBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Javanese Text", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(215, 303);
            label4.Name = "label4";
            label4.Size = new Size(62, 34);
            label4.TabIndex = 40;
            label4.Text = "Gender";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Items.AddRange(new object[] { "female", "male", "other" });
            listBox1.Location = new Point(215, 340);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(200, 19);
            listBox1.TabIndex = 39;
            // 
            // DoB
            // 
            DoB.AutoSize = true;
            DoB.Font = new Font("Javanese Text", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            DoB.Location = new Point(215, 240);
            DoB.Name = "DoB";
            DoB.Size = new Size(44, 34);
            DoB.TabIndex = 38;
            DoB.Text = "DoB";
            // 
            // birthdate
            // 
            birthdate.CalendarMonthBackground = Color.FromArgb(255, 255, 192);
            birthdate.Location = new Point(215, 277);
            birthdate.Name = "birthdate";
            birthdate.Size = new Size(200, 23);
            birthdate.TabIndex = 37;
            // 
            // password
            // 
            password.BackColor = SystemColors.Info;
            password.Location = new Point(489, 140);
            password.Name = "password";
            password.PlaceholderText = "password";
            password.Size = new Size(96, 23);
            password.TabIndex = 35;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Franklin Gothic Medium", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Indigo;
            label3.Location = new Point(355, 25);
            label3.Name = "label3";
            label3.Size = new Size(88, 26);
            label3.TabIndex = 33;
            label3.Text = "Register";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlText;
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(332, 390);
            button1.Name = "button1";
            button1.Size = new Size(147, 35);
            button1.TabIndex = 32;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Javanese Text", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(489, 92);
            label2.Name = "label2";
            label2.Size = new Size(75, 34);
            label2.TabIndex = 31;
            label2.Text = "Password";
            // 
            // username
            // 
            username.BackColor = SystemColors.Info;
            username.Location = new Point(215, 140);
            username.Name = "username";
            username.PlaceholderText = "username";
            username.Size = new Size(96, 23);
            username.TabIndex = 30;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Javanese Text", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(215, 92);
            label1.Name = "label1";
            label1.Size = new Size(79, 34);
            label1.TabIndex = 29;
            label1.Text = "Username";
            // 
            // rePassword
            // 
            rePassword.AutoSize = true;
            rePassword.Font = new Font("Javanese Text", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            rePassword.Location = new Point(332, 176);
            rePassword.Name = "rePassword";
            rePassword.Size = new Size(129, 34);
            rePassword.TabIndex = 43;
            rePassword.Text = "Re-type Password";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Info;
            textBox1.Location = new Point(347, 213);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "password";
            textBox1.Size = new Size(96, 23);
            textBox1.TabIndex = 44;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ControlText;
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(332, 458);
            button2.Name = "button2";
            button2.Size = new Size(147, 35);
            button2.TabIndex = 45;
            button2.Text = "Sign In Instead";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // RegForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 558);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(rePassword);
            Controls.Add(label4);
            Controls.Add(listBox1);
            Controls.Add(DoB);
            Controls.Add(birthdate);
            Controls.Add(password);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(username);
            Controls.Add(label1);
            Name = "RegForm";
            Text = "RegForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label4;
        private ListBox listBox1;
        private Label DoB;
        private DateTimePicker birthdate;
        private TextBox password;
        private Label label3;
        private Button button1;
        private Label label2;
        private TextBox username;
        private Label label1;
        private Label rePassword;
        private TextBox textBox1;
        private Button button2;
    }
}