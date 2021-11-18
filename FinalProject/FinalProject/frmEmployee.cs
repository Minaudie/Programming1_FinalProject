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

namespace Final_Project_Work_Space
{
    public partial class Employee : Form
    {

        
        /*
           Required fields:
           Client
               txtClientFName, txtClientLName, txtClientDOB, txtClientGender
           Phys
               txtPhysFName, txtPhysLName
           Prescription
               txtPreClientID, txtPrePhysicianID, txtPreMedicationID
               dtpPreExpirationDate, txtPreNumOfRefills
           Refill
               txtRefPrescriptionID, txtRefDosage, txtRefFrequency, 
               txtRefSupplyDays, txtRefQuantitySupplied, txtRefPrice(idk about this one)
               txtRefPaymentType
       */
        private void addNewClient(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = new DataSet();
                DatabaseConnections ncf = new DatabaseConnections();

  

                if (ds.Tables[0].Rows.Count > 0)
                {
                    txtClientFName.Text = ds.Tables[0].Rows[0]["fName"].ToString();
                    txtClientMidInt.Text = ds.Tables[0].Rows[0]["mInitial"].ToString();
                    txtClientLName.Text = ds.Tables[0].Rows[0]["lName"].ToString();
                    txtClientAddress.Text = ds.Tables[0].Rows[0]["street1"].ToString();
                    txtClientAdd2.Text = ds.Tables[0].Rows[0]["street2"].ToString();
                    txtClientCity.Text = ds.Tables[0].Rows[0]["city"].ToString();
                    txtClientState.Text = ds.Tables[0].Rows[0]["state"].ToString();
                    txtClientZip.Text = ds.Tables[0].Rows[0]["zip"].ToString();
                    txtClientPhone.Text = ds.Tables[0].Rows[0]["phone"].ToString();
                    txtClientEmail.Text = ds.Tables[0].Rows[0]["email"].ToString();
                    txtClientGender.Text = ds.Tables[0].Rows[0]["gender"].ToString();
                    txtClientDOB.Text = ds.Tables[0].Rows[0]["dateOfBirth"].ToString();
                    txtClientUserName.Text = ds.Tables[0].Rows[0]["username"].ToString();
                    

                }

            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }
        private void addNewPhysician(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = new DataSet();
                DatabaseConnections ncf = new DatabaseConnections();



                if (ds.Tables[0].Rows.Count > 0)
                {
                    txtPhyFName.Text = ds.Tables[0].Rows[0]["fName"].ToString();
                    txtPhyMidInt.Text = ds.Tables[0].Rows[0]["mInitial"].ToString();
                    txtPhyLName.Text = ds.Tables[0].Rows[0]["lName"].ToString();
                    txtPhyPhone.Text = ds.Tables[0].Rows[0]["phone"].ToString();
                    txtPhyEmail.Text = ds.Tables[0].Rows[0]["email"].ToString();
             


                }

            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }
        private void addNewRefill(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = new DataSet();
                DatabaseConnections ncf = new DatabaseConnections();



                if (ds.Tables[0].Rows.Count > 0)
                {
                    txtRefDosage.Text = ds.Tables[0].Rows[0]["dosage"].ToString();
                    txtRefFrequency.Text = ds.Tables[0].Rows[0]["frequency"].ToString();
                    txtRefSupplyDays.Text = ds.Tables[0].Rows[0]["supplyDays"].ToString();
                    txtRefQuantitySupplied.Text = ds.Tables[0].Rows[0]["quantitySupplied"].ToString();
                    txtRefPrice.Text = ds.Tables[0].Rows[0]["amountDue"].ToString();
                    

                }

            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }

        public Employee()
        {
            InitializeComponent();
        }

        //overall form load
        private void Employee_Load(object sender, EventArgs e)
        {
            btnClientSave.Enabled = false;
        }

        /***     CLIENT TAB     ***/

