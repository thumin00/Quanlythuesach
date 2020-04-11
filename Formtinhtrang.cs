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
    public partial class Formtinhtrang : Form
    {
        public Formtinhtrang()
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
            DataTable tabletinhtrang;
            sql = "select * from tinhtrang";
            // dataGridView_Formtinhtrang.DataSource = tabletinhtrang;
            dataGridView_Formtinhtrang.Columns[0].HeaderText = " Mã tình trạng";
            dataGridView_Formtinhtrang.Columns[1].HeaderText = "Tên tình trạng";
            dataGridView_Formtinhtrang.AllowUserToAddRows = false;
            dataGridView_Formtinhtrang.EditMode = DataGridViewEditMode.EditProgrammatically;
            // tabletinhtrang.Dispose();
        }
        private void Formtinhtrang_Load(object sender, EventArgs e)
        {
            hienthi();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            txtmatinhtrang.Enabled = true;
            txttentinhtrang.Enabled= true;
            btnLuu.Enabled = true;
            btnSua.Enabled = false;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;

        }

        private void Formtinhtrang_Activated(object sender, EventArgs e)
        {
            hienthi();
        }

        private void DataGridView_Formtinhtrang_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            //hienthi();
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtmatinhtrang.Text == "" && txttentinhtrang.Text == "")
            {
                MessageBox.Show("Bạn không được để trống ", "Thông báo");
                txttentinhtrang.Focus();
            }
            else
            {
                sql = "select * from tentinhtrang where Formtinhtrang=N'" + txtmatinhtrang.Text.Trim() + "'";
                sql = "update tinhtrang set tentinhtrang=N'" + txttentinhtrang.Text.Trim() + "'where matinhtrang=N'" + txtmatinhtrang.Text.Trim() + "'";
                capnhat(sql);
                txtmatinhtrang.Enabled = false;
                txttentinhtrang.Enabled = false;
                txtmatinhtrang.Text = "";
                txttentinhtrang.Text = "";
                hienthi();
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            String sql;
            //Form f = new Form();
            //f.StartPosition = FormStartPosition.CenterScreen;
            txtmatinhtrang.Enabled = true;
            txttentinhtrang.Enabled = true;
            txtmatinhtrang.Text = dataGridView_Formtinhtrang.CurrentRow.Cells["matinhtrang"].Value.ToString();
            txttentinhtrang.Text = dataGridView_Formtinhtrang.CurrentRow.Cells["tentinhtrang"].Value.ToString();

            if (txttentinhtrang.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên tình trạng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txttentinhtrang.Text.Trim().Length == 0)
            {
                MessageBox.Show("bạn phải nhập tên tình trạng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txttentinhtrang.Focus();
                return;
            }

            // hienthi();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (MessageBox.Show("bạn có muốn xóa?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK) ;
            {
                sql = "delete matinhtrang where Formtinhtrang=N'" + dataGridView_Formtinhtrang.CurrentRow.Cells["maloaisach"].Value.ToString() + "'";
                capnhat(sql);
                hienthi();
            }
        }
    }
}







