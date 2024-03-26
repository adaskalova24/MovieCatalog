namespace WinFormsApp2
{
    partial class Reviews
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
            NotesList = new DataGridView();
            label2 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)NotesList).BeginInit();
            SuspendLayout();
            // 
            // NotesList
            // 
            NotesList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            NotesList.Location = new Point(5, 57);
            NotesList.Name = "NotesList";
            NotesList.RowTemplate.Height = 25;
            NotesList.Size = new Size(794, 317);
            NotesList.TabIndex = 26;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(361, 19);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 25;
            label2.Text = "All Reviews";
            // 
            // button1
            // 
            button1.Location = new Point(284, 415);
            button1.Name = "button1";
            button1.Size = new Size(207, 23);
            button1.TabIndex = 27;
            button1.Text = "Delete Review";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Reviews
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(NotesList);
            Controls.Add(label2);
            Name = "Reviews";
            Text = "Reviews";
            ((System.ComponentModel.ISupportInitialize)NotesList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView NotesList;
        private Label label2;
        private Button button1;
    }
}