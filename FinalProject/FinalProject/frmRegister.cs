using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming1_FinalProject
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e) //disable button on form load
        {
            btnRegisterRegister.Enabled = false;
        }

        private void txtRegisterUsername_TextChanged(object sender, EventArgs e) //disable button unless values in fields
        {

            if ((txtRegisterUsername.Text.Trim().Length > 0) && (txtRegisterPassword.Text.Trim().Length > 0))
            {
                btnRegisterRegister.Enabled = true;

            }
            else
            {
                btnRegisterRegister.Enabled = false;
                //disable buttons
            }
        }

        private void txtRegisterPassword_TextChanged(object sender, EventArgs e) //disable button unless values in fields
        {
            if ((txtRegisterPassword.Text.Trim().Length > 0) && (txtRegisterUsername.Text.Trim().Length > 0))
            {
                btnRegisterRegister.Enabled = true;

            }

            else if ((txtRegisterPassword.Text.Trim().Length > 0) && (txtRegisterUsername.Text.Trim().Length > 0))
            {
                btnRegisterRegister.Enabled = true;
            }
            else
            {
                btnRegisterRegister.Enabled = false;
                //disable buttons
            }
        }


        private void txtRegisterClientID_TextChanged(object sender, EventArgs e)
        {
            if ((txtRegisterClientID.Text.Trim().Length > 0) && (txtRegisterUsername.Text.Trim().Length > 0))

            {
                btnRegisterRegister.Enabled = true;

            }
            else
            {
                btnRegisterRegister.Enabled = false;
                //disable buttons
            }
        }

        private void btnRegisterCancel_Click(object sender, EventArgs e)
        {

            //subForm myNewForm = new subForm();

            this.Visible = false;
        }

        private void btnRegisterRegister_Click(object sender, EventArgs e)
        {
            string clientid = "";
            string clientUsername = "";
            string clientPassword = "";
      

            try
            {
             //   DatabaseConnections NewClientDS = new DatabaseConnections();

                clientid = txtRegisterClientID.Text.Trim();
                clientUsername = txtRegisterUsername.Text.Trim();
                clientPassword = txtRegisterPassword.Text.Trim();
             


              //DatabaseConnections.RegisterNew(clientid, clientUsername, clientPassword);

                //doesnt work
                //frmsearch.dgvStudents.Refresh();

               //frmsearch.btnSearch_Click(sender, e);

                //close form
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }
        }
    }
}

        //this.Hide();


    

///register username: register client username
///register password: register client password
///register button -> add new password to client table and new username to client table

///cancel the operation / close the current form