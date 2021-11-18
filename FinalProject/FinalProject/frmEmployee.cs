﻿using System;
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
        private void addNewClient()
        {
            string fname = "", initial = "", lname = "", street1 = "", street2 = "", 
                city = "", state = "", zip = "", phone = "", email = "", gender = "", DOB = "", username = "";
             
            try
            {
                
                
                DatabaseConnections ncf = new DatabaseConnections();
    
                    fname = txtClientFName.Text.Trim();
                    initial = txtClientMidInt.Text.Trim();
                    lname = txtClientLName.Text.Trim();
                    street1 = txtClientAddress.Text.Trim();
                    street2 =txtClientAdd2.Text.Trim();
                    city =txtClientCity.Text.Trim();
                    state = txtClientState.Text.Trim();
                    zip = txtClientZip.Text.Trim();
                    phone = txtClientPhone.Text.Trim();
                    email = txtClientEmail.Text.Trim();
                    gender =txtClientGender.Text.Trim();
                    DOB =txtClientDOB.Text.Trim();
                    username = txtClientUserName.Text.Trim();

                ncf.NewClient(fname, initial, lname, street1, street2, city, state, zip, phone, email, gender, DOB, username);
                

            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }
        private void addNewPhysician()
        {
            string fname = "", initial = "", lname = "", phone = "", email = "";

            try
            {
          
                DatabaseConnections npf = new DatabaseConnections();

                
                
                    fname = txtPhyFName.Text.Trim();
                    initial = txtPhyMidInt.Text.Trim();
                    lname = txtPhyLName.Text.Trim();
                    phone = txtPhyLName.Text.Trim();
                    email = txtPhyEmail.Text.Trim();

                npf.NewPhysician(fname, initial, lname, phone, email);

            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }
        private void addNewRefill()
        {
            string dosage = "", frequency = "";
            int supplydays = 0, quantitysupplied = 0, perscriptionid = 0;
            try
            {
               
                DatabaseConnections nrf = new DatabaseConnections();


                    perscriptionid = int.Parse(txtRefPrescriptionID.Text.Trim());
                    dosage = txtRefDosage.Text.Trim();
                    frequency = txtRefFrequency.Text.Trim();                
                    supplydays = int.Parse(txtRefSupplyDays.Text.Trim());
                    quantitysupplied = int.Parse(txtRefQuantitySupplied.Text.Trim());


                nrf.NewRefill(perscriptionid, dosage, frequency, supplydays, quantitysupplied);


            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }
        private void addNewPerscreiption()
        {
            int clientid = 0, physician = 0, medicationid = 0, refillcounter = 0;
            string startdate = "", expirydate = "";
            try
            {

                DatabaseConnections npf = new DatabaseConnections();


                clientid = int.Parse(txtPreClientID.Text.Trim());
                physician = int.Parse(txtPrePhysicanID.Text.Trim());
                medicationid = int.Parse(txtPreMedicationID.Text.Trim());
                expirydate = dtpPreExpirationDate.Value.ToString();
                refillcounter = int.Parse(txtPreNumOfRefills.Text.Trim());
                


                npf.NewPerscription(clientid, physician, medicationid, expirydate, refillcounter);


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
            
        }

        private void btnClientClear_Click(object sender, EventArgs e)
        {
            txtClientFName.Clear();
            txtClientMidInt.Clear();
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
            txtClientUserName.Clear();
        }

        private void btnClientSave_Click(object sender, EventArgs e)
        {
            addNewClient();
            btnClientClear_Click(sender,e);

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
            addNewPhysician();
            btnPhyClear_Click(sender, e);

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
            addNewPerscreiption();
            btnPerClear_Click(sender, e);

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
            addNewRefill();
            btnRefClear_Click(sender, e);

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