        //returns true if all required fields are filled
        private Boolean CheckClientFields()
        {
            if (txtClientFName.Text.Trim().Length > 0 && txtClientLName.Text.Trim().Length > 0
                && txtClientGender.Text.Trim().Length > 0 && txtClientDOB.Text.Trim().Length > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //client tab load
        private void tbNewClient_Click(object sender, EventArgs e)
        {
            btnClientClear_Click(sender, e);
            btnClientSave.Enabled = false;
        }

        private void btnClientClear_Click(object sender, EventArgs e)
        {
            txtClientFName.Clear();
            txtClientLName.Clear();
            txtClientAddress.Clear();
            txtClientCity.Clear();
            txtClientState.Clear();
            txtClientZip.Clear();
            txtClientPhone.Clear();
            txtClientEmail.Clear();
            txtClientGender.Clear();
            txtClientDOB.Clear();
            txtClientInsurance.Clear();
        }

        private void btnClientSave_Click(object sender, EventArgs e)
        {

        }

        private void txtClientFName_TextChanged(object sender, EventArgs e)
        {
            if (CheckClientFields())
            {
                btnClientSave.Enabled = true;
            }
            else
            {
                btnClientSave.Enabled = false;
            }
        }

        private void txtClientLName_TextChanged(object sender, EventArgs e)
        {
            if (CheckClientFields())
            {
                btnClientSave.Enabled = true;
            }
            else
            {
                btnClientSave.Enabled = false;
            }
        }

        private void txtClientGender_TextChanged(object sender, EventArgs e)
        {
            if (CheckClientFields())
            {
                btnClientSave.Enabled = true;
            }
            else
            {
                btnClientSave.Enabled = false;
            }
        }

        private void txtClientDOB_TextChanged(object sender, EventArgs e)
        {
            if (CheckClientFields())
            {
                btnClientSave.Enabled = true;
            }
            else
            {
                btnClientSave.Enabled = false;
            }
        }

        /***     PHYSICIAN TAB     ***/

        private Boolean CheckPhyFields()
        {
            if(txtPhyFName.Text.Trim().Length > 0 && txtPhyLName.Text.Trim().Length > 0)
            {
                return true;
            } else
            {
                return false;
            }
        }

        //physician tab load
        private void tabNewPhysician_Click(object sender, EventArgs e)
        {
            btnPhyClear_Click(sender, e);
            btnPhySave.Enabled = false;
        }

        private void btnPhyClear_Click(object sender, EventArgs e)
        {
            txtPhyFName.Clear();
            txtPhyLName.Clear();
            txtPhyMidInt.Clear();
            txtPhyPhone.Clear();
            txtPhyEmail.Clear();
        }

        private void btnPhySave_Click(object sender, EventArgs e)
        {
            
        }

        private void txtPhyFName_TextChanged(object sender, EventArgs e)
        {
            if (CheckPhyFields())
            {
                btnPhySave.Enabled = true;
            }
            else
            {
                btnPhySave.Enabled = false;
            }
        }

        private void txtPhyLName_TextChanged(object sender, EventArgs e)
        {
            if (CheckPhyFields())
            {
                btnPhySave.Enabled = true;
            }
            else
            {
                btnPhySave.Enabled = false;
            }
        }

        /***     PRESCRIPTION TAB     ***/

        private Boolean CheckPreFields()
        {
            if(txtPreClientID.Text.Trim().Length > 0 && txtPrePhysicanID.Text.Trim().Length > 0
                && txtPreMedicationID.Text.Trim().Length > 0 && txtPreNumOfRefills.Text.Trim().Length > 0
                && dtpPreExpirationDate.Value != DateTime.Now)
            {
                return true;
            } else
            {
                return false;
            }
        }

        //prescription tab load
        private void tabNewPrescription_Click(object sender, EventArgs e)
        {
            btnPerClear_Click(sender, e);
            btnPreSave.Enabled = false;
        }

        private void btnPerClear_Click(object sender, EventArgs e)
        {
            txtPreClientID.Clear();
            txtPrePhysicanID.Clear();
            txtPreMedicationID.Clear();
            txtPreNumOfRefills.Clear();
            dtpPreExpirationDate.Value = DateTime.Now;
        }

        private void btnPerSave_Click(object sender, EventArgs e)
        {

        }

        private void txtPreClientID_TextChanged(object sender, EventArgs e)
        {
            if(CheckPreFields())
            {
                btnPreSave.Enabled = true;
            } else
            {
                btnPreSave.Enabled = false;
            }
        }

        private void txtPrePhysicanID_TextChanged(object sender, EventArgs e)
        {
            if (CheckPreFields())
            {
                btnPreSave.Enabled = true;
            }
            else
            {
                btnPreSave.Enabled = false;
            }
        }

        private void txtPreMedicationID_TextChanged(object sender, EventArgs e)
        {
            if (CheckPreFields())
            {
                btnPreSave.Enabled = true;
            }
            else
            {
                btnPreSave.Enabled = false;
            }
        }

        private void dtpPreExpirationDate_ValueChanged(object sender, EventArgs e)
        {
            if (CheckPreFields())
            {
                btnPreSave.Enabled = true;
            }
            else
            {
                btnPreSave.Enabled = false;
            }
        }
        private void txtPreNumOfRefills_TextChanged(object sender, EventArgs e)
        {
            if (CheckPreFields())
            {
                btnPreSave.Enabled = true;
            }
            else
            {
                btnPreSave.Enabled = false;
            }
        }

        /***     REFILL TAB     ***/

        private Boolean CheckRefillFields()
        {
            if(txtRefPrescriptionID.Text.Trim().Length > 0 && txtRefDosage.Text.Trim().Length > 0
                && txtRefFrequency.Text.Trim().Length > 0 && txtRefSupplyDays.Text.Trim().Length > 0
                && txtRefQuantitySupplied.Text.Trim().Length > 0 && txtRefPrice.Text.Trim().Length > 0
                && txtRefPaymentType.Text.Trim().Length > 0)
            {
                return true;
            } else
            {
                return false;
            }
        }

        //refill tab load
        private void tabNewRefill_Click(object sender, EventArgs e)
        {
            btnRefClear_Click(sender, e);
            btnRefSave.Enabled = false;
        }

        private void btnRefClear_Click(object sender, EventArgs e)
        {
            txtRefPrescriptionID.Clear();
            txtRefDosage.Clear();
            txtRefFrequency.Clear();
            txtRefSupplyDays.Clear();
            txtRefQuantitySupplied.Clear();
            txtRefPrice.Clear();
            txtRefPaymentType.SelectedIndex = -1;
        }

        private void btnRefSave_Click(object sender, EventArgs e)
        {

        }

        private void txtRefPrescriptionID_TextChanged(object sender, EventArgs e)
        {
            if(CheckRefillFields())
            {
                btnRefSave.Enabled = true;
            } else
            {
                btnRefSave.Enabled = false;
            }
        }

        private void txtRefDosage_TextChanged(object sender, EventArgs e)
        {
            if (CheckRefillFields())
            {
                btnRefSave.Enabled = true;
            }
            else
            {
                btnRefSave.Enabled = false;
            }
        }

        private void txtRefFrequency_TextChanged(object sender, EventArgs e)
        {
            if (CheckRefillFields())
            {
                btnRefSave.Enabled = true;
            }
            else
            {
                btnRefSave.Enabled = false;
            }
        }

        private void txtRefSupplyDays_TextChanged(object sender, EventArgs e)
        {
            if (CheckRefillFields())
            {
                btnRefSave.Enabled = true;
            }
            else
            {
                btnRefSave.Enabled = false;
            }
        }

        private void txtRefQuantitySupplied_TextChanged(object sender, EventArgs e)
        {
            if (CheckRefillFields())
            {
                btnRefSave.Enabled = true;
            }
            else
            {
                btnRefSave.Enabled = false;
            }
        }

        private void txtRefPrice_TextChanged(object sender, EventArgs e)
        {
            if (CheckRefillFields())
            {
                btnRefSave.Enabled = true;
            }
            else
            {
                btnRefSave.Enabled = false;
            }
        }

        private void txtRefPaymentType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CheckRefillFields())
            {
                btnRefSave.Enabled = true;
            }
            else
            {
                btnRefSave.Enabled = false;
            }
        }        
    }
}
