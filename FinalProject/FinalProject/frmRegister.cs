using FinalProject;
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
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }

        //disable button on form load
        private void Register_Load(object sender, EventArgs e) 
        {
            btnRegisterRegister.Enabled = false;
        }

        private void checkFields()
        {
            if (txtRegisterUsername.Text.Trim().Length > 0 && txtRegisterPassword.Text.Trim().Length > 0
                && txtRegisterClientID.Text.Trim().Length > 0)
            {
                btnRegisterRegister.Enabled = true;
            }
            else
            {
                btnRegisterRegister.Enabled = false;
            }
        }

        //disable button unless values in fields
        private void txtRegisterUsername_TextChanged(object sender, EventArgs e) 
        {
            checkFields();            
        }

        //disable button unless values in fields
        private void txtRegisterPassword_TextChanged(object sender, EventArgs e) 
        {
            checkFields();
        }


        private void txtRegisterClientID_TextChanged(object sender, EventArgs e)
        {
            checkFields();
        }

        private void btnRegisterCancel_Click(object sender, EventArgs e)
        {

            //subForm myNewForm = new subForm();

            //this.Visible = false;

            this.Close();
        }

        private void btnRegisterRegister_Click(object sender, EventArgs e)
        {
            byte[] salt = Utilities.Get_SALT();
            int clientid;
            int myResult;
            string clientUsername = "";
            string clientPassword = "";

            try
            {
                clientid = int.Parse(txtRegisterClientID.Text.Trim());
                clientUsername = txtRegisterUsername.Text.Trim();
                clientPassword = txtRegisterPassword.Text.Trim();

                //create hash
                string myval = Utilities.SaltKey;
                var hash = Utilities.Get_HASH_SHA512(clientPassword, salt);

                DatabaseConnections dc = new DatabaseConnections();

                myResult = dc.NewClientRegistration(clientid, clientUsername, hash, hash, Utilities.SaltKey);

                Utilities.mySalt = new byte[0];

                if(myResult == -1)
                {
                    MessageBox.Show("Successfully created new user. Welcome.", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //close form
                    this.Close();

                } else //myResult == 1
                {
                    MessageBox.Show("Error: Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }
        }

        private void btnEmployeeCreate_Click(object sender, EventArgs e)
        {
            byte[] salt = Utilities.Get_SALT();
            int empID;
            int myResult;
            string empUsername = "";
            string empPassword = "";

            try
            {
                empID = int.Parse(txtRegisterClientID.Text.Trim());
                empUsername = txtRegisterUsername.Text.Trim();
                empPassword = txtRegisterPassword.Text.Trim();

                //create hash
                string myval = Utilities.SaltKey;
                var hash = Utilities.Get_HASH_SHA512(empPassword, salt);

                DatabaseConnections dc = new DatabaseConnections();

                myResult = dc.NewEmployeeRegistration(empID, empUsername, hash, hash, Utilities.SaltKey);

                Utilities.mySalt = new byte[0];

                if (myResult == -1)
                {
                    MessageBox.Show("Successfully created new employee. Welcome.", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //close form
                    this.Close();

                }
                else //myResult == 1
                {
                    MessageBox.Show("Error: Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }
        }
    }
}