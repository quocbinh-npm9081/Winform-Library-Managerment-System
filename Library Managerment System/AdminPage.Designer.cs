
namespace Library_Managerment_System
{
    partial class AdminPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPage));
            this.txt_codeBook = new System.Windows.Forms.TextBox();
            this.txt_nameBook = new System.Windows.Forms.TextBox();
            this.txt_author = new System.Windows.Forms.TextBox();
            this.txt_quantity = new System.Windows.Forms.TextBox();
            this.btn_add = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_delete = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.dgv_admin = new System.Windows.Forms.DataGridView();
            this.maSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tacGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaiSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kryptonButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonButton2 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_save = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.txt_category = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_admin)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_codeBook
            // 
            this.txt_codeBook.BackColor = System.Drawing.Color.LavenderBlush;
            this.txt_codeBook.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_codeBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_codeBook.Location = new System.Drawing.Point(258, 138);
            this.txt_codeBook.Name = "txt_codeBook";
            this.txt_codeBook.Size = new System.Drawing.Size(568, 32);
            this.txt_codeBook.TabIndex = 5;
            // 
            // txt_nameBook
            // 
            this.txt_nameBook.BackColor = System.Drawing.Color.LavenderBlush;
            this.txt_nameBook.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_nameBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nameBook.Location = new System.Drawing.Point(258, 186);
            this.txt_nameBook.Name = "txt_nameBook";
            this.txt_nameBook.Size = new System.Drawing.Size(568, 32);
            this.txt_nameBook.TabIndex = 6;
            // 
            // txt_author
            // 
            this.txt_author.BackColor = System.Drawing.Color.LavenderBlush;
            this.txt_author.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_author.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_author.Location = new System.Drawing.Point(258, 234);
            this.txt_author.Name = "txt_author";
            this.txt_author.Size = new System.Drawing.Size(568, 32);
            this.txt_author.TabIndex = 7;
            // 
            // txt_quantity
            // 
            this.txt_quantity.BackColor = System.Drawing.Color.LavenderBlush;
            this.txt_quantity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_quantity.Location = new System.Drawing.Point(258, 331);
            this.txt_quantity.Name = "txt_quantity";
            this.txt_quantity.Size = new System.Drawing.Size(45, 32);
            this.txt_quantity.TabIndex = 9;
            // 
            // btn_add
            // 
            this.btn_add.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Gallery;
            this.btn_add.Location = new System.Drawing.Point(869, 132);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(147, 47);
            this.btn_add.TabIndex = 10;
            this.btn_add.Values.Text = "Thêm";
            this.btn_add.Click += new System.EventHandler(this.event_click_add);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(1022, 185);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(147, 47);
            this.btn_delete.TabIndex = 11;
            this.btn_delete.Values.Text = "Xóa";
            this.btn_delete.Click += new System.EventHandler(this.event_click_delete);
            // 
            // dgv_admin
            // 
            this.dgv_admin.AllowUserToAddRows = false;
            this.dgv_admin.AllowUserToDeleteRows = false;
            this.dgv_admin.AllowUserToResizeRows = false;
            this.dgv_admin.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgv_admin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_admin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_admin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maSach,
            this.tenSach,
            this.tacGia,
            this.loaiSach,
            this.soLuong});
            this.dgv_admin.Location = new System.Drawing.Point(111, 405);
            this.dgv_admin.Name = "dgv_admin";
            this.dgv_admin.RowHeadersWidth = 62;
            this.dgv_admin.RowTemplate.Height = 28;
            this.dgv_admin.Size = new System.Drawing.Size(1062, 280);
            this.dgv_admin.TabIndex = 12;
            this.dgv_admin.SelectionChanged += new System.EventHandler(this.event_selectionChanged_click);
            // 
            // maSach
            // 
            this.maSach.DataPropertyName = "codeBook";
            this.maSach.HeaderText = "Mã sách";
            this.maSach.MinimumWidth = 8;
            this.maSach.Name = "maSach";
            this.maSach.ReadOnly = true;
            this.maSach.Width = 110;
            // 
            // tenSach
            // 
            this.tenSach.DataPropertyName = "nameBook";
            this.tenSach.HeaderText = "Tên sách";
            this.tenSach.MinimumWidth = 8;
            this.tenSach.Name = "tenSach";
            this.tenSach.ReadOnly = true;
            this.tenSach.Width = 460;
            // 
            // tacGia
            // 
            this.tacGia.DataPropertyName = "author";
            this.tacGia.HeaderText = "Tác giả";
            this.tacGia.MinimumWidth = 8;
            this.tacGia.Name = "tacGia";
            this.tacGia.ReadOnly = true;
            this.tacGia.Width = 150;
            // 
            // loaiSach
            // 
            this.loaiSach.DataPropertyName = "category";
            this.loaiSach.HeaderText = "Loại sách";
            this.loaiSach.MinimumWidth = 8;
            this.loaiSach.Name = "loaiSach";
            this.loaiSach.ReadOnly = true;
            this.loaiSach.Width = 150;
            // 
            // soLuong
            // 
            this.soLuong.DataPropertyName = "quantity";
            this.soLuong.HeaderText = "Số lượng";
            this.soLuong.MinimumWidth = 8;
            this.soLuong.Name = "soLuong";
            this.soLuong.ReadOnly = true;
            this.soLuong.Width = 110;
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.Location = new System.Drawing.Point(869, 185);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.Size = new System.Drawing.Size(147, 47);
            this.kryptonButton1.TabIndex = 13;
            this.kryptonButton1.Values.Text = "Sửa";
            this.kryptonButton1.Click += new System.EventHandler(this.event_edit_click);
            // 
            // kryptonButton2
            // 
            this.kryptonButton2.Location = new System.Drawing.Point(869, 238);
            this.kryptonButton2.Name = "kryptonButton2";
            this.kryptonButton2.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparklePurple;
            this.kryptonButton2.Size = new System.Drawing.Size(300, 72);
            this.kryptonButton2.TabIndex = 14;
            this.kryptonButton2.Values.Text = "Đăng xuất";
            this.kryptonButton2.Click += new System.EventHandler(this.event_logout_click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(1022, 132);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(148, 47);
            this.btn_save.TabIndex = 15;
            this.btn_save.Values.Text = "Lưu";
            this.btn_save.Click += new System.EventHandler(this.event_save_click);
            // 
            // txt_category
            // 
            this.txt_category.BackColor = System.Drawing.Color.LavenderBlush;
            this.txt_category.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txt_category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_category.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txt_category.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_category.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_category.FormattingEnabled = true;
            this.txt_category.Items.AddRange(new object[] {
            "Khoa học - Công nghệ",
            "Văn Học",
            "Kỹ năng sống",
            "Văn hóa - Xã hội",
            "Lịch Sử"});
            this.txt_category.Location = new System.Drawing.Point(258, 280);
            this.txt_category.Name = "txt_category";
            this.txt_category.Size = new System.Drawing.Size(568, 40);
            this.txt_category.TabIndex = 16;
            // 
            // AdminPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1280, 712);
            this.Controls.Add(this.txt_category);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.kryptonButton2);
            this.Controls.Add(this.kryptonButton1);
            this.Controls.Add(this.dgv_admin);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txt_quantity);
            this.Controls.Add(this.txt_author);
            this.Controls.Add(this.txt_nameBook);
            this.Controls.Add(this.txt_codeBook);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminPage";
            this.Load += new System.EventHandler(this.AdminPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_admin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_codeBook;
        private System.Windows.Forms.TextBox txt_nameBook;
        private System.Windows.Forms.TextBox txt_author;
        private System.Windows.Forms.TextBox txt_quantity;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_add;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_delete;
        private System.Windows.Forms.DataGridView dgv_admin;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_save;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn tacGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaiSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuong;
        private System.Windows.Forms.ComboBox txt_category;
    }
}