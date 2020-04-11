using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanlythuesach
{
    public partial class Formloaisach : Form
    {
        public Formloaisach()
        {
            InitializeComponent();
        }
        public static SqlConnection conn = new SqlConnection();
        public static string connectstring = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=cuahangchothuesach;Integrated Security=True";
        public static void ketnoi()
        {
            conn = new SqlConnection();
            conn.ConnectionString = connectstring;
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
        }
        public static void Dongketnoi()
        {

            if (conn.State != ConnectionState.Closed)
            {
                conn.Close();
                conn.Dispose();
                conn = null;
            }
        }
        public static DataTable Docbang(string sql)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter mydata = new SqlDataAdapter();
            mydata.SelectCommand = new SqlCommand();
            ketnoi();
            mydata.SelectCommand.Connection = conn;
            mydata.SelectCommand.CommandText = sql;
            mydata.Fill(dt);
            Dongketnoi();
            return dt;
        }
        public static void capnhat(string sql)
        {
            ketnoi();
            SqlCommand sqlcomand = new SqlCommand();
            sqlcomand.Connection = conn;
            sqlcomand.CommandText = sql;
            sqlcomand.ExecuteNonQuery();
            Dongketnoi();
        }
        private void hienthi()
        {
            string sql;
            DataTable tableloaisach;
            sql = "select * from loaisach";
           // dataGridView_Formloaisach.DataSource = tableloaisach;
            dataGridView_Formloaisach.Columns[0].HeaderText = " Mã loại sách";
            dataGridView_Formloaisach.Columns[1].HeaderText = "Tên loại sách";
            dataGridView_Formloaisach.AllowUserToAddRows = false;
            dataGridView_Formloaisach.EditMode = DataGridViewEditMode.EditProgrammatically;
           // tableloaisach.Dispose();
        }
        private void Formloaisach_Load(object sender, EventArgs e)
        {
            hienthi();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            txtmaloaisach.Enabled = true;
            txtmaloaisach.Enabled = true;         
            btnLuu.Enabled = true;
            btnSua.Enabled = false;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
           
        }

        private void Formloaisach_Activated(object sender, EventArgs e)
        {
            hienthi();
        }

        private void DataGridView_Formloaisach_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            //hienthi();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtmaloaisach.Text == "" && txttenloaisach.Text == "")
            {
                MessageBox.Show("Bạn không được để trống ", "Thông báo");
                txttenloaisach.Focus();
            }
            else
            {
                sql = "select * from tenloaisach where Formloaisach=N'" + txtmaloaisach.Text.Trim() + "'";
                sql = "update loaisach set tenloaisach=N'" + txttenloaisach.Text.Trim() + "'where maloaisach=N'" + txtmaloaisach.Text.Trim() + "'";
                capnhat(sql);
                txtmaloaisach.Enabled = false;
                txttenloaisach.Enabled = false;               
                txtmaloaisach.Text = "";
                txttenloaisach.Text = "";
                hienthi();
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            String sql;
            //Form f = new Form();
            //f.StartPosition = FormStartPosition.CenterScreen;
            txtmaloaisach.Enabled = true;
            txttenloaisach.Enabled = true;
            txtmaloaisach.Text = dataGridView_Formloaisach.CurrentRow.Cells["maloaisach"].Value.ToString();
            txttenloaisach.Text = dataGridView_Formloaisach.CurrentRow.Cells["tenloaisach"].Value.ToString();
          
            if (txttenloaisach.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên loại sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txttenloaisach.Text.Trim().Length == 0)
            {
                MessageBox.Show("bạn phải nhập tên loại sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txttenloaisach.Focus();
                return;
            }
            
           // hienthi();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (MessageBox.Show("bạn có muốn xóa?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK) ;
            {
                sql = "delete maloaisach where Formloaisach=N'" + dataGridView_Formloaisach.CurrentRow.Cells["maloaisach"].Value.ToString() + "'";
                capnhat(sql);
                hienthi();
            }
        }
    }
}
