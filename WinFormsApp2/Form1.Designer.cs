namespace WinFormsApp2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            movieType = new ComboBox();
            movieGenre = new ComboBox();
            movieSP = new ComboBox();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // movieType
            // 
            movieType.FormattingEnabled = true;
            movieType.Items.AddRange(new object[] { "Movies", "TV Series", "Documentaries" });
            movieType.Location = new Point(49, 91);
            movieType.Name = "movieType";
            movieType.Size = new Size(121, 23);
            movieType.TabIndex = 0;
            movieType.Text = "Type";
            movieType.Click += button1_Click;
            // 
            // movieGenre
            // 
            movieGenre.FormattingEnabled = true;
            movieGenre.Items.AddRange(new object[] { "Comedy", "Drama", "Thriller" });
            movieGenre.Location = new Point(207, 91);
            movieGenre.Name = "movieGenre";
            movieGenre.Size = new Size(121, 23);
            movieGenre.TabIndex = 1;
            movieGenre.Text = "Genre";
            movieGenre.Click += button1_Click;
            // 
            // movieSP
            // 
            movieSP.FormattingEnabled = true;
            movieSP.Items.AddRange(new object[] { "Netflix", "Hulu", "Disney+" });
            movieSP.Location = new Point(356, 91);
            movieSP.Name = "movieSP";
            movieSP.Size = new Size(121, 23);
            movieSP.TabIndex = 2;
            movieSP.Text = "Streaming Platform";
            movieSP.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Subheading", 15.7499981F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkRed;
            label1.Location = new Point(189, 40);
            label1.Name = "label1";
            label1.Size = new Size(150, 30);
            label1.TabIndex = 3;
            label1.Text = "Movie Catalog";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(103, 129);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(320, 196);
            dataGridView1.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(227, 370);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 5;
            button1.Text = "Clear";
            button1.UseVisualStyleBackColor = true;
            button1.Click += clear_Click;
            // 
            // button2
            // 
            button2.Location = new Point(227, 413);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 6;
            button2.Text = "Next";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(678, 463);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(movieSP);
            Controls.Add(movieGenre);
            Controls.Add(movieType);
            Name = "Form1";
            Text = "Form";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox movieType;
        private ComboBox movieGenre;
        private ComboBox movieSP;
        private Label label1;
        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
    }
}