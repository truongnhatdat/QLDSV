using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using System.Data;
using System.Data.SqlClient;

namespace QLDSV
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        //public static string servername;
        public static SqlConnection conn = new SqlConnection();
        public static String connstr;
        public static FormMain FormChinh;
        public static String servername="";
        public static String username="";
        public static String mlogin="";
        public static String password="";

        public static String database = "QLDSV";
        public static String remotelogin = "HTKN";
        public static String remotepassword = "123456";
        public static String mloginDN = "";
        public static String passwordDN = "";
        public static String mGroup = "";
        public static String mHoten = "";
        public static int mChinhanh = 0;

        public static BindingSource bds_dspm = new BindingSource();
        //public static Form1 frmChinh;

        public static int KetNoi()
        {
            if (Program.conn != null && Program.conn.State == ConnectionState.Open)
                Program.conn.Close();
            try
            {
                Program.connstr = "Data Source=" + Program.servername + ";Initial Catalog=" +
                      Program.database + ";User ID=" +
                      Program.mlogin + ";password=" + Program.password;
                Program.conn.ConnectionString = Program.connstr;
                Program.conn.Open();
                return 1;
            }

            catch (Exception e)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu.\nBạn xem lại user name và password.\n " + e.Message, "", MessageBoxButtons.OK);
                return 0;
            }
        }
        public static SqlDataReader ExecSqlDataReader(String strLenh)
        {
            SqlDataReader myreader;
            SqlCommand sqlcmd = new SqlCommand(strLenh, Program.conn);
            sqlcmd.CommandType = CommandType.Text;
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            try
            {
                myreader = sqlcmd.ExecuteReader(); return myreader;
            }
            catch (SqlException ex)
            {
                Program.conn.Close();
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public static void chuyenlop(String strLenh,String malop,String masv,String ho,String ten,int phai,DateTime ns,String noisinh,String dc,String gc,int nh)
        {
            SqlCommand Sqlcmd = new SqlCommand(strLenh, conn);
            Sqlcmd.CommandType = CommandType.StoredProcedure;
            //if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            try
            {
                SqlParameter p1 = new SqlParameter("@MALOP", malop);
                Sqlcmd.Parameters.Add(p1);
                SqlParameter p2 = new SqlParameter("@MASV", masv);
                Sqlcmd.Parameters.Add(p2);
                SqlParameter p3 = new SqlParameter("@HO", ho);
                Sqlcmd.Parameters.Add(p3);
                SqlParameter p4 = new SqlParameter("@TEN", ten);
                Sqlcmd.Parameters.Add(p4);
                SqlParameter p5 = new SqlParameter("@PHAI", phai);
                Sqlcmd.Parameters.Add(p5);
                SqlParameter p6 = new SqlParameter("@NGAYSINH", ns);
                Sqlcmd.Parameters.Add(p6);
                SqlParameter p7 = new SqlParameter("@NOISINH", noisinh);
                Sqlcmd.Parameters.Add(p7);
                SqlParameter p8 = new SqlParameter("@DIACHI", dc);
                Sqlcmd.Parameters.Add(p8);
                SqlParameter p9 = new SqlParameter("@GHICHU", gc);
                Sqlcmd.Parameters.Add(p9);
                SqlParameter p10 = new SqlParameter("@NGHIHOC", nh);
                Sqlcmd.Parameters.Add(p10);

                Sqlcmd.ExecuteNonQuery();
                MessageBox.Show("Thêm thành công", "", MessageBoxButtons.OK);
                return;
            }
            catch (SqlException ex)
            {
                Program.conn.Close();
                MessageBox.Show(ex.Message);
                return;
            }
        }
        public static DataTable ExecSqlDataTable(String cmd, string connstr)
        {
            DataTable dt = new DataTable();
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd, conn);
            try
            {
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.Message);
                return null;
            }
            
           
        }
        public static void taotaikhoan(String strLenh,String login, String pass, String user,String role)
        {
            SqlCommand Sqlcmd = new SqlCommand(strLenh, conn);
            Sqlcmd.CommandType = CommandType.StoredProcedure;
            try
            {
                SqlParameter p1 = new SqlParameter("@LGNAME", login);
                Sqlcmd.Parameters.Add(p1);
                SqlParameter p2 = new SqlParameter("@PASS", pass);
                Sqlcmd.Parameters.Add(p2);
                SqlParameter p3 = new SqlParameter("@USRNAME", user);
                Sqlcmd.Parameters.Add(p3);
                SqlParameter p4 = new SqlParameter("@ROLE", role);
                Sqlcmd.Parameters.Add(p4);

                Sqlcmd.ExecuteNonQuery();
                MessageBox.Show("Tạo thành công", "", MessageBoxButtons.OK);
                return;
            }
            catch (Exception ex)
            {
                Program.conn.Close();
                MessageBox.Show("Tạo thất bại " + ex.Message, "", MessageBoxButtons.OK);
            }
           
        }
        public static void kiemtramalop(String strLenh, String malop)
        {
            SqlCommand Sqlcmd = new SqlCommand(strLenh, conn);
            Sqlcmd.CommandType = CommandType.StoredProcedure;
            try
            {
                SqlParameter p = new SqlParameter("@MALOP", malop);
                Sqlcmd.ExecuteNonQuery();
                MessageBox.Show("Kiểm tra thành công ","", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kiểm tra thất bại " + ex.Message, "", MessageBoxButtons.OK);
            }
        }
        public static void capnhat(String strLenh)
        {
            SqlCommand Sqlcmd = new SqlCommand(strLenh, conn);
            //Sqlcmd.CommandType = CommandType.Text;
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
               
                Sqlcmd.ExecuteNonQuery();
              
            }
            catch (Exception ex)
            {
                Program.conn.Close();
                MessageBox.Show("Tạo thất bại " + ex.Message, "", MessageBoxButtons.OK);
            }
        }
        public static int ExecSqlNonQuery(String strlenh)
        {
            SqlCommand Sqlcmd = new SqlCommand(strlenh, conn);
            Sqlcmd.CommandType = CommandType.Text;
            Sqlcmd.CommandTimeout = 600;// 10 phut 
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                Sqlcmd.ExecuteNonQuery(); conn.Close();
                return 0;
            }
            catch (SqlException ex)
            {
                if (ex.Message.Contains("Error converting data type varchar to int"))
                    MessageBox.Show("Bạn format Cell lại cột \"Ngày Thi\" qua kiểu Number hoặc mở File Excel.");
                else MessageBox.Show(ex.Message);
                MessageBox.Show(ex.Message);
                conn.Close();
                return ex.State; // trang thai lỗi gởi từ RAISERROR trong SQL Server qua
            }
        }
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

           // BonusSkins.Register();
           // SkinManager.EnableFormSkins();
            FormChinh = new FormMain();
            Application.Run(FormChinh);
        }
    }
}
