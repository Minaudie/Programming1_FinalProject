using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinalProject;

namespace Programming1_FinalProject
{
    public partial class Client : Form
    {
        

        public Client()
        {
            InitializeComponent();
        }

        private void Client_Load(object sender, EventArgs e) //disable update button on loading
        {
            btnClientUpdate.Enabled = false;
        }

        private void txtClientUsername_TextChanged(object sender, EventArgs e)
        {
             if ((txtClientUsername.Text.Trim().Length > 0) && (txtClientPassword.Text.Trim().Length > 0))
            {
                btnClientUpdate.Enabled = true;
                //enable buttons if value is assigned

            }
            else
            {
                btnClientUpdate.Enabled = false;
                //disable buttons
            }
        }

        private void txtClientPassword_TextChanged(object sender, EventArgs e)
        {
            if ((txtClientUsername.Text.Trim().Length > 0) && (txtClientPassword.Text.Trim().Length > 0))
            {
                btnClientUpdate.Enabled = true;
                //enable buttons if value is assigned

            }
            else
            {
                btnClientUpdate.Enabled = false;
                //disable buttons
            }
        }

        private void btnClientCancel_Click(object sender, EventArgs e)
        {
            //currnetly has no assigned function
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
                ds = dc.ReturnClientIDByUsername(username);
                clientid = int.Parse(ds.Tables[0].Rows[0]["clientID"].ToString());

                string myval = Utilities.SaltKey;
                var hash = Utilities.Get_HASH_SHA512(password, salt);

                dc.UpdateClientLogin(clientid, username, hash, hash, Utilities.SaltKey);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }
        }
    }
}