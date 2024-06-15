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
    public partial class DoiMK : Form
    {

        public nMain fMain;
        public DoiMK()
        {
            InitializeComponent();
        }

        private void DoiMK_Load(object sender, EventArgs e)
        {
            lblUser.Text = fMain.musername;
            btnXacnhan.Enabled = false;
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXacnhan_Click(object sender, EventArgs e)
        {
            SqlConnection con = TruyXuatCSDL.taoketnoi();
            SqlCommand cmd = new SqlCommand("CheckLogin", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@username", fMain.musername));
            cmd.Parameters.Add(new SqlParameter("@password", txtMkc.Text));
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    reader.Close();
                    SqlCommand cmd2 = new SqlCommand("ChangePass", con);
                    cmd2.CommandType = CommandType.StoredProcedure;
                    cmd2.Parameters.Add(new SqlParameter("@username", fMain.musername));
                    cmd2.Parameters.Add(new SqlParameter("@password", txtMkm2.Text));
                    try
                    {
                        SqlDataReader reader2 = cmd2.ExecuteReader();
                        MessageBox.Show("Đổi mật khẩu thành công!", "Đổi mật khẩu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        reader2.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("" + ex, "Lỗi");
                    }
                }
                else
                    MessageBox.Show("Mật khẩu cũ không chính xác", "Đổi mật khẩu!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                reader.Close();
            }
        }

        private void txtMkm_KeyUp(object sender, KeyEventArgs e)
        {
            txtMkm2_KeyUp(sender, e);
        }

        private void txtMkm2_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtMkm.Text != txtMkm2.Text || txtMkm.Text == "")
            {
                btnXacnhan.Enabled = false;
                batloi.SetError(txtMkm2, "Mật khẩu không khớp!");
            }
            else
            {
                btnXacnhan.Enabled = true;
                batloi.SetError(txtMkm2, "");
            }
        }

        private void txtMkm_TextChanged(object sender, EventArgs e)
        {
            txtMkm2_TextChanged(sender, e);
        }

        private void txtMkm2_TextChanged(object sender, EventArgs e)
        {
            if (txtMkm.Text != txtMkm2.Text || txtMkm.Text == "")
            {
                btnXacnhan.Enabled = false;
                batloi.SetError(txtMkm2, "Mật khẩu không khớp!");
            }
            else
            {
                btnXacnhan.Enabled = true;
                batloi.SetError(txtMkm2, "");
            }
        }
    }
}
