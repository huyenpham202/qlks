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
    public partial class NguoiDung : Form
    {
        public nMain fMain;

        public NguoiDung()
        {
            InitializeComponent();
        }
        private void LoadDataUser()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM tbluser", TruyXuatCSDL.taoketnoi());
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            adapter.Fill(tb);
            gvus.DataSource = tb;
            gvus.ClearSelection();
        }
        private void NguoiDung_Load(object sender, EventArgs e)
        {
            LoadDataUser();
        }
        private bool tendn()
        {
            if (txttdn.Text == "")
            {
                MessageBox.Show("Tên đăng nhập không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private bool mk()
        {
            if (txtmk.Text == "")
            {
                MessageBox.Show("Mật khẩu không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private bool ten()
        {
            if (txtten.Text == "")
            {
                MessageBox.Show("Tên người dùng không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private bool cv()
        {
            if (txtten.Text == "")
            {
                MessageBox.Show("Chức vụ không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private bool kiemtra()
        {
            if (tendn() && mk() && ten() && cv())
            {
                return true;
            }
            return false;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {

            SqlCommand cmd = new SqlCommand("ThemUser", TruyXuatCSDL.taoketnoi());
            cmd.CommandType = CommandType.StoredProcedure;
            if (kiemtra())
            {
                cmd.Parameters.AddWithValue("@username", txttdn.Text);
                cmd.Parameters.AddWithValue("@password", txtmk.Text);
                cmd.Parameters.AddWithValue("@fullname", txtten.Text);
                cmd.Parameters.AddWithValue("@chucvu", txtcv.Text);
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Đã thêm user mới!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDataUser();

                }
                catch (SqlException exc)
                {
                    if (exc.Number == 2627)
                    {
                        MessageBox.Show("User đã tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Lỗi không xác định:\n" + exc.Message, "Lỗi" + exc.Number, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            String MakhCu = (String)gvus.SelectedRows[0].Cells[0].Value;
            SqlCommand cmd = new SqlCommand("SuaUser", TruyXuatCSDL.taoketnoi());
            if (kiemtra())
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@username", txttdn.Text);
                cmd.Parameters.AddWithValue("@password", txtmk.Text);
                cmd.Parameters.AddWithValue("@fullname", txtten.Text);
                cmd.Parameters.AddWithValue("@chucvu", txtcv.Text);
            }
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Đã sửa thông tin user!", "Cập nhật thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDataUser();
            }
            catch (SqlException exc)
            {
                if (exc.Number == 2627)
                {
                    MessageBox.Show("User đã tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Lỗi không xác định:\n" + exc.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (gvus.SelectedRows.Count > 0)
            {

                SqlCommand cmd = new SqlCommand("XoaUser", TruyXuatCSDL.taoketnoi());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@username", gvus.SelectedRows[0].Cells[0].Value);
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Đã xóa khách hàng!", "Xóa thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDataUser();
                }
                catch (SqlException exc)
                {
                    MessageBox.Show("Lỗi không xác định:\n" + exc.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("Chọn khách hàng cần xóa", "Xóa khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }
}
