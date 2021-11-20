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
    public partial class frmEmployee : Form
    {
        public static int g_clientID;
        public static int g_prescriptionID;
        public static int g_refillID;
        
        private void addNewClient()
        {
            string fname = "", initial = "", lname = "", street1 = "", street2 = "",
                city = "", state = "", zip = "", phone = "", email = "", gender = "", DOB = "";
             
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

                int clientID = ncf.NewClient(fname, initial, lname, street1, street2, city, 
                    state, zip, phone, email, gender, DOB);

                MessageBox.Show("New client's ID is: " + clientID, "New Client ID", MessageBoxButtons.OK, 
                    MessageBoxIcon.Information);
                
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
                phone = txtPhyPhone.Text.Trim();
                email = txtPhyEmail.Text.Trim();

                npf.NewPhysician(fname, initial, lname, phone, email);

                MessageBox.Show("Successfully created new physician.", "Success", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
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

                MessageBox.Show("Successfully created new refill.", "Success", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }

        private void addNewPrescription()
        {
            int clientid = 0, physician = 0, medicationid = 0, refillcounter = 0;
            string expirydate = "";

            try
            {
                DatabaseConnections npf = new DatabaseConnections();

                clientid = int.Parse(txtPreClientID.Text.Trim());
                physician = int.Parse(txtPrePhysicanID.Text.Trim());
                medicationid = int.Parse(txtPreMedicationID.Text.Trim());
                expirydate = dtpPreExpirationDate.Value.ToString();
                refillcounter = int.Parse(txtPreNumOfRefills.Text.Trim());
                
                npf.NewPrescription(clientid, physician, medicationid, expirydate, refillcounter);

                MessageBox.Show("Successfully created new prescription.", "Success", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }

        public frmEmployee()
        {
            InitializeComponent();
            dgvClient.DoubleClick += new EventHandler(dgvClient_DoubleClick);
            dgvPre.DoubleClick += new EventHandler(dgvPre_DoubleClick);
            dgvRefill.DoubleClick += new EventHandler(dgvRefill_DoubleClick);
        }

        private void dgvClient_DoubleClick(object sender, EventArgs e)
        {
            cmuClientUpdate_Click(sender, e);
        }

        private void dgvPre_DoubleClick(object sender, EventArgs e)
        {
            cmuPrescriptionUpdate_Click(sender, e);
        }

        private void dgvRefill_DoubleClick(object sender, EventArgs e)
        {
            cmuRefillUpdate_Click(sender, e);
        }

        //overall form load
        private void Employee_Load(object sender, EventArgs e)
        {
            btnClientSave.Enabled = false;
            // ****TO DO ****disabling buttons/clear text fields
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

        private void btnClientClear_Click(object sender, EventArgs e)
        {
            txtClientFName.Clear();
            txtClientMidInt.Clear();
            txtClientLName.Clear();
            txtClientAddress.Clear();
            txtClientAdd2.Clear();
            txtClientCity.Clear();
            txtClientState.Clear();
            txtClientZip.Clear();
            txtClientPhone.Clear();
            txtClientEmail.Clear();
            txtClientGender.Clear();
            txtClientDOB.Clear();
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
            addNewPrescription();
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

        private void CheckRefillFields()
        {
            if(txtRefPrescriptionID.Text.Trim().Length > 0 && txtRefDosage.Text.Trim().Length > 0
                && txtRefFrequency.Text.Trim().Length > 0 && txtRefSupplyDays.Text.Trim().Length > 0
                && txtRefQuantitySupplied.Text.Trim().Length > 0 && cboRefPayment.SelectedIndex != -1)
            {
                btnRefSave.Enabled = true;

            } else
            {
                btnRefSave.Enabled = false;
            }
        }

        private void btnRefClear_Click(object sender, EventArgs e)
        {
            txtRefPrescriptionID.Clear();
            txtRefDosage.Clear();
            txtRefFrequency.Clear();
            txtRefSupplyDays.Clear();
            txtRefQuantitySupplied.Clear();
            txtRefPrice.Clear();
            cboRefPayment.SelectedIndex = -1;
        }

        private void btnRefSave_Click(object sender, EventArgs e)
        {
            addNewRefill();
            btnRefClear_Click(sender, e);
        }

        private void txtRefPrescriptionID_TextChanged(object sender, EventArgs e)
        {
            CheckRefillFields();

            if(txtRefPrescriptionID.Text.Trim().Length > 0)
            {
                //run stored procedure to select price from prescription
                DatabaseConnections dc = new DatabaseConnections();
                int presid = int.Parse(txtRefPrescriptionID.Text.Trim());

                DataSet ds = new DataSet();
                ds = dc.GetPrescriptionPrice(presid);

                txtRefPrice.Text = ds.Tables[0].Rows[0]["price"].ToString();

            } else
            {
                txtRefPrice.Clear();
            }
        }

        private void txtRefDosage_TextChanged(object sender, EventArgs e)
        {
            CheckRefillFields();
        }

        private void txtRefFrequency_TextChanged(object sender, EventArgs e)
        {
            CheckRefillFields();
        }

        private void txtRefSupplyDays_TextChanged(object sender, EventArgs e)
        {
            CheckRefillFields();
        }

        private void txtRefQuantitySupplied_TextChanged(object sender, EventArgs e)
        {
            CheckRefillFields();
        }

        private void txtRefPrice_TextChanged(object sender, EventArgs e)
        {
            CheckRefillFields();
        }

        private void cboRefPayment_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckRefillFields();
        }

        /***    SEARCH TAB       ***/

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int clientid;

            try
            {
                DataSet ds = new DataSet();
                DatabaseConnections dc = new DatabaseConnections();

                clientid = int.Parse(txtSearch.Text.Trim());

                ds = dc.GetClientByID(clientid);

                dgvClient.Visible = true;
                dgvPre.Visible = false;
                dgvRefill.Visible = false;

                dgvClient.DataSource = ds.Tables[0];

            } catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if(txtSearch.Text.Trim().Length > 0)
            {
                btnSearch.Enabled = true;
            } else
            {
                btnSearch.Enabled = false;
            }
        }

        /***    CONTEXT MENUS    ***/

        private void cmuClientUpdate_Click(object sender, EventArgs e)
        {
            string clientid = "";

            if (dgvClient.Rows.Count > 0)
            {
                DataGridViewRow row = dgvClient.SelectedRows[0];
                frmUpdateClient clientform = new frmUpdateClient(this);

                clientid = row.Cells[0].Value.ToString().Trim();
                g_clientID = int.Parse(clientid);
                clientform.ShowDialog();
            }
        }

        private void cmuClientSearchPre_Click(object sender, EventArgs e)
        {
            int clientid;

            try
            {
                DataSet ds = new DataSet();
                DatabaseConnections dc = new DatabaseConnections();

                DataGridViewRow row = dgvClient.SelectedRows[0];
                clientid = int.Parse(row.Cells[0].Value.ToString().Trim());

                ds = dc.GetAllClientPrescriptions(clientid);

                dgvPre.Visible = true;
                dgvClient.Visible = false;
                dgvRefill.Visible = false;

                dgvPre.DataSource = ds.Tables[0];

            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }

        private void cmuClientSearchRefill_Click(object sender, EventArgs e)
        {
            int clientid;

            try
            {
                DataSet ds = new DataSet();
                DatabaseConnections dc = new DatabaseConnections();

                DataGridViewRow row = dgvClient.SelectedRows[0];
                clientid = int.Parse(row.Cells[0].Value.ToString().Trim());

                ds = dc.GetAllClientRefills(clientid);

                dgvRefill.Visible = true;
                dgvClient.Visible = false;
                dgvPre.Visible = false;

                dgvRefill.DataSource = ds.Tables[0];

            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }

        private void cmuPrescriptionUpdate_Click(object sender, EventArgs e)
        {
            string prescriptionid = "";

            if (dgvClient.Rows.Count > 0)
            {
                DataGridViewRow row = dgvPre.SelectedRows[0];
                frmUpdatePrescription prescriptionform = new frmUpdatePrescription(this);

                prescriptionid = row.Cells[0].Value.ToString().Trim();
                g_prescriptionID = int.Parse(prescriptionid);
                prescriptionform.ShowDialog();
            }
        }

        private void cmuRefillUpdate_Click(object sender, EventArgs e)
        {
            string refillid = "";

            if (dgvClient.Rows.Count > 0)
            {
                DataGridViewRow row = dgvRefill.SelectedRows[0];
                frmUpdateRefill refillform = new frmUpdateRefill(this);

                refillid = row.Cells[0].Value.ToString().Trim();
                g_refillID = int.Parse(refillid);
                refillform.ShowDialog();
            }
        }

        private void cmuRefillDelete_Click(object sender, EventArgs e)
        {
            int refillid;

            try
            {
                DatabaseConnections dc = new DatabaseConnections();
                DataGridViewRow row = dgvRefill.SelectedRows[0];

                refillid = int.Parse(row.Cells[0].Value.ToString().Trim());

                dc.DeleteRefill(refillid);

                //refresh the data grid to reflect deleted row
                DataSet ds = new DataSet();
                int clientid = int.Parse(row.Cells[0].Value.ToString().Trim());

                ds = dc.GetAllClientRefills(clientid);

                dgvRefill.DataSource = ds.Tables[0];

            } catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }

        
    }
}
