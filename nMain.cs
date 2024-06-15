using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Net.WebRequestMethods;

namespace QLKS
{
    public partial class nMain : Form
    {
        public Login fLogin;
        public DoiMK fDoiMK;
        public KhachHang fKH;
        public QLPhong fP;
        public DatPhong fDP;
        public ThuePhong fTP;
        public NguoiDung fND;
        public String musername = null;
        public String mfullname = null;
        public String mchucvu = null;
        public nMain()
        {
            InitializeComponent();
        }

        private void nMain_Load(object sender, EventArgs e)
        {
            MainDisable();
            fLogin = new Login();
            fLogin.fMain = this;
            fLogin.ShowDialog();
            if (mchucvu == "Nhân viên")
            {
                MainEnNhanVien();
            }
            else if (mchucvu == "admin")
            {
                MainEnabled();
            }
            else if (mchucvu == "Quản lý")
            {
                MainEnQuanLy();
            }
            else if (mchucvu == "Khách hàng")
            {
                MainKH();
            }
            else
            {
                Application.Exit();
            }

            lblUser.Text = "Hi " + mfullname + " !";
            ThongKe();
            LoadSDP();

        }
        public void ThongKe()
        {
            SqlConnection con = TruyXuatCSDL.taoketnoi();
            SqlCommand cmd = new SqlCommand("ThongKe", con);
            cmd.CommandType = CommandType.StoredProcedure;

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                reader.Read();
                lbpt.Text = reader["phongtrong"].ToString();
                lbpd.Text = reader["phongdadat"].ToString();
                lbpdt.Text = reader["phongdanhan"].ToString();
            }
        }
        public void LoadSDP()
        {
            lvPhong.Items.Clear();
            SqlConnection con = TruyXuatCSDL.taoketnoi();
            SqlCommand cmd = new SqlCommand("SELECT * FROM tblphong", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ListViewItem item = new ListViewItem(dt.Rows[i]["maphong"].ToString());
                    ListViewItem.ListViewSubItem subitem = new ListViewItem.ListViewSubItem(item, dt.Rows[i]["maphong"].ToString());
                    String dat = "";
                    String nhan = "";
                    dat = dt.Rows[i]["dadat"].ToString();
                    nhan = dt.Rows[i]["danhan"].ToString();
                    if (dat == "0" && nhan == "0")
                    {
                        item.SubItems.Add(subitem);
                        lvPhong.Items.Add(item);
                        item.ImageIndex = 0;
                    }
                    else if (dat == "1" && nhan == "0")
                    {
                        item.SubItems.Add(subitem);
                        lvPhong.Items.Add(item);
                        item.ImageIndex = 1;
                    }
                    else if (dat == "0" && nhan == "1")
                    {
                        item.SubItems.Add(subitem);
                        lvPhong.Items.Add(item);
                        item.ImageIndex = 2;
                    }
                }
            }
            else
                MessageBox.Show("Không có dữ liệu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void MainEnabled()
        {
            mnQuanly.Enabled = true;
            mnDoimatkhau.Enabled = true;
            mnKhachhang1.Enabled = true;
            mnDatphong1.Enabled = true;
            mnDangxuat.Enabled = true;
        }
        private void MainKH()
        {
            mnQuanly.Enabled = false;
            mnDoimatkhau.Enabled = true;
            mnKhachhang1.Enabled = false;
            mnDatphong1.Enabled = true;
            mnDangxuat.Enabled = true;
        }
        private void MainDisable()
        {
            mnQuanly.Enabled = false;
            mnDoimatkhau.Enabled = false;
            mnKhachhang1.Enabled = false;
            mnDatphong1.Enabled = false;
            mnDangxuat.Enabled = false;
        }
        private void MainEnQuanLy()
        {
            mnQuanly.Enabled = true;
            mnDoimatkhau.Enabled = true;
            mnKhachhang1.Enabled = true;
            mnDatphong1.Enabled = true;
            mnDangxuat.Enabled = true;
        }
        private void MainEnNhanVien()
        {
            mnQuanly.Enabled = false;
            mnDoimatkhau.Enabled = true;
            mnKhachhang1.Enabled = true;
            mnDatphong1.Enabled = true;
            mnDangxuat.Enabled = true;
        }
        private void mnDangnhap_Click(object sender, EventArgs e)
        {
            fLogin = new Login();
            fLogin.fMain = this;
            fLogin.ShowDialog();
            if (mchucvu == "admin")
            {
                MainEnabled();
            }
            else if (mchucvu == "Quản lý")
            {
                MainEnQuanLy();
            }
            else
            {
                MainEnNhanVien();
            }
            lblUser.Text = "Hi " + mfullname + " !";
        }

        private void mnDoimatkhau_Click(object sender, EventArgs e)
        {
            fDoiMK = new DoiMK();
            fDoiMK.fMain = this;
            fDoiMK.ShowDialog();
        }

        private void mnDangxuat_Click(object sender, EventArgs e)
        {
            lblUser.Text = "Hi!";
            MainDisable();
        }
        private void mnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void mnKhachhang_Click(object sender, EventArgs e)
        {
            fKH = new KhachHang();
            fKH.fMain = this;
            fKH.ShowDialog();
        }
        private void mnDatphong_Click(object sender, EventArgs e)
        {
            fDP = new DatPhong();
            fDP.fMain = this;
            fDP.ShowDialog();
        }
        private void mnThuephong_Click(object sender, EventArgs e)
        {
            fTP = new ThuePhong();
            fTP.fMain = this;
            fTP.ShowDialog();
        }
        private void mnPhong_Click(object sender, EventArgs e)
        {
            fP = new QLPhong();
            fP.fMain = this;
            fP.ShowDialog();
        }
        private void mnNguoidung_Click(object sender, EventArgs e)
        {
            fND = new NguoiDung();
            fND.fMain = this;
            fND.ShowDialog();
        }

        private void lvPhong_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
