using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;

namespace QLKS
{
    public partial class Login : Form
    {
        public nMain fMain;
        String fullname = "";

        public Login()
        {
            InitializeComponent();
        }

        private bool tendn()
        {
            if (txttenDangnhap.Text == "")
            {
                MessageBox.Show("Tên đăng nhập không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private bool mk()
        {
            if (txtmatKhau.Text == "")
            {
                MessageBox.Show("Mật khẩu không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private bool kiemtra()
        {
            if (tendn() && mk())
            {
                return true;
            }
            return false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (kiemtra())
            {
                SqlConnection con = TruyXuatCSDL.taoketnoi();
                SqlCommand cmd = new SqlCommand("CheckLogin", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@username", txttenDangnhap.Text.Trim()));
                cmd.Parameters.Add(new SqlParameter("@password", txtmatKhau.Text.Trim()));
                using (SqlDataReader reader = cmd.ExecuteReader())
                {   
                    if(!reader.Read())
                    {
                        MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác", "Đăng nhập thất bại!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        fullname = reader["fullname"].ToString();
                        fMain.mfullname = fullname;
                        fMain.mchucvu = reader["chucvu"].ToString();
                        fMain.musername = reader["username"].ToString();
                        MessageBox.Show("Đăng nhập thành công!\nXin chào " + fullname, "Đăng nhập thành công!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Hide();
                    }
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txttenDangnhap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtmatKhau.Focus();
            }
        }

        private void txtmatKhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnLogin_Click(sender, e);
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
