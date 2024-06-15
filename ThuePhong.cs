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
    public partial class ThuePhong : Form
    {
        private SqlDataAdapter adapter;
        private DataSet dataset;
        public nMain fMain;
        public ThuePhong()
        {
            InitializeComponent();
        }
       
        private void ThuePhong_Load(object sender, EventArgs e)
        {
            LoadDatathue();
        }

        private void LoadDatathue()
        {
            SqlCommand cmd = new SqlCommand("DSPhieuthuephong", TruyXuatCSDL.taoketnoi());
            cmd.CommandType = CommandType.StoredProcedure;
            adapter = new SqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            adapter.Fill(tb);
            gvthue.DataSource = tb;
            gvthue.ClearSelection();
        }
    }
}
