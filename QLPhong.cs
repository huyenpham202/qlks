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

namespace QLKS
{
    public partial class QLPhong : Form
    {
        public nMain fMain;

        private SqlDataAdapter adapter;
        private DataSet dataset;
        public QLPhong()
        {
            InitializeComponent();
        }

        private void QLPhong_Load(object sender, EventArgs e)
        {
            LoadComboLoai();
            LoadDataPhong();
            LoadDataLoaiPhong();
        }
        
        private void LoadDataPhong()
        {
            SqlCommand cmd = new SqlCommand("DSPhong", TruyXuatCSDL.taoketnoi());
            cmd.CommandType = CommandType.StoredProcedure;
            adapter = new SqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            adapter.Fill(tb);
            gvp.DataSource = tb;
            gvp.ClearSelection();

        }
        private void LoadComboLoai()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM [tblloaiphong]", TruyXuatCSDL.taoketnoi());
            dataset = new DataSet();
            adapter = new SqlDataAdapter(cmd);
            if (dataset.Tables["maloai"] != null)
            {
                dataset.Tables["maloai"].Clear();
            }
            adapter.Fill(dataset, "maloai");
            cbLoaiPhong.DataSource = dataset.Tables["maloai"];
            cbLoaiPhong.DisplayMember = "maloai";
        }
        private void ReadDataPhong()
        {
            if (gvp.SelectedRows.Count == 0)
                return;
            DataGridViewRow row = gvp.SelectedRows[0];
            txtMaphong.Text = row.Cells["Mã phòng"].Value.ToString();
        }
        private void ReadDatalPhong()
        {
            if (gvlp.SelectedRows.Count == 0)
                return;
            DataGridViewRow a = gvlp.SelectedRows[0];
            txtMaloai.Text = a.Cells["Loại Phòng"].Value.ToString();
            txtSonguoi.Text = a.Cells["Số người"].Value.ToString();
            txtgia.Text = a.Cells["Giá"].Value.ToString();
        }
        private void LoadDataLoaiPhong()
        {
            SqlCommand cmd = new SqlCommand("DSLoaiPhong", TruyXuatCSDL.taoketnoi());
            cmd.CommandType = CommandType.StoredProcedure;
            adapter = new SqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            adapter.Fill(tb);
            gvlp.DataSource = tb;
            gvlp.ClearSelection();
        }

        private void gvp_Click(object sender, EventArgs e)
        {
            ReadDataPhong();
        }

        private void gvlp_Click(object sender, EventArgs e)
        {
            ReadDatalPhong();
        }
    }
}

