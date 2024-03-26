namespace WinFormsApp2
{
    partial class Form2
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
            movieName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            date = new TextBox();
            label3 = new Label();
            rating = new TextBox();
            label4 = new Label();
            comments = new TextBox();
            label5 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // movieName
            // 
            movieName.Location = new Point(56, 151);
            movieName.Name = "movieName";
            movieName.Size = new Size(100, 23);
            movieName.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Subheading", 15.7499981F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkRed;
            label1.Location = new Point(91, 51);
            label1.Name = "label1";
            label1.Size = new Size(236, 30);
            label1.TabIndex = 4;
            label1.Text = "Movies You've Watched";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 121);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 5;
            label2.Text = "Movie Name";
            // 
            // date
            // 
            date.Location = new Point(248, 151);
            date.Name = "date";
            date.Size = new Size(100, 23);
            date.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(248, 121);
            label3.Name = "label3";
            label3.Size = new Size(122, 15);
            label3.TabIndex = 7;
            label3.Text = "Date You've Watched ";
            // 
            // rating
            // 
            rating.Location = new Point(56, 248);
            rating.Name = "rating";
            rating.Size = new Size(100, 23);
            rating.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(56, 217);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.No;
            label4.Size = new Size(67, 15);
            label4.TabIndex = 9;
            label4.Text = "Rating 1-10";
            // 
            // comments
            // 
            comments.Location = new Point(248, 248);
            comments.Name = "comments";
            comments.Size = new Size(100, 23);
            comments.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(248, 217);
            label5.Name = "label5";
            label5.RightToLeft = RightToLeft.No;
            label5.Size = new Size(66, 15);
            label5.TabIndex = 11;
            label5.Text = "Comments";
            // 
            // button1
            // 
            button1.Location = new Point(162, 333);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 12;
            button1.Text = "Submit Review";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(162, 394);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 13;
            button2.Text = "See All Reviews";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(448, 471);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(comments);
            Controls.Add(label4);
            Controls.Add(rating);
            Controls.Add(label3);
            Controls.Add(date);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(movieName);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox movieName;
        private Label label1;
        private Label label2;
        private TextBox date;
        private Label label3;
        private TextBox rating;
        private Label label4;
        private TextBox comments;
        private Label label5;
        private Button button1;
        private Button button2;
    }
}