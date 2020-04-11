namespace Quanlythuesach
{
    partial class Formtinhtrang
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
            this.dataGridView_Formtinhtrang = new System.Windows.Forms.DataGridView();
            this.matinhtrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tentinhtrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txttentinhtrang = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtmatinhtrang = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Formtinhtrang)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(490, 222);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 17;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(351, 222);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 16;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(212, 222);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 15;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(70, 222);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 14;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dataGridView_Formtinhtrang
            // 
            this.dataGridView_Formtinhtrang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Formtinhtrang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.matinhtrang,
            this.tentinhtrang});
            this.dataGridView_Formtinhtrang.Location = new System.Drawing.Point(70, 49);
            this.dataGridView_Formtinhtrang.Name = "dataGridView_Formtinhtrang";
            this.dataGridView_Formtinhtrang.Size = new System.Drawing.Size(373, 150);
            this.dataGridView_Formtinhtrang.TabIndex = 13;
            // 
            // matinhtrang
            // 
            this.matinhtrang.DataPropertyName = "matinhtrang";
            this.matinhtrang.HeaderText = "Mã Tình Trạng";
            this.matinhtrang.Name = "matinhtrang";
            // 
            // tentinhtrang
            // 
            this.tentinhtrang.DataPropertyName = "tentinhtrang";
            this.tentinhtrang.HeaderText = "Tên Tình Trạng";
            this.tentinhtrang.Name = "tentinhtrang";
            // 
            // txttentinhtrang
            // 
            this.txttentinhtrang.Location = new System.Drawing.Point(465, 11);
            this.txttentinhtrang.Name = "txttentinhtrang";
            this.txttentinhtrang.Size = new System.Drawing.Size(100, 20);
            this.txttentinhtrang.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(362, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Tên Tình Trạng";
            // 
            // txtmatinhtrang
            // 
            this.txtmatinhtrang.Location = new System.Drawing.Point(170, 11);
            this.txtmatinhtrang.Name = "txtmatinhtrang";
            this.txtmatinhtrang.Size = new System.Drawing.Size(100, 20);
            this.txtmatinhtrang.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Mã Tình Trạng";
            // 
            // Formtinhtrang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dataGridView_Formtinhtrang);
            this.Controls.Add(this.txttentinhtrang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtmatinhtrang);
            this.Controls.Add(this.label1);
            this.Name = "Formtinhtrang";
            this.Text = "Formtinhtrang";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Formtinhtrang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dataGridView_Formtinhtrang;
        private System.Windows.Forms.TextBox txttentinhtrang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtmatinhtrang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn matinhtrang;
        private System.Windows.Forms.DataGridViewTextBoxColumn tentinhtrang;
    }
}