using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing.Drawing2D;
using System.Threading;
using System.Data.SQLite;
using System.IO;


namespace PoliHack_App_Esentza
{
    public partial class Meniu : Form
    {
        static int count = 0, limit = 7, countAll = 0;

        public static string user = "";
        private Form activeForm = null;

        SQLiteConnection conn = new SQLiteConnection(@"data source=C:\Users\arthu\source\repos\cristicretu\Bob_SpeechRecognition\Resources\ii_bun.sqlite;Default Database Type=String");

        DateTime day = DateTime.Today;

        public Meniu()
        {
            Thread t = new Thread(new ThreadStart(Run));


            t.Start();
             while (user == "") ;
            
            InitializeComponent();

            textBox1.BringToFront();
            textBox2.BringToFront();

            this.TopMost = true;

            textBox3.Text = user;

            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 35, 35));

            PnlNav.Height = btnHome.Height;
            PnlNav.Top = btnHome.Top;
            PnlNav.Left = btnHome.Left;
            PnlNav.Visible = true;
            btnHome.BackColor = Color.FromArgb(215, 201, 153);
            
     
        }

        public static string get_user()
        {
            return user;
        }

        

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Meniu_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        void Run()
        {
            using (C_SpeechRecognition.Log_In l = new C_SpeechRecognition.Log_In())
            {
                if (l.ShowDialog() == DialogResult.OK)
                    user = l.get_username();
            }
        }

        private void Meniu_Load(object sender, EventArgs e)
        {


            textBox1.Text = "Welcome, " + user;
            PnlNav.BringToFront();


            button4.FlatStyle = FlatStyle.Flat;
            button4.FlatAppearance.BorderColor = BackColor;
            button4.FlatAppearance.MouseOverBackColor = BackColor;
            button4.FlatAppearance.MouseDownBackColor = BackColor;

            button5.FlatStyle = FlatStyle.Flat;
            button5.FlatAppearance.BorderColor = BackColor;
            button5.FlatAppearance.MouseOverBackColor = BackColor;
            button5.FlatAppearance.MouseDownBackColor = BackColor;

            this.Opacity = .99;
            notifyIcon.Text = "Bob";
            notifyIcon.Visible = false;
            notifyIcon.BalloonTipIcon = ToolTipIcon.Info;
        }

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

       

        

        private void button4_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void Meniu_Move(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                Hide();
                notifyIcon.Visible = true;
            }
            else
            {
                this.Opacity = .69;
            }
        }
        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                Show();
                this.WindowState = FormWindowState.Normal;
                this.Opacity = .99;
                notifyIcon.Visible = false;
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e) { }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Show();
            notifyIcon.Visible = false;
            this.WindowState = FormWindowState.Normal;
            this.Opacity = .99;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Meniu_ResizeEnd(object sender, EventArgs e)
        {
            this.Opacity = .99;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void label1_Click(object sender, EventArgs e) { }
        private void btnHome_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            PnlNav.Height = btnHome.Height;
            PnlNav.Top = btnHome.Top;
            PnlNav.Left = btnHome.Left;
            PnlNav.Visible = true;
            btnHome.BackColor = Color.FromArgb(215, 201, 153);
        }
        private void btnStatistics_Click(object sender, EventArgs e)
        {
            btnHome.BackColor = Color.FromArgb(236, 220, 171);
            PnlNav.Height = btnStatistics.Height;
            PnlNav.Top = btnStatistics.Top;
            PnlNav.Left = btnStatistics.Left;
            PnlNav.Visible = true;
            openChildForm(new C_SpeechRecognition.statistics());
            btnStatistics.BackColor = Color.FromArgb(215, 201, 153);
        }
        private void PnlNav_Paint(object sender, PaintEventArgs e) { }
        private void btnHome_Leave(object sender, EventArgs e)
        {
            btnHome.BackColor = Color.FromArgb(236, 220, 171);
        }
        private void btnStatistics_Leave(object sender, EventArgs e)
        {
            btnStatistics.BackColor = Color.FromArgb(236, 220, 171);
        }
        private void btnSettings_Click(object sender, EventArgs e)
        {
            btnHome.BackColor = Color.FromArgb(236, 220, 171);
            btnStatistics.BackColor = Color.FromArgb(236, 220, 171);
            PnlNav.Height = btnSettings.Height;
            PnlNav.Top = btnSettings.Top;
            PnlNav.Left = btnSettings.Left;
            PnlNav.Visible = true;
            openChildForm(new C_SpeechRecognition.Settings());
            btnSettings.BackColor = Color.FromArgb(215, 201, 153);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            ++count;
            ++countAll;
            if (count == limit)
            {
                string ed = "";
                if (limit == 7)
                    ed = "two hours";
                else ed = "for another hour";
                limit = 3600;
                count = 0;
                notifyIcon.Visible = true;
                notifyIcon.ShowBalloonTip(5000, "Too much time on the computer", "You have been sitting on the computer for " + ed + ".", ToolTipIcon.Warning);
                notifyIcon.Visible = false;
            }
        }

        public static int get_counts()
        {
            return countAll;
        }

        private void btnSettings_Leave(object sender, EventArgs e)
        {
            btnSettings.BackColor = Color.FromArgb(236, 220, 171);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }


        private void btnDashboard_Click(object sender, EventArgs e)
        {
            textBox3.Enabled = true;

            btnHome.BackColor = Color.FromArgb(236, 220, 171);
            btnStatistics.BackColor = Color.FromArgb(236, 220, 171);
            openChildForm(new C_SpeechRecognition.Bob());
            PnlNav.Height = btnDashboard.Height;
            PnlNav.Top = btnDashboard.Top;
            PnlNav.Left = btnDashboard.Left;
            PnlNav.Visible = true;
            btnDashboard.BackColor = Color.FromArgb(215, 201, 153);
        }

        private void btnDashboard_Leave(object sender, EventArgs e)
        {
            btnDashboard.BackColor = Color.FromArgb(236, 220, 171);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void openChildForm(Form form)
        {

            if (activeForm != null)
                activeForm.Close();

            activeForm = form;

            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            childFormPanel.Controls.Add(form);
            childFormPanel.Tag = form;
            form.BringToFront();
            form.Show();
        }
    }
}
