using FontAwesome.Sharp;
using GameLauncher.Forms;
using GameLauncher.Forms.PanelForms;
using System.Runtime.InteropServices;
using System.Diagnostics;
using GameLauncher.Forms.Login_Form;
using System.Runtime.CompilerServices;
using System.Windows.Documents;
using static System.Net.Mime.MediaTypeNames;
using Application = System.Windows.Forms.Application;
using System.Windows.Forms;

namespace GameLauncher
{
    public partial class FormMainMenu : Form
    {

        //Performance Counter
        PerformanceCounter perfCPUCounter = new PerformanceCounter("Processor Information", "% Processor Time", "_Total");
        PerformanceCounter perfMemCounter = new PerformanceCounter("Memory", "Available MBytes");
        PerformanceCounter perfSystemCounter = new PerformanceCounter("System", "System Up Time");
        PerformanceCounter perfGPUCounter = new PerformanceCounter("GPU Engine", "Utilization Percentage", "pid_1732_luid_0x00000000_0x00011D4B_phys_0_eng_0_engtype_3D");

        //Find File
        private void FileSearch(string search)
        {
            var filePaths = Directory.EnumerateFiles(@"D:\Games\ACE\Assetto Corsa Evoluzione", search, new EnumerationOptions
            {
                IgnoreInaccessible = true,
                RecurseSubdirectories = true
            });

            ChromeLocation = filePaths.ToArray()[0].ToString();

        }

        //Misc Strings



        //file location stings
        private string ChromeLocation;
        private string RobloxLocation;



        //Fields
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;

        //Constructor
        public FormMainMenu()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);
            //Form
            panelDesktop.Visible = false;
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            LoadingGif.Visible = false;

        }
        private struct RGBColors
        {
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color6 = Color.FromArgb(24, 161, 251);
            public static Color color5 = Color.FromArgb(57, 255, 20);
            public static Color color7 = Color.FromArgb(255, 0, 0);
        }

        //Methods 
        private void ActiveButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(055, 055, 055);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left Border Button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //Icon Current Form
                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = color;
            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(0, 0, 0);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void OpenChildForm(Form childForm)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
                panelDesktop.Visible = false;
            }
            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitleChildForm.Text = childForm.Text;
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color7);
            OpenChildForm(new FormAllGames());
            LoadingGif.Visible = true;
            LoadingBackPanel.Visible = true;
            panelDesktop.Visible = true;
            panelDesktop.BringToFront();
            LoadingBackPanel.BringToFront();
            LoadingGif.BringToFront();
            LoadingTimer.Stop();
            LoadingTimer.Start();

        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color6);
            OpenChildForm(new FormSteamGames());
            LoadingGif.Visible = true;
            LoadingBackPanel.Visible = true;
            panelDesktop.Visible = true;
            panelDesktop.BringToFront();
            LoadingBackPanel.BringToFront();
            LoadingGif.BringToFront();
            LoadingTimer.Stop();
            LoadingTimer.Start();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color4);
            OpenChildForm(new FormEpicGames());
            LoadingGif.Visible = true;
            LoadingBackPanel.Visible = true;
            panelDesktop.Visible = true;
            panelDesktop.BringToFront();
            LoadingBackPanel.BringToFront();
            LoadingGif.BringToFront();
            LoadingTimer.Stop();
            LoadingTimer.Start();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
        }

        private void btnMarketing_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color6);
            OpenChildForm(new FormEAGames());
            LoadingGif.Visible = true;
            LoadingBackPanel.Visible = true;
            panelDesktop.Visible = true;
            panelDesktop.BringToFront();
            LoadingBackPanel.BringToFront();
            LoadingGif.BringToFront();
            LoadingTimer.Stop();
            LoadingTimer.Start();
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color4);
            OpenChildForm(new FormMusic());
            LoadingGif.Visible = true;
            LoadingBackPanel.Visible = true;
            panelDesktop.Visible = true;
            panelDesktop.BringToFront();
            LoadingBackPanel.BringToFront();
            LoadingGif.BringToFront();
            LoadingTimer.Stop();
            LoadingTimer.Start();
        }

        private void iconButton1_Click_2(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color7);
            OpenChildForm(new FormPerformance());
            LoadingGif.Visible = true;
            LoadingBackPanel.Visible = true;
            panelDesktop.Visible = true;
            panelDesktop.BringToFront();
            LoadingBackPanel.BringToFront();
            LoadingGif.BringToFront();
            LoadingTimer.Stop();
            LoadingTimer.Start();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            currentChildForm.Close();
            reset();
            panelDesktop.Visible = false;
        }

        private void btnMusicPanel_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color5);
            OpenChildForm(new FormMusic2());
            LoadingGif.Visible = true;
            LoadingBackPanel.Visible = true;
            panelDesktop.Visible = true;
            panelDesktop.BringToFront();
            LoadingBackPanel.BringToFront();
            LoadingGif.BringToFront();
            LoadingTimer.Stop();
            LoadingTimer.Start();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color7);
            OpenChildForm(new FormSettings());
            LoadingGif.Visible = true;
            LoadingBackPanel.Visible = true;
            panelDesktop.Visible = true;
            panelDesktop.BringToFront();
            LoadingBackPanel.BringToFront();
            LoadingGif.BringToFront();
            LoadingTimer.Stop();
            LoadingTimer.Start();
        }

        private void reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.White;
            lblTitleChildForm.Text = "Home";
        }

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        private void iconCurrentChildForm_Click(object sender, EventArgs e)
        {

        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            labelTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            labelDate.Text = DateTime.Now.ToString("dddd d MMMM yyyy");
        }

        //Minimize, Maximize, Close
        private void btnExit2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnMaximise_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void FormMainMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnExit2_MouseHover(object sender, EventArgs e)
        {
            btnExit2.BackColor = Color.FromArgb(125, 0, 0);
        }

        private void btnExit2_MouseLeave(object sender, EventArgs e)
        {
            btnExit2.BackColor = Color.Transparent;
        }

        private void panelDesktop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnPerformance_MouseEnter(object sender, EventArgs e)
        {

        }

        private void LoadingTimer_Tick(object sender, EventArgs e)
        {
            LoadingGif.Visible = false;
        }

        //
        //Games 
        //

        //Roblox
        private void button1_Click(object sender, EventArgs e)
        {
            notifyIcon1.Icon = new System.Drawing.Icon(Path.GetFullPath("Small Logo.ico"));
            notifyIcon1.Text = "Now Launching: Chrome";
            notifyIcon1.Visible = true;
            notifyIcon1.BalloonTipTitle = "Now Launching: Chrome \nPlease allow sometime for loading";
            notifyIcon1.BalloonTipText = "Click Here to return to Game Launcher";
            notifyIcon1.ShowBalloonTip(100);
            notifyIcon1.BalloonTipClicked += NotifyIcon1_BalloonTipClicked;

            FileSearch("chrome.exe");
            Process.Start(ChromeLocation);
        }
        private void NotifyIcon1_BalloonTipClicked(Object sender, EventArgs e)
        {

            this.Activate();
            this.Show();
            this.BringToFront();
        }



        private void btnLogOut_Click(object sender, EventArgs e)
        {
            new FormLogin().Show();
            this.Hide();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}