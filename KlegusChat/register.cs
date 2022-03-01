using BCrypt;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KlegusChat
{
    public partial class register : Form
    {
        private string username { get; set; }
        private string Epassword { get; set; }
        private string password { get; set; }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );
        public register()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            login login = new login();
            login.Show();
        }

        private void signUPTBOX_Click(object sender, EventArgs e)
        {
            username = loginTBOX.Text;
            password = passTBOX.Text;
            if (String.IsNullOrEmpty(username) || String.IsNullOrEmpty(password))
            {
                erorrL.Text = "Something is empty";
            
                if(password == pass2TBOX.Text)
                {
                    if (Auth.UserExists(username))
                    {
                        if (Auth.register(username, password))
                        {
                            this.Hide();
                            Chat chat = new Chat();
                            chat.Show();
                        }
                    }
                    else
                    {
                        erorrL.Text = "Wrong password or username";
                    }
                }
                else
                {
                    erorrL.Text = "Passwords are diffrent";
                }
                
            }
        }

        private void register_Load(object sender, EventArgs e)
        {

        }
        
        private void loginTBOX_KeyUp(object sender, KeyEventArgs e)
        {
            
        }
        private void test()
        {
            if (Helper.mysql_check($"SELECT username from users where username='{loginTBOX.Text}'"))
            {
                register r = new register();
                r.
                UsernameState.Image = Properties.Resources.x;
            }
            else
            {
                UsernameState.Image = Properties.Resources.done;
            }
        }
        private void loginTBOX_KeyPress(object sender, KeyPressEventArgs e)
        {
            Thread a = new Thread(() => test());
            a.Start();
        }
    }
}
