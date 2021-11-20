using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class frmClient : Form
    {
        public static string loggedInUser;

        public frmClient()
        {
            InitializeComponent();
        }

        private void frmClient_Load(object sender, EventArgs e)
        {
            btnClientUpdate.Enabled = false;
        }

        private void CheckTextBoxes()
        {
            if ((txtClientUsername.Text.Trim().Length > 0) && (txtClientPassword.Text.Trim().Length > 0))
            {
                btnClientUpdate.Enabled = true;
            }
            else
            {
                btnClientUpdate.Enabled = false;
            }
        }

        private void txtClientUsername_TextChanged(object sender, EventArgs e)
        {
            CheckTextBoxes();
        }

        private void txtClientPassword_TextChanged(object sender, EventArgs e)
        {
            CheckTextBoxes();
        }

        private void btnClientCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClientUpdate_Click(object sender, EventArgs e)
        {
            byte[] salt = Utilities.Get_SALT();
            string username;
            string password;
            int clientid;

            try
            {
                username = txtClientUsername.Text.Trim();
                password = txtClientPassword.Text.Trim();

                DatabaseConnections dc = new DatabaseConnections();
                DataSet ds = new DataSet();

                //username logged in with
                ds = dc.ReturnClientIDByUsername(loggedInUser);
                clientid = (int)ds.Tables[0].Rows[0]["clientID"];

                string myval = Utilities.SaltKey;
                var hash = Utilities.Get_HASH_SHA512(password, salt);

                dc.UpdateClientLogin(clientid, username, hash, hash, Utilities.SaltKey);

                MessageBox.Show("Username/Password updated successfully!", "Update Successful", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }
        }
    }
}