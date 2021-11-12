using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project_Work_Space
{
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }



        private void txtRefFrequency_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbNewRefill_Click(object sender, EventArgs e)
        {

        }

        private void tbNewClient_Click(object sender, EventArgs e)
        {
            btnEmployeeSave.Enabled = false;
        }

        private void txtEmployeeLname_TextChanged(object sender, EventArgs e)
        {
            if ((txtEmployeeLname.Text.Trim().Length > 0) && (txtEmployeeFname.Text.Trim().Length > 0)) //enable
            {
                btnEmployeeSave.Enabled = true;
            }

            else
            {
                btnEmployeeSave.Enabled = false;
                //disable buttons
            }
        }

        private void txtEmployeeAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmployeeFname_TextChanged(object sender, EventArgs e)
        {
            if ((txtEmployeeLname.Text.Trim().Length > 0) && (txtEmployeeFname.Text.Trim().Length > 0)) //enable
            {
                btnEmployeeSave.Enabled = true;

            }
            else
            {
                btnEmployeeSave.Enabled = false;
                //disable buttons
            }
        }



        private void txtEmployeeGender_TextChanged(object sender, EventArgs e)
        {
            /*  if (txtEmployeeGender.Text.Trim().Length > 0)  //enable
              {
                  btnEmployeeSave.Enabled = true;

              }
              else if ((txtEmployeeFname.Text.Trim().Length > 0) && (txtEmployeeGender.Text.Trim().Length > 0))
              {
                  btnEmployeeSave.Enabled = true;

              }

              else
              {
                  btnEmployeeSave.Enabled = false;
                  //disable buttons
            */
        }


            private void Employee_Load(object sender, EventArgs e)
        {
            btnEmployeeSave.Enabled = false;
        }
    }
    }




