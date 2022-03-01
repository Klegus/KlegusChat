using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KlegusChat
{
    public partial class Chat : Form
    {
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
        public Chat()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Chat_Load(object sender, EventArgs e)
        {
            string[] users = Helper.GetUserCut($"SHOW TABLES like '{login.username}%'", login.username);
            //MessageBox.Show(users.Length.ToString());
            MSG.FlowDirection = FlowDirection.TopDown;
            MSG.AutoScroll = true;
            this.ChatTOP.Text = "Logged as " + login.username;
            ArrayList names = new ArrayList();
            for(int p = 0; p < users.Length; p++)
            {
                names.Add(users[p].ToString());
            }
            int i = 0;
            foreach (string n in names)
            {
                i++;
                Label label = new Label();
                label.Name = n + "L" + i ;
                label.Text = n;
                label.Dock = DockStyle.Top;
                label.Font = new Font("Calibri", 18);
                label.ForeColor = Color.White;
                label.Click += Label_Click;
                leftP.Controls.Add(label);
            }
        }
        
        private void Label_Click(object sender, EventArgs e)
        {
            
        }
        public void Opponent(string t, int i)
        {
            Label mine = new Label();
            mine.Name = "Opponent" + i.ToString();
            mine.Text = t;
            mine.Size = new Size(500, 25);
            mine.ForeColor = Color.White;
            mine.TextAlign = ContentAlignment.TopLeft;
            MSG.Controls.Add(mine);
        }
        public void Mine(string t, int i)
        {
            Label mine = new Label();
            mine.Name = "mine" + i.ToString();
            mine.Text = t;
            mine.Size = new Size(500, 25);
            mine.TextAlign = ContentAlignment.TopRight;
            mine.ForeColor = Color.White;
            MSG.Controls.Add(mine);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Opponent("Siema", 1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Mine("Siema co tam", 2);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }
    }
}
