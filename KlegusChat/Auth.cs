using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Threading;
using System.Windows.Forms;

namespace KlegusChat
{
    internal class Auth
    {
        public static string username { get; set; }
        public static bool Root = false;
        public static string lastlogin { get; set; }

        private static bool isRoot(string u)
        {
            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings["conn"];
            string conn = settings.ConnectionString;
            MySqlConnection con = new MySqlConnection(conn);
            MySqlCommand cmd = new MySqlCommand($"SELECT status FROM users WHERE username='{u}';", con);
            con.Open();
            string rootState = cmd.ExecuteScalar().ToString();
            con.Close();
            if (rootState.Equals("root"))
            {
                return true;
            }
            return false;
        }
        private static void UpdateIP(string u)
        {
            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings["conn"];
            string conn = settings.ConnectionString;
            MySqlConnection con = new MySqlConnection(conn);
            MySqlCommand cmd = new MySqlCommand($"UPDATE users set ip='{ip.grab()}' where username='{u}';", con);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
            }
        }
        private static void UpdateLastLogin(string u)
        {
            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings["conn"];
            string conn = settings.ConnectionString;
            MySqlConnection con = new MySqlConnection(conn);
            lastlogin = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            MySqlCommand cmd = new MySqlCommand($"UPDATE users set lastlogin='{lastlogin}' where username='{u}';", con);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {

            }

        }
        
        public static bool UserExists(string u)
        {
            bool IsAcc = Helper.mysql_check($"SELECT username,password from users where username='{u}';");
            if (!IsAcc)
            {
                return false;
            }
            return true;
        }
        public static bool Login(string u, string p)
        {
            Thread upIp = new Thread(() => UpdateIP(u));
            Thread upLL = new Thread(() => UpdateLastLogin(u));
            string passE = Helper.mysql_get($"SELECT password from users where username='{u}';");
            bool isAccExists = Helper.mysql_check($"SELECT username,password from users where username='{u}';");
            bool isPassGood = BCrypt.Net.BCrypt.Verify(p, passE);
            if (isAccExists && isPassGood)
            {
                upIp.Start();
                upLL.Start();
                return true;
            }
            return false;
        }
        public static bool register(string u, string p)
        {
            bool isCreated = Helper.mysql_insert($"INSERT INTO users VALUES(NULL,'{u}','{BCrypt.Net.BCrypt.HashPassword(p)}',NULL,'user','{ip.grab()}')");
            if (!isCreated)
            {
                return false;
            }
            return true;
        }
    }
}
