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
using Microsoft.VisualBasic.Logging;

namespace GameLauncher.Forms.Login_Form
{
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }

        //Database


        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnExit2_MouseHover(object sender, EventArgs e)
        {
            btnExit2.BackColor = Color.FromArgb(125, 0, 0);
        }

        private void btnExit2_MouseLeave(object sender, EventArgs e)
        {
            btnExit2.BackColor = Color.Transparent;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (txtUsername.Text == "" && txtPassword.Text == "")
            { 
                MessageBox.Show("Please do not leave Username or Password Black", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Text = "";
                txtPassword.Text = "";
                txtComPassword.Text = "";
                txtUsername.Focus();
            }

            else if (txtComPassword.Text != txtPassword.Text)
            {
                MessageBox.Show("Passwords do not match, Please try again", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Text = "";
                txtPassword.Text = "";
                txtComPassword.Text = "";
                txtUsername.Focus();
            }

            else if (txtUsername.Text != "" && txtPassword.Text != "" && txtPassword.Text == txtComPassword.Text)
            {
               try
               {
                    //Checking if exsists
                    SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jayden\source\repos\GameLauncher\GameLauncher\LoginDatabaseSystem.mdf;Integrated Security=True");
                    SqlDataAdapter lda = new SqlDataAdapter("Select Count (*) From LoginTable where Username = '" + txtUsername.Text + "'", con);
                    DataTable dt = new DataTable();
                    lda.Fill(dt);

                    //Inserting New
                    string InsertQuey = "Insert into LoginTable(Username,Password)Values('" + txtUsername.Text + "','" + txtPassword.Text + "')";
                    con.Open();
                    SqlCommand cmd = new SqlCommand(InsertQuey, con);
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Registration Success", "Please Login!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    new FormLogin().Show();
                    this.Hide();

               }
               catch (SqlException PK__LoginTab__536C85E5E331872E)
               {
                   MessageBox.Show("Login Failed! \nUsername = " + txtUsername.Text + " Already exists \nPlease Try Again", "Login Failed!", MessageBoxButtons.OK, MessageBoxIcon.Information);
               }
            }
        }

        private void CheckbxShowPas_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckbxShowPas.Checked) 
            {
                txtPassword.PasswordChar = '\0';
                txtComPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '•';
                txtComPassword.PasswordChar = '•';
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtComPassword.Text = "";
            txtUsername.Focus();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            new FormLogin().Show();
            this.Hide();
        }

        private void btnExit2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmRegister_MouseHover(object sender, EventArgs e)
        {

        }

        private void frmRegister_MouseLeave(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
