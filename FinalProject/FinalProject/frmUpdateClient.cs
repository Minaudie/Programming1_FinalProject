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
    public partial class frmUpdateClient : Form
    {
        private frmEmployee frmEmployee;

        public frmUpdateClient(frmEmployee emp)
        {
            InitializeComponent();
            frmEmployee = emp;
        }

        private void frmUpdateClient_Load(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = new DataSet();
                DatabaseConnections ucf = new DatabaseConnections();
                //clientID
                ds = ucf.GetClientByID(int.Parse(frmEmployee.g_clientID.ToString()));
                if (ds.Tables[0].Rows.Count > 0)
                {
                    txtUpdateClientID.Text = ds.Tables[0].Rows[0]["clientID"].ToString();
                    txtUpdateClientID.Enabled = false;
                    txtUpdateClientFName.Text = ds.Tables[0].Rows[0]["fName"].ToString();
                    txtUpdateClientMidInt.Text = ds.Tables[0].Rows[0]["mInitial"].ToString();
                    txtUpdateClientLName.Text = ds.Tables[0].Rows[0]["lName"].ToString();
                    txtUpdateClientAddress.Text = ds.Tables[0].Rows[0]["street1"].ToString();
                    txtUpdateClientAdd2.Text = ds.Tables[0].Rows[0]["street2"].ToString();
                    txtUpdateClientCity.Text = ds.Tables[0].Rows[0]["city"].ToString();
                    txtUpdateClientState.Text = ds.Tables[0].Rows[0]["addr_state"].ToString();
                    txtUpdateClientZip.Text = ds.Tables[0].Rows[0]["zip"].ToString();
                    txtUpdateClientPhone.Text = ds.Tables[0].Rows[0]["phone"].ToString();
                    txtUpdateClientEmail.Text = ds.Tables[0].Rows[0]["email"].ToString();
                    txtUpdateClientGender.Text = ds.Tables[0].Rows[0]["gender"].ToString();
                    txtUpdateClientDOB.Text = ds.Tables[0].Rows[0]["dateOfBirth"].ToString();
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }

        private void btnUpdateClientUpdate_Click(object sender, EventArgs e)
        {
            int clientid; 
            string fname, minit, lname, add1, add2, city, state, zip, phone, email, gender, dob;

            try
            {
                DatabaseConnections dc = new DatabaseConnections();

                clientid = int.Parse(txtUpdateClientID.Text.Trim());
                fname = txtUpdateClientFName.Text.Trim();
                minit = txtUpdateClientMidInt.Text.Trim();
                lname = txtUpdateClientLName.Text.Trim();
                add1 = txtUpdateClientAddress.Text.Trim();
                add2 = txtUpdateClientAdd2.Text.Trim();
                city = txtUpdateClientCity.Text.Trim();
                state = txtUpdateClientState.Text.Trim();
                zip = txtUpdateClientZip.Text.Trim();
                phone = txtUpdateClientPhone.Text.Trim();
                email = txtUpdateClientEmail.Text.Trim();
                gender = txtUpdateClientGender.Text.Trim();
                dob = txtUpdateClientDOB.Text.Trim();

                dc.UpdateClient(clientid, fname, minit, lname, add1, add2, city, state,
                    zip, phone, email, gender, dob);

                MessageBox.Show("Client record updated successfully.", "Record Updated", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                //update dgv on frmEmployee search tab
                DataSet ds = new DataSet();
                ds = dc.GetClientByID(clientid);
                frmEmployee.dgvClient.DataSource = ds.Tables[0];

                this.Close();

            } catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }

        private void btnUpdateClientClear_Click(object sender, EventArgs e)
        {
            
        }
    }
}
