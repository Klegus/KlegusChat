using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlegusChat
{
    internal class Helper
    {
        public static string Dc { get; set; }
        public static string mysql_get(string q)
        {
            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings["conn"];
            string conn = settings.ConnectionString;

            MySqlConnection con = new MySqlConnection(conn);
            MySqlCommand cmd = new MySqlCommand(q, con);

            con.Open();
            string adr = cmd.ExecuteScalar().ToString();
            con.Close();
            return adr;
        }
        public static bool mysql_check(string q)
        {
            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings["conn"];
            string conn = settings.ConnectionString;
            MySqlConnection con = new MySqlConnection(conn);
            MySqlCommand cmd = new MySqlCommand(q, con);
            con.Open();
            MySqlDataAdapter adapt = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapt.Fill(ds);
            con.Close();
            int count = ds.Tables[0].Rows.Count;
            if (count == 1)
            {
                return true;
            }
            return false;
        }
        public static string mysql_update(string q)
        {

            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings["conn"];
            string conn = settings.ConnectionString;
            MySqlConnection con = new MySqlConnection(conn);
            MySqlCommand cmd = new MySqlCommand(q, con);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            return "1";


        }
        public static bool mysql_insert(string q)
        {

            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings["conn"];
            string conn = settings.ConnectionString;
            MySqlConnection con = new MySqlConnection(conn);
            MySqlCommand cmd = new MySqlCommand(q, con);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;


        }

        public static void discord()
        {
            Dc = mysql_get("SELECT owner from version where id='1'");
        }
        public static bool CheckUsername(string u) 
        {
            return mysql_get($"SELECT username from users where username={u}") == "1";
        }
        public static bool AppStatus()
        {
            return Convert.ToBoolean(mysql_get("SELECT status from version where id='1'")) ? true : false;
        }
        public static string rngChar(int l)
        {
            StringBuilder a = new StringBuilder();
            Random rand = new Random();
            for (int i = 0; i < l; i++)
            {
                string chars = "$%#@!*abcdefghijklmnopqrstuvwxyz1234567890?;:ABCDEFGHIJKLMNOPQRSTUVWXYZ^&";
                int num = rand.Next(0, chars.Length);
                a.Append(chars[num]);
            }
            return a.ToString();
        }
    }
}
