using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CSharp_MySQL_Insert
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxGender.SelectedIndex = 0;
            txtBoxFName.Select();
        }

        string connectionString = "host=192.168.0.91; database=c#1; user=test1; password=test1";
        private void btnMySQLConnect_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                        string query = "SELECT VERSION()";
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        string version = Convert.ToString(cmd.ExecuteScalar());
                        //Console.WriteLine("MySQL version : {0}", version);
                        MessageBox.Show("Connection Established!\n" + "MySQL Version: " + version, "Message",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //label1.Text = "Connection Established!\n" + "MySQL Version: " + version;
                    }
                    else
                    {
                        MessageBox.Show("Connection Already Open.", "Message",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Connection Error!\n" + ex.Message, "Message",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //label1.Text = "Connection Error!\n" + ex.Message;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    string FName = txtBoxFName.Text;
                    string LName = txtBoxLName.Text;
                    if (FName == "" || LName == "")
                    {
                        MessageBox.Show("Empty Fields Detected ! Please fill up all the fields");
                        return;
                    }
                    if (conn.State == ConnectionState.Closed)
                        conn.Open();
                        using (MySqlCommand cmd = new MySqlCommand("INSERT INTO `student` (`First Name`, `Last Name`, `Email`, `Mobile`, `Course`, `Gender`) VALUES ('"+txtBoxFName.Text.Trim()+"','"+txtBoxLName.Text.Trim()+ "','"+txtBoxEmail.Text.Trim()+ "','"+txtBoxMobile.Text.Trim()+ "','"+txtBoxCourse.Text.Trim() + "','"+comboBoxGender.Text+"')", conn))

                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Record Added Successfuly.", "Information Message",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtBoxFName.Text = txtBoxLName.Text = txtBoxEmail.Text = txtBoxMobile.Text
                = txtBoxCourse.Text = string.Empty;
                        comboBoxGender.SelectedIndex = 0;
                        txtBoxFName.Select();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtBoxFName.Text = txtBoxLName.Text = txtBoxEmail.Text = txtBoxMobile.Text
                = txtBoxCourse.Text = string.Empty;
            comboBoxGender.SelectedIndex = 0;
        }


    }
}
