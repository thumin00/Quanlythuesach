namespace Quanlythuesach
{
    partial class Formloaisach
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtmaloaisach = new System.Windows.Forms.TextBox();
            this.txttenloaisach = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView_Formloaisach = new System.Windows.Forms.DataGridView();
            this.maloaisach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenloaisach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Formloaisach)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Loại Sách";
            // 
            // txtmaloaisach
            // 
            this.txtmaloaisach.Location = new System.Drawing.Point(169, 13);
            this.txtmaloaisach.Name = "txtmaloaisach";
            this.txtmaloaisach.Size = new System.Drawing.Size(100, 20);
            this.txtmaloaisach.TabIndex = 1;
            // 
            // txttenloaisach
            // 
            this.txttenloaisach.Location = new System.Drawing.Point(464, 13);
            this.txttenloaisach.Name = "txttenloaisach";
            this.txttenloaisach.Size = new System.Drawing.Size(100, 20);
            this.txttenloaisach.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(361, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên Loại Sách";
            // 
            // dataGridView_Formloaisach
            // 
            this.dataGridView_Formloaisach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Formloaisach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maloaisach,
            this.tenloaisach});
            this.dataGridView_Formloaisach.Location = new System.Drawing.Point(69, 51);
            this.dataGridView_Formloaisach.Name = "dataGridView_Formloaisach";
            this.dataGridView_Formloaisach.Size = new System.Drawing.Size(420, 150);
            this.dataGridView_Formloaisach.TabIndex = 4;
            // 
            // maloaisach
            // 
            this.maloaisach.DataPropertyName = "maloaisach";
            this.maloaisach.HeaderText = "Mã Loại Sách";
            this.maloaisach.Name = "maloaisach";
            // 
            // tenloaisach
            // 
            this.tenloaisach.DataPropertyName = "tenloaisach";
            this.tenloaisach.HeaderText = "Tên Loại Sách";
            this.tenloaisach.Name = "tenloaisach";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(69, 224);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(211, 224);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 6;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(350, 224);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 7;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(489, 224);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 8;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // Formloaisach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 303);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dataGridView_Formloaisach);
            this.Controls.Add(this.txttenloaisach);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtmaloaisach);
            this.Controls.Add(this.label1);
            this.Name = "Formloaisach";
            this.Text = "Formloaisach";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Formloaisach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtmaloaisach;
        private System.Windows.Forms.TextBox txttenloaisach;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView_Formloaisach;
        private System.Windows.Forms.DataGridViewTextBoxColumn maloaisach;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenloaisach;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
    }
}