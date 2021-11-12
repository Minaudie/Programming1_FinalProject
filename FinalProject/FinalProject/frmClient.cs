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
    public partial class Client : Form
    {
        

        public Client()
        {
            InitializeComponent();
        }

        private void lblLandingWelcome_Click(object sender, EventArgs e)
        {

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
    }
    }
    


        ///change username: change client username
        ///change password: change client password
        ///update button -> add new password to password table and new username to username table

        ///cancel the operation / close the current form

    

