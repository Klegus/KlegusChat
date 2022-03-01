using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KlegusChat
{
    
    public partial class login : Form
    {
        public static string username { get; set; }
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
        public login()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void login_Load(object sender, EventArgs e)
        {
            this.Text = "Chat " + Application.ProductVersion;
            
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

        }

        private void signBTN_Click(object sender, EventArgs e)
        {
            string pass = passTBOX.Text;
            username = loginTBOX.Text;
            if (String.IsNullOrEmpty(username) || String.IsNullOrEmpty(pass))
            {
                erorrL.Text = "Something is empty";
            }
            else
            {
                if (Auth.Login(username, pass))
                {

                    this.Hide();
                    Chat chat = new Chat();
                    chat.Show();
                }
                else
                {
                    erorrL.Text = "Wrong password or username";
                }
            }



        }

        private void signUPTBOX_Click(object sender, EventArgs e)
        {
            this.Hide();
            register register = new register();
            register.Show();
        }
    }
}
