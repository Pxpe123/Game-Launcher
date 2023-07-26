using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace GameLauncher.Forms.Login_Form
{
    public partial class FormLogin : Form
    {
        public object GlobalClass { get; private set; }

        public FormLogin()
        {
            InitializeComponent();
        }
        //Database

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnExit2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnExit2_MouseHover_1(object sender, EventArgs e)
        {
            btnExit2.BackColor = Color.FromArgb(125, 0, 0);
        }

        private void btnExit2_MouseLeave_1(object sender, EventArgs e)
        {
            btnExit2.BackColor = Color.Transparent;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            new frmRegister().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jayden\source\repos\GameLauncher\GameLauncher\LoginDatabaseSystem.mdf;Integrated Security=True");
            SqlDataAdapter lda = new SqlDataAdapter("Select Count (*) From LoginTable where Username = '" + txtUsername.Text + "'and Password= '" + txtPassword.Text + "'", con);
            DataTable dt = new DataTable();
            lda.Fill(dt);


            if (dt.Rows[0][0].ToString() == "1")
            {
                MessageBox.Show("Login Success, Please wait for menu to load!", "Login Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                new FormMainMenu().Show();
                this.Hide();
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Invalid Username Or Password,Do you want to Try Again", "Login Failed", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (dialogResult == DialogResult.Yes)
                {
                    txtUsername.Text = "";
                    txtPassword.Text = "";
                    txtUsername.Focus();
                }
                else if (dialogResult == DialogResult.No)
                {
                    Application.Exit();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtUsername.Focus();
        }

        private void CheckbxShowPas_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckbxShowPas.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '•';
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
