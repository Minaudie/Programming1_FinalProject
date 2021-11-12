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
    public partial class Landing : Form
    {
        public Landing()
        {
            InitializeComponent();
        }

        private void txtLandingUsername_TextChanged(object sender, EventArgs e)
        {

            if ((txtLandingUsername.Text.Trim().Length > 0) && (txtLandingPassword.Text.Trim().Length > 0))
            {
                btnLandingLogin.Enabled = true;

            }
            else
            {
                btnLandingLogin.Enabled = false;
                //disable buttons
            }
        }

        private void txtLandingPassword_TextChanged(object sender, EventArgs e)
        {

            if ((txtLandingPassword.Text.Trim().Length > 0) && (txtLandingUsername.Text.Trim().Length > 0))
            {
                btnLandingLogin.Enabled = true;

            }
            else
            {
                btnLandingLogin.Enabled = false;
                //disable buttons
            }
        }

        private void lblLandingWelcome_Click(object sender, EventArgs e)
        {

        }

        private void Landing_Load(object sender, EventArgs e)
        {
            btnLandingLogin.Enabled = false;
        }
    }

        ///login button
        ///check for username: client or employee
        ///check password in relevant table
        ///allow login
        ///client -> client form
        ///employee -> employee form

        ///new client registration link
        ///send to register form
    }


