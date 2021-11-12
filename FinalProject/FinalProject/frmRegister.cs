﻿using System;
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

        private void txtRegisterUsername_TextChanged(object sender, EventArgs e) //disable button unless values in fields
        {

            if ((txtRegisterUsername.Text.Trim().Length > 0) && (txtRegisterPassword.Text.Trim().Length > 0))
            {
                btnRegistrationRegister.Enabled = true;

            }
            else
            {
                btnRegistrationRegister.Enabled = false;
                //disable buttons
            }
        }

        private void txtRegisterPassword_TextChanged(object sender, EventArgs e) //disable button unless values in fields
        {
            if ((txtRegisterPassword.Text.Trim().Length > 0) && (txtRegisterUsername.Text.Trim().Length > 0))
            {
                btnRegistrationRegister.Enabled = true;

            }

            else if ((txtRegisterPassword.Text.Trim().Length > 0) && (txtRegisterUsername.Text.Trim().Length > 0))
            {
                btnRegistrationRegister.Enabled = true;
            }
            else
            {
                btnRegistrationRegister.Enabled = false;
                //disable buttons
            }
        }

        private void Register_Load(object sender, EventArgs e) //disable button on form load
        {
            btnRegistrationRegister.Enabled = false;
        }

        private void txtRegisterClientID_TextChanged(object sender, EventArgs e)
        {
            if ((txtRegisterClientID.Text.Trim().Length > 0) && (txtRegisterUsername.Text.Trim().Length > 0))

            {
                btnRegistrationRegister.Enabled = true;

            }
            else
            {
                btnRegistrationRegister.Enabled = false;
                //disable buttons
            }
        }
    }
}

///register username: register client username
///register password: register client password
///register button -> add new password to client table and new username to client table

///cancel the operation / close the current form