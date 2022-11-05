
using System;

namespace Library_Managerment_System
{
    partial class BorrowBooks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BorrowBooks));
            this.txt_nameBook = new System.Windows.Forms.TextBox();
            this.txt_category = new System.Windows.Forms.TextBox();
            this.txt_author = new System.Windows.Forms.TextBox();
            this.kryptonContextMenu1 = new System.Windows.Forms.ContextMenu();
            this.txt_quantity = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.kryptonButton3 = new System.Windows.Forms.Button();
            this.btn_log = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.col_codeBook = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_nameBook = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_releaseDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_codeBook = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_nameBook
            // 
            this.txt_nameBook.BackColor = System.Drawing.Color.White;
            this.txt_nameBook.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_nameBook.Cursor = System.Windows.Forms.Cursors.No;
            this.txt_nameBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nameBook.Location = new System.Drawing.Point(235, 181);
            this.txt_nameBook.Name = "txt_nameBook";
            this.txt_nameBook.ReadOnly = true;
            this.txt_nameBook.Size = new System.Drawing.Size(546, 23);
            this.txt_nameBook.TabIndex = 5;
            // 
            // txt_category
            // 
            this.txt_category.BackColor = System.Drawing.Color.White;
            this.txt_category.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_category.Cursor = System.Windows.Forms.Cursors.No;
            this.txt_category.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_category.Location = new System.Drawing.Point(235, 292);
            this.txt_category.Name = "txt_category";
            this.txt_category.ReadOnly = true;
            this.txt_category.Size = new System.Drawing.Size(546, 23);
            this.txt_category.TabIndex = 5;
            // 
            // txt_author
            // 
            this.txt_author.BackColor = System.Drawing.Color.White;
            this.txt_author.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_author.Cursor = System.Windows.Forms.Cursors.No;
            this.txt_author.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_author.Location = new System.Drawing.Point(235, 235);
            this.txt_author.Name = "txt_author";
            this.txt_author.ReadOnly = true;
            this.txt_author.Size = new System.Drawing.Size(546, 23);
            this.txt_author.TabIndex = 5;
            // 
            // txt_quantity
            // 
            this.txt_quantity.BackColor = System.Drawing.Color.White;
            this.txt_quantity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_quantity.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txt_quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_quantity.Location = new System.Drawing.Point(240, 346);
            this.txt_quantity.Name = "txt_quantity";
            this.txt_quantity.Size = new System.Drawing.Size(69, 23);
            this.txt_quantity.TabIndex = 8;
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.LightBlue;
            this.btn_add.Location = new System.Drawing.Point(912, 110);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(146, 65);
            this.btn_add.TabIndex = 11;
            this.btn_add.Text = "Đặt sách";
            this.btn_add.UseVisualStyleBackColor = false;
            // 
            // kryptonButton3
            // 
            this.kryptonButton3.BackColor = System.Drawing.Color.Gray;
            this.kryptonButton3.Location = new System.Drawing.Point(1064, 110);
            this.kryptonButton3.Name = "kryptonButton3";
            this.kryptonButton3.Size = new System.Drawing.Size(145, 65);
            this.kryptonButton3.TabIndex = 13;
            this.kryptonButton3.Text = "Sách của bạn";
            this.kryptonButton3.UseVisualStyleBackColor = false;
            // 
            // btn_log
            // 
            this.btn_log.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_log.Location = new System.Drawing.Point(912, 181);
            this.btn_log.Name = "btn_log";
            this.btn_log.Size = new System.Drawing.Size(297, 61);
            this.btn_log.TabIndex = 14;
            this.btn_log.Text = "Đăng xuất";
            this.btn_log.UseVisualStyleBackColor = false;
            this.btn_log.Click += new System.EventHandler(this.btn_logout);
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_codeBook,
            this.col_nameBook,
            this.col_author,
            this.col_category,
            this.col_quantity,
            this.col_releaseDate});
            this.dgv.Location = new System.Drawing.Point(70, 432);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 62;
            this.dgv.RowTemplate.Height = 28;
            this.dgv.Size = new System.Drawing.Size(1139, 267);
            this.dgv.TabIndex = 15;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            // 
            // col_codeBook
            // 
            this.col_codeBook.DataPropertyName = "codeBook";
            this.col_codeBook.HeaderText = "Mã Sách";
            this.col_codeBook.MinimumWidth = 8;
            this.col_codeBook.Name = "col_codeBook";
            this.col_codeBook.ReadOnly = true;
            this.col_codeBook.Width = 110;
            // 
            // col_nameBook
            // 
            this.col_nameBook.DataPropertyName = "nameBook";
            this.col_nameBook.HeaderText = "Tên sách";
            this.col_nameBook.MinimumWidth = 8;
            this.col_nameBook.Name = "col_nameBook";
            this.col_nameBook.ReadOnly = true;
            this.col_nameBook.Width = 350;
            // 
            // col_author
            // 
            this.col_author.DataPropertyName = "author";
            this.col_author.HeaderText = "Tác giả";
            this.col_author.MinimumWidth = 8;
            this.col_author.Name = "col_author";
            this.col_author.ReadOnly = true;
            this.col_author.Width = 150;
            // 
            // col_category
            // 
            this.col_category.DataPropertyName = "category";
            this.col_category.HeaderText = "Loại sách";
            this.col_category.MinimumWidth = 8;
            this.col_category.Name = "col_category";
            this.col_category.ReadOnly = true;
            this.col_category.Width = 150;
            // 
            // col_quantity
            // 
            this.col_quantity.DataPropertyName = "quantity";
            this.col_quantity.HeaderText = "Số lượng";
            this.col_quantity.MinimumWidth = 8;
            this.col_quantity.Name = "col_quantity";
            this.col_quantity.ReadOnly = true;
            this.col_quantity.Width = 110;
            // 
            // col_releaseDate
            // 
            this.col_releaseDate.DataPropertyName = "createdAt";
            this.col_releaseDate.HeaderText = "Ngày ra mắt";
            this.col_releaseDate.MinimumWidth = 8;
            this.col_releaseDate.Name = "col_releaseDate";
            this.col_releaseDate.ReadOnly = true;
            this.col_releaseDate.Width = 150;
            // 
            // txt_codeBook
            // 
            this.txt_codeBook.BackColor = System.Drawing.Color.White;
            this.txt_codeBook.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_codeBook.Cursor = System.Windows.Forms.Cursors.No;
            this.txt_codeBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_codeBook.Location = new System.Drawing.Point(235, 124);
            this.txt_codeBook.Name = "txt_codeBook";
            this.txt_codeBook.ReadOnly = true;
            this.txt_codeBook.Size = new System.Drawing.Size(546, 23);
            this.txt_codeBook.TabIndex = 5;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.LavenderBlush;
            this.comboBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Tất cả",
            "Khoa học - Công nghệ",
            "Văn Học",
            "Kỹ năng sống",
            "Văn hóa - Xã hội",
            "Lịch Sử"});
            this.comboBox1.Location = new System.Drawing.Point(372, 385);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(271, 33);
            this.comboBox1.TabIndex = 17;
            // 
            // BorrowBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1280, 732);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txt_codeBook);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.btn_log);
            this.Controls.Add(this.kryptonButton3);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txt_quantity);
            this.Controls.Add(this.txt_author);
            this.Controls.Add(this.txt_category);
            this.Controls.Add(this.txt_nameBook);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BorrowBooks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BorrowBooks";
            this.Load += new System.EventHandler(this.BorrowBooks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void BorrowBooks_Load(object sender, EventArgs e)
        {
            
        }

        #endregion
        private System.Windows.Forms.TextBox txt_nameBook;
        private System.Windows.Forms.TextBox txt_category;
        private System.Windows.Forms.TextBox txt_author;
        private System.Windows.Forms.ContextMenu kryptonContextMenu1;
        private System.Windows.Forms.TextBox txt_quantity;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button kryptonButton3;
        private System.Windows.Forms.Button btn_log;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.TextBox txt_codeBook;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_codeBook;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_nameBook;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_author;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_category;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_releaseDate;
    }
}