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
            txtBoxFName.Select();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    using (MySqlCommand cmd = new MySqlCommand("", conn))
                    {

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
            txtBoxFName.Text = txtBoxLName.Text = txtBoxEmail.Text = string.Empty;
        }

        
    }
}
