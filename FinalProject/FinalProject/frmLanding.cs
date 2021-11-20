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
//using Final_Project_Work_Space;

namespace FinalProject
{
    public partial class frmLanding : Form
    {
        public frmLanding()
        {
            InitializeComponent();
        }

        private void Landing_Load(object sender, EventArgs e)
        {
            btnLandingLogin.Enabled = false;
            ClearTextBoxes();
        }

        private void ClearTextBoxes()
        {
            txtLandingPassword.Clear();
            txtLandingUsername.Clear();
        }

        private void CheckTextBoxes()
        {
            if (txtLandingUsername.Text.Trim().Length > 0 && txtLandingPassword.Text.Trim().Length > 0)
            {
                btnLandingLogin.Enabled = true;
            }
            else
            {
                btnLandingLogin.Enabled = false;
            }
        }

        private void txtLandingUsername_TextChanged(object sender, EventArgs e)
        {
            CheckTextBoxes();
        }

        private void txtLandingPassword_TextChanged(object sender, EventArgs e)
        {
            CheckTextBoxes();
        }

        private void lnkLandingNewClient_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmRegister frm = new frmRegister();
            frm.Show();
        }

        private void btnLandingLogin_Click(object sender, EventArgs e)
        {
            string username = "";
            string password = "";

            try
            {
                username = txtLandingUsername.Text.Trim();
                password = txtLandingPassword.Text.Trim();

                DatabaseConnections dc = new DatabaseConnections();
                DataSet ds = new DataSet();
                ds = dc.GetLoginInfo(username);

                if(ds.Tables[0].Rows.Count > 0)
                {
                    var val = ds.Tables[0].Rows[0]["salt"].ToString();
                    var myval = Utilities.returnSaltBytes(val);
                    var hash = Utilities.Return_HASH_SHA512(password, myval);

                    bool isVerified = ds.Tables[0].Rows[0]["userPassword"].ToString().Equals(hash);

                    if(isVerified)
                    {
                        //successful login
                        //find if employee or client
                        int user = dc.FindUsername(username);

                        if(user == 1) //client
                        {
                            frmClient frmClient = new frmClient();
                            frmClient.loggedInUser = username;

                            ClearTextBoxes();
                            frmClient.ShowDialog();

                        } else if(user == 2) //2, employee
                        {
                            ClearTextBoxes();
                            frmEmployee frmEmp = new frmEmployee();
                            frmEmp.ShowDialog();

                        } else
                        {
                            MessageBox.Show("Unknown Username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        
                    } else //not verified
                    {
                        MessageBox.Show("Invalid login", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }
        }
    }
}