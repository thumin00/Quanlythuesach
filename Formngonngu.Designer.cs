namespace Quanlythuesach
{
    partial class Formngonngu
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
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtmangonngu = new System.Windows.Forms.TextBox();
            this.txttenngonngu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView_Formngonngu = new System.Windows.Forms.DataGridView();
            this.mangonngu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenngonngu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Formngonngu)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(479, 220);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 17;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(345, 222);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 16;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(206, 222);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 15;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(64, 222);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 14;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Mã Ngôn Ngữ";
            // 
            // txtmangonngu
            // 
            this.txtmangonngu.Location = new System.Drawing.Point(164, 15);
            this.txtmangonngu.Name = "txtmangonngu";
            this.txtmangonngu.Size = new System.Drawing.Size(100, 20);
            this.txtmangonngu.TabIndex = 19;
            // 
            // txttenngonngu
            // 
            this.txttenngonngu.Location = new System.Drawing.Point(459, 15);
            this.txttenngonngu.Name = "txttenngonngu";
            this.txttenngonngu.Size = new System.Drawing.Size(100, 20);
            this.txttenngonngu.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(356, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Tên Ngôn Ngữ";
            // 
            // dataGridView_Formngonngu
            // 
            this.dataGridView_Formngonngu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Formngonngu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mangonngu,
            this.tenngonngu});
            this.dataGridView_Formngonngu.Location = new System.Drawing.Point(64, 54);
            this.dataGridView_Formngonngu.Name = "dataGridView_Formngonngu";
            this.dataGridView_Formngonngu.Size = new System.Drawing.Size(403, 150);
            this.dataGridView_Formngonngu.TabIndex = 22;
            // 
            // mangonngu
            // 
            this.mangonngu.DataPropertyName = "mangonngu";
            this.mangonngu.HeaderText = "Mã Ngôn Ngữ";
            this.mangonngu.Name = "mangonngu";
            // 
            // tenngonngu
            // 
            this.tenngonngu.DataPropertyName = "tenngonngu";
            this.tenngonngu.HeaderText = "Tên Ngôn Ngữ";
            this.tenngonngu.Name = "tenngonngu";
            // 
            // Formngonngu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView_Formngonngu);
            this.Controls.Add(this.txttenngonngu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtmangonngu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Name = "Formngonngu";
            this.Text = "Formngonngu";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Formngonngu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtmangonngu;
        private System.Windows.Forms.TextBox txttenngonngu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView_Formngonngu;
        private System.Windows.Forms.DataGridViewTextBoxColumn mangonngu;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenngonngu;
    }
}