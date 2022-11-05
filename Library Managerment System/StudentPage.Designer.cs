
namespace Library_Managerment_System
{
    partial class StudentPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentPage));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_borroBook = new System.Windows.Forms.Button();
            this.btn_myBooks = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(69, 85);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(218, 155);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 52);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bạn muốn ?";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_borroBook
            // 
            this.btn_borroBook.BackColor = System.Drawing.Color.LightBlue;
            this.btn_borroBook.Location = new System.Drawing.Point(824, 200);
            this.btn_borroBook.Name = "btn_borroBook";
            this.btn_borroBook.Size = new System.Drawing.Size(273, 75);
            this.btn_borroBook.TabIndex = 2;
            this.btn_borroBook.Text = "Mượn sách";
            this.btn_borroBook.UseVisualStyleBackColor = false;
            this.btn_borroBook.Click += new System.EventHandler(this.btn_click_borowBook);
            // 
            // btn_myBooks
            // 
            this.btn_myBooks.BackColor = System.Drawing.Color.Gray;
            this.btn_myBooks.Location = new System.Drawing.Point(824, 302);
            this.btn_myBooks.Name = "btn_myBooks";
            this.btn_myBooks.Size = new System.Drawing.Size(273, 73);
            this.btn_myBooks.TabIndex = 3;
            this.btn_myBooks.Text = "Sách của bạn";
            this.btn_myBooks.UseVisualStyleBackColor = false;
            this.btn_myBooks.Click += new System.EventHandler(this.btn_yourBooks_click);
            // 
            // StudentPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1302, 605);
            this.Controls.Add(this.btn_myBooks);
            this.Controls.Add(this.btn_borroBook);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StudentPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentPage";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_borroBook;
        private System.Windows.Forms.Button btn_myBooks;
    }
}