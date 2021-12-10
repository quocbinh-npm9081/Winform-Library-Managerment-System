
namespace Library_Managerment_System
{
    partial class FormStore
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStore));
            this.dgv = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameBook = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_back = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.txt_codeBook = new System.Windows.Forms.TextBox();
            this.txt_nameBook = new System.Windows.Forms.TextBox();
            this.txt_author = new System.Windows.Forms.TextBox();
            this.txt_quantity = new System.Windows.Forms.TextBox();
            this.txt_createdAt = new System.Windows.Forms.TextBox();
            this.txt_category = new System.Windows.Forms.TextBox();
            this.kryptonButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.BackgroundColor = System.Drawing.Color.Snow;
            this.dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.nameBook,
            this.author,
            this.category,
            this.quantity,
            this.Column3});
            this.dgv.Location = new System.Drawing.Point(81, 366);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 62;
            this.dgv.RowTemplate.Height = 28;
            this.dgv.Size = new System.Drawing.Size(1095, 248);
            this.dgv.TabIndex = 0;
            this.dgv.SelectionChanged += new System.EventHandler(this.event_selected_change);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "codeBook";
            this.Column1.HeaderText = "Mã sách";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 110;
            // 
            // nameBook
            // 
            this.nameBook.DataPropertyName = "nameBook";
            this.nameBook.HeaderText = "Tên sách";
            this.nameBook.MinimumWidth = 8;
            this.nameBook.Name = "nameBook";
            this.nameBook.ReadOnly = true;
            this.nameBook.Width = 250;
            // 
            // author
            // 
            this.author.DataPropertyName = "author";
            this.author.HeaderText = "Tác giả";
            this.author.MinimumWidth = 8;
            this.author.Name = "author";
            this.author.ReadOnly = true;
            this.author.Width = 150;
            // 
            // category
            // 
            this.category.DataPropertyName = "category";
            this.category.HeaderText = "Loại sách";
            this.category.MinimumWidth = 8;
            this.category.Name = "category";
            this.category.ReadOnly = true;
            this.category.Width = 150;
            // 
            // quantity
            // 
            this.quantity.DataPropertyName = "quantity";
            this.quantity.HeaderText = "Số lượng";
            this.quantity.MinimumWidth = 8;
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            this.quantity.Width = 90;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "createdAt";
            this.Column3.HeaderText = "Ngày mượn";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 150;
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(1026, 133);
            this.btn_back.Name = "btn_back";
            this.btn_back.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.btn_back.Size = new System.Drawing.Size(150, 50);
            this.btn_back.TabIndex = 1;
            this.btn_back.Values.Text = "Trở lại";
            this.btn_back.Click += new System.EventHandler(this.btn_back_click);
            // 
            // txt_codeBook
            // 
            this.txt_codeBook.BackColor = System.Drawing.Color.White;
            this.txt_codeBook.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_codeBook.Cursor = System.Windows.Forms.Cursors.No;
            this.txt_codeBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_codeBook.Location = new System.Drawing.Point(211, 144);
            this.txt_codeBook.Name = "txt_codeBook";
            this.txt_codeBook.ReadOnly = true;
            this.txt_codeBook.Size = new System.Drawing.Size(547, 23);
            this.txt_codeBook.TabIndex = 2;
            this.txt_codeBook.TextChanged += new System.EventHandler(this.txt_codeBook_TextChanged);
            // 
            // txt_nameBook
            // 
            this.txt_nameBook.BackColor = System.Drawing.Color.White;
            this.txt_nameBook.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_nameBook.Cursor = System.Windows.Forms.Cursors.No;
            this.txt_nameBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nameBook.Location = new System.Drawing.Point(215, 188);
            this.txt_nameBook.Name = "txt_nameBook";
            this.txt_nameBook.ReadOnly = true;
            this.txt_nameBook.Size = new System.Drawing.Size(547, 23);
            this.txt_nameBook.TabIndex = 3;
            // 
            // txt_author
            // 
            this.txt_author.BackColor = System.Drawing.Color.White;
            this.txt_author.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_author.Cursor = System.Windows.Forms.Cursors.No;
            this.txt_author.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_author.Location = new System.Drawing.Point(211, 232);
            this.txt_author.Name = "txt_author";
            this.txt_author.ReadOnly = true;
            this.txt_author.Size = new System.Drawing.Size(547, 23);
            this.txt_author.TabIndex = 4;
            // 
            // txt_quantity
            // 
            this.txt_quantity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_quantity.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txt_quantity.Location = new System.Drawing.Point(219, 325);
            this.txt_quantity.Name = "txt_quantity";
            this.txt_quantity.Size = new System.Drawing.Size(28, 19);
            this.txt_quantity.TabIndex = 6;
            // 
            // txt_createdAt
            // 
            this.txt_createdAt.BackColor = System.Drawing.Color.White;
            this.txt_createdAt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_createdAt.Cursor = System.Windows.Forms.Cursors.No;
            this.txt_createdAt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_createdAt.Location = new System.Drawing.Point(471, 324);
            this.txt_createdAt.Name = "txt_createdAt";
            this.txt_createdAt.ReadOnly = true;
            this.txt_createdAt.Size = new System.Drawing.Size(286, 21);
            this.txt_createdAt.TabIndex = 7;
            // 
            // txt_category
            // 
            this.txt_category.BackColor = System.Drawing.Color.White;
            this.txt_category.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_category.Cursor = System.Windows.Forms.Cursors.No;
            this.txt_category.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_category.Location = new System.Drawing.Point(211, 278);
            this.txt_category.Name = "txt_category";
            this.txt_category.ReadOnly = true;
            this.txt_category.Size = new System.Drawing.Size(546, 23);
            this.txt_category.TabIndex = 8;
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.Location = new System.Drawing.Point(853, 133);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Silver;
            this.kryptonButton1.Size = new System.Drawing.Size(155, 50);
            this.kryptonButton1.TabIndex = 9;
            this.kryptonButton1.Values.Text = "Trả sách";
            this.kryptonButton1.Click += new System.EventHandler(this.btn_returnBook_click);
            // 
            // FormStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1258, 656);
            this.Controls.Add(this.kryptonButton1);
            this.Controls.Add(this.txt_category);
            this.Controls.Add(this.txt_createdAt);
            this.Controls.Add(this.txt_quantity);
            this.Controls.Add(this.txt_author);
            this.Controls.Add(this.txt_nameBook);
            this.Controls.Add(this.txt_codeBook);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.dgv);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormStore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormStore";
            this.Load += new System.EventHandler(this.FormStore_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_back;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameBook;
        private System.Windows.Forms.DataGridViewTextBoxColumn author;
        private System.Windows.Forms.DataGridViewTextBoxColumn category;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.TextBox txt_codeBook;
        private System.Windows.Forms.TextBox txt_nameBook;
        private System.Windows.Forms.TextBox txt_author;
        private System.Windows.Forms.TextBox txt_quantity;
        private System.Windows.Forms.TextBox txt_createdAt;
        private System.Windows.Forms.TextBox txt_category;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton1;
    }
}