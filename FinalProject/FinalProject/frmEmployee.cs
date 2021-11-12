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

        private void btnCliClear_Click(object sender, EventArgs e)
        {
            txtCliFname.Text = "";
            txtCliLname.Text = "";
            txtCliAddress.Text = "";
            txtCliCity.Text = "";
            txtCliState.Text = "";
            txtCliZip.Text = "";
            txtCliPhone.Text = "";
            txtCliEmail.Text = "";
            txtCliAddress2.Text = "";
            txtCliMidInt.Text = "";
            rdoCliMale.Checked = false;
            rdoCliFemale.Checked = false;
            
            ///Need Somthing for combo box yet

        }

        private void btnPhyClear_Click(object sender, EventArgs e)
        {
            txtPhyFname.Text = "";
            txtPhyMidInt.Text = "";
            txtPhyLname.Text = "";
            txtPhyPhone.Text = "";
            txtPhyEmail.Text = "";

        }

        private void btnPerClear_Click(object sender, EventArgs e)
        {
            txtPerClientID.Text = "";
            txtPerPhysicanID.Text = "";
            txtPerMedicationID.Text = "";
            txtPerNumOfRefills.Text = "";

                
        }

        private void btnRefCle_Click(object sender, EventArgs e)
        {
            txtRefPerscriptionID.Text = "";
            txtRefDosage.Text = "";
            txtRefFrequency.Text= "";
            txtRefSupplyDays.Text = "";
            txtRefQuantitySupplied.Text = "";
            txtRefPrice.Text = "";
            txtRefRefillID.Text = "";
           /// need to clear payment type


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
