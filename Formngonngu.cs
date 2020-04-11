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
    public partial class Formngonngu : Form
    {
        public Formngonngu()
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
            DataTable tablengonngu;
            sql = "select * from ngonngu";
            // dataGridView_Formngonngu.DataSource = tablengonngu;
            dataGridView_Formngonngu.Columns[0].HeaderText = " Mã ngôn ngữ";
            dataGridView_Formngonngu.Columns[1].HeaderText = "Tên ngôn ngữ";
            dataGridView_Formngonngu.AllowUserToAddRows = false;
            dataGridView_Formngonngu.EditMode = DataGridViewEditMode.EditProgrammatically;
            // tablengonngu.Dispose();
        }
        private void Formngonngu_Load(object sender, EventArgs e)
        {
            hienthi();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            txtmangonngu.Enabled = true;
            txttenngonngu.Enabled = true;
            btnLuu.Enabled = true;
            btnSua.Enabled = false;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;

        }

        private void Formngonngu_Activated(object sender, EventArgs e)
        {
            hienthi();
        }

        private void DataGridView_Formngongu_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            //hienthi();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txttenngonngu.Text == "" && txttenngonngu.Text == "")
            {
                MessageBox.Show("Bạn không được để trống ", "Thông báo");
                txttenngonngu.Focus();
            }
            else
            {
                sql = "select * from tenngonngu where Formngonngu=N'" + txtmangonngu.Text.Trim() + "'";
                sql = "update ngonngu set tenngonngu=N'" + txttenngonngu.Text.Trim() + "'where mangonngu=N'" + txtmangonngu.Text.Trim() + "'";
                capnhat(sql);
                txtmangonngu.Enabled = false;
                txttenngonngu.Enabled = false;
                txtmangonngu.Text = "";
                txttenngonngu.Text = "";
                hienthi();
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            String sql;
            //Form f = new Form();
            //f.StartPosition = FormStartPosition.CenterScreen;
            txtmangonngu.Enabled = true;
            txttenngonngu.Enabled = true;
            txtmangonngu.Text = dataGridView_Formngonngu.CurrentRow.Cells["mangongu"].Value.ToString();
            txttenngonngu.Text = dataGridView_Formngonngu.CurrentRow.Cells["tenngongu"].Value.ToString();

            if (txttenngonngu.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên ngôn ngữ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txttenngonngu.Text.Trim().Length == 0)
            {
                MessageBox.Show("bạn phải nhập tên ngôn ngữ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txttenngonngu.Focus();
                return;
            }

            // hienthi();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (MessageBox.Show("bạn có muốn xóa?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK) ;
            {
                sql = "delete mangonngu where Formngonngu=N'" + dataGridView_Formngonngu.CurrentRow.Cells["mangonngu"].Value.ToString() + "'";
                capnhat(sql);
                hienthi();
            }
        }
    }
}