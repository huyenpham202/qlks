using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKS
{
    static class TruyXuatCSDL
    {
        private const string link = "Data Source=DESKTOP-4EI10UH;Initial Catalog=QLKhachSan;Integrated Security=True";
        private static SqlConnection conn;
        public static bool ketnoi()
        {
            try
            {
                conn = new SqlConnection(link);
                conn.Open();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public static SqlConnection taoketnoi()
        {
            if (conn == null)
                ketnoi();
            return conn;
        }
        public static String Laygt(string s)
        {
            taoketnoi();
            SqlCommand cmd = new SqlCommand(s,conn);
            object kq = cmd.ExecuteScalar();
            if(kq == null)
                return "";
            else
                return kq.ToString();
        }
        public static void huyketnoi()
        {
            if (conn != null && conn.State == System.Data.ConnectionState.Open)
                conn.Close();
        }
    }
}