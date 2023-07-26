using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Application = System.Windows.Forms.Application;
using GameLauncher.Systems.GamesFinder;
using System.IO;

namespace GameLauncher.Forms
{
    public partial class FormAllGames : Form
    {

        //Misc Strings
        private int x; //Text color change on click :)
        private int y; //Text color resets after 5Seconds :)

        public FormAllGames()
        {
            InitializeComponent();

            tableLayoutPanel.VerticalScroll.Enabled = true;
            tableLayoutPanel.HorizontalScroll.Enabled = false;

            var context = SynchronizationContext.Current;
            ThreadPool.QueueUserWorkItem(LoadGames, context);
        }

        // Find the installed games and create buttons for them
        private void LoadGames(object? state)
        {
            var context = (SynchronizationContext)state;
            CommonFinder.FindGames(CreateGameButtons);
        }

        void CreateGames(object? state)
        {
            List<Game> detectedGames = (List<Game>)state;

            CreateGameButtons(detectedGames);
        }

        private void FormAllGames_Load(object sender, EventArgs e)
        {

        }

        private void NotifyIcon1_BalloonTipClicked(Object sender, EventArgs e)
        {

            this.Activate();
            this.Show();
            this.BringToFront();
        }

        //private void button1_Click_1(object sender, EventArgs e)
        //{
        //    {
        //        button1.ForeColor = Color.FromArgb(0,255,0);
        //        button1.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 0);
        //        timer1.Stop();
        //        timer1.Start();
        //        while (x == 1)
        //        {
        //            notifyIcon1.Icon = new System.Drawing.Icon(Path.GetFullPath("Small Logo.ico"));
        //            notifyIcon1.Text = "Now Launching: Chrome";
        //            notifyIcon1.Visible = true;
        //            notifyIcon1.BalloonTipTitle = "Now Launching: Chrome \nPlease allow sometime for loading";
        //            notifyIcon1.BalloonTipText = "Click Here to return to Game Launcher";
        //            notifyIcon1.ShowBalloonTip(100);
        //            notifyIcon1.BalloonTipClicked += NotifyIcon1_BalloonTipClicked;
        //
        //            timer1.Stop();
        //            x = 0;
        //        }
        //        timer2.Stop();
        //        timer2.Start();
        //        while(y == 1)
        //        {
        //            button1.ForeColor = Color.FromArgb(255, 255, 255);
        //            button1.FlatAppearance.BorderColor = Color.FromArgb(255, 255, 255);
        //            y = 0;
        //            timer2.Stop();
        //        }
        //
        //    }
        //}

        private void iconButton1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            x = 1;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            y = 1;
        }

        private void GameChoiceCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CreateGameButtons(List<Game> games)
        {
            // Define the column widths for the table layout panel
            //tableLayoutPanel.ColumnCount = 4;
            //tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 234));
            //tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 97));
            //tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 97));
            //tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 97));

            
            // Create a button for each game and add it to the table layout panel
            int col = 0;
            int row = 0;
            foreach (Game game in games)
            {
                // Create the launch button for the game
                Button launchButton = new Button
                {
                    Text = "Launch " + game.name,
                    Tag = game.directory,  // Store the game directory in the button tag
                    Dock = DockStyle.Fill,
                    ForeColor = Color.White
                };
                launchButton.Text = "Launch " + game.name;
                launchButton.Tag = game; // Set the button's Tag property to the game object
                launchButton.Click += LaunchButton_Click;


                // Add the controls to the table layout panel on the UI thread
                Invoke(new Action(() =>
                {
                    if (col >= 4)
                    {
                        row++;
                        col = 0;

                        if (row > 4)
                        {
                            // Create a new row for the game button
                            tableLayoutPanel.RowCount++;
                            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 97));
                        }
                    }
                    tableLayoutPanel.Controls.Add(launchButton, col++, row);
                }));
            }
        }

        private void LaunchButton_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            Game game = button.Tag as Game;

            if (game != null)
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = Path.Combine(game.directory, game.name + ".exe"),
                    WorkingDirectory = game.directory,
                    UseShellExecute = true
                });

            }

        }

        private async void siticoneButton1_Click(object sender, EventArgs e)
        {
            using (var folderDialog = new FolderBrowserDialog())
            {
                DialogResult result = folderDialog.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderDialog.SelectedPath))
                {
                    string selectedDirectory = folderDialog.SelectedPath;

                    // Write selected directory to the "1231.dat" file
                    string fileName = "1231.dat";
                    string filePath = Path.Combine(Application.StartupPath, fileName);

                    using (StreamWriter writer = new StreamWriter(filePath, true))
                    {
                        writer.WriteLine(selectedDirectory);
                    }
                    List<string> directories = new List<string> { selectedDirectory };
                }
            }
        }

        private void tableLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void siticoneButton2_Click(object sender, EventArgs e)
        {
            string customGameDirectoriesFile = "1231.dat";
            File.Delete(customGameDirectoriesFile);
        }
    }
}