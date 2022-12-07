
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
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_back = new System.Windows.Forms.Button();
            this.txt_billID = new System.Windows.Forms.TextBox();
            this.txt_codeBook = new System.Windows.Forms.TextBox();
            this.txt_quantity = new System.Windows.Forms.TextBox();
            this.txt_createdAt = new System.Windows.Forms.TextBox();
            this.txt_category = new System.Windows.Forms.TextBox();
            this.kryptonButton1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.Column2,
            this.Column1,
            this.CategoryID,
            this.quantity,
            this.Column3});
            this.dgv.Location = new System.Drawing.Point(81, 366);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 62;
            this.dgv.RowTemplate.Height = 28;
            this.dgv.Size = new System.Drawing.Size(1095, 248);
            this.dgv.TabIndex = 0;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "BillID";
            this.Column2.HeaderText = "Mã mượn sách";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "BookID";
            this.Column1.HeaderText = "Mã sách";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 110;
            // 
            // CategoryID
            // 
            this.CategoryID.DataPropertyName = "CategoryID";
            this.CategoryID.HeaderText = "Loại sách";
            this.CategoryID.MinimumWidth = 8;
            this.CategoryID.Name = "CategoryID";
            this.CategoryID.ReadOnly = true;
            this.CategoryID.Width = 150;
            // 
            // quantity
            // 
            this.quantity.DataPropertyName = "Amount";
            this.quantity.HeaderText = "Số lượng";
            this.quantity.MinimumWidth = 8;
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            this.quantity.Width = 90;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "BorrowDate";
            this.Column3.HeaderText = "Ngày mượn";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 150;
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.LightBlue;
            this.btn_back.Location = new System.Drawing.Point(1026, 133);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(150, 50);
            this.btn_back.TabIndex = 1;
            this.btn_back.Text = "Trở lại";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_click);
            // 
            // txt_billID
            // 
            this.txt_billID.BackColor = System.Drawing.Color.White;
            this.txt_billID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_billID.Cursor = System.Windows.Forms.Cursors.No;
            this.txt_billID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_billID.Location = new System.Drawing.Point(211, 144);
            this.txt_billID.Name = "txt_billID";
            this.txt_billID.ReadOnly = true;
            this.txt_billID.Size = new System.Drawing.Size(547, 23);
            this.txt_billID.TabIndex = 2;
            // 
            // txt_codeBook
            // 
            this.txt_codeBook.BackColor = System.Drawing.Color.White;
            this.txt_codeBook.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_codeBook.Cursor = System.Windows.Forms.Cursors.No;
            this.txt_codeBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_codeBook.Location = new System.Drawing.Point(215, 188);
            this.txt_codeBook.Name = "txt_codeBook";
            this.txt_codeBook.ReadOnly = true;
            this.txt_codeBook.Size = new System.Drawing.Size(547, 23);
            this.txt_codeBook.TabIndex = 3;
            // 
            // txt_quantity
            // 
            this.txt_quantity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_quantity.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txt_quantity.Location = new System.Drawing.Point(219, 325);
            this.txt_quantity.Name = "txt_quantity";
            this.txt_quantity.ReadOnly = true;
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
            this.kryptonButton1.BackColor = System.Drawing.Color.LightBlue;
            this.kryptonButton1.Location = new System.Drawing.Point(853, 133);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.Size = new System.Drawing.Size(155, 50);
            this.kryptonButton1.TabIndex = 9;
            this.kryptonButton1.Text = "Trả sách";
            this.kryptonButton1.UseVisualStyleBackColor = false;
            this.kryptonButton1.Click += new System.EventHandler(this.btn_returnBook_click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Library_Managerment_System.Properties.Resources._56268731;
            this.panel1.Location = new System.Drawing.Point(61, 226);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(711, 46);
            this.panel1.TabIndex = 10;
            // 
            // FormStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1258, 656);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.kryptonButton1);
            this.Controls.Add(this.txt_category);
            this.Controls.Add(this.txt_createdAt);
            this.Controls.Add(this.txt_quantity);
            this.Controls.Add(this.txt_codeBook);
            this.Controls.Add(this.txt_billID);
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
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.TextBox txt_billID;
        private System.Windows.Forms.TextBox txt_codeBook;
        private System.Windows.Forms.TextBox txt_quantity;
        private System.Windows.Forms.TextBox txt_createdAt;
        private System.Windows.Forms.TextBox txt_category;
        private System.Windows.Forms.Button kryptonButton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryID;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Panel panel1;
    }
}