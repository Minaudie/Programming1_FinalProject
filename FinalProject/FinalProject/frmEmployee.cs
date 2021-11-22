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
        private void frmEmployee_Load(object sender, EventArgs e)
        {
            btnClientSave.Enabled = false;
            btnPhySave.Enabled = false;
            btnPreSave.Enabled = false;
            btnRefSave.Enabled = false;
            btnSearch.Enabled = false;
            // ****TO DO ****clear text fields
        }

        /***     CLIENT TAB     ***/

        //returns true if all required fields are filled
        private void CheckClientFields()
        {
            if (txtClientFName.Text.Trim().Length > 0 && txtClientLName.Text.Trim().Length > 0
                && cmboClientGender.Text.Trim().Length > 0 && txtClientDOB.Text.Trim().Length > 0)
            {
                btnClientSave.Enabled = true;
            }
            else
            {
                btnClientSave.Enabled = false;
            }

            erpEmployee.Clear();
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
            cmboClientGender.SelectedIndex = -1; ;
            txtClientDOB.Clear();
        }

        private void btnClientSave_Click(object sender, EventArgs e)
        {
            string fname = "", initial = "", lname = "", street1 = "", street2 = "",
                city = "", state = "", zip = "", phone = "", email = "", gender = "";
            DateTime DOB;

            try
            {
                DatabaseConnections ncf = new DatabaseConnections();

                fname = txtClientFName.Text.Trim();
                initial = txtClientMidInt.Text.Trim();
                lname = txtClientLName.Text.Trim();
                street1 = txtClientAddress.Text.Trim();
                street2 = txtClientAdd2.Text.Trim();
                city = txtClientCity.Text.Trim();
                state = txtClientState.Text.Trim();
                zip = txtClientZip.Text.Trim();
                phone = txtClientPhone.Text.Trim();
                email = txtClientEmail.Text.Trim();
                gender = cmboClientGender.Text.Trim();

                if (gender != Keys.M.ToString() && gender != Keys.F.ToString() && gender != Keys.O.ToString())
                {
                    erpEmployee.SetError(cmboClientGender, "Error: M, F, or O only");
                }
                else
                {
                    try
                    {
                        DOB = DateTime.Parse(txtClientDOB.Text.Trim());

                        int result = ncf.NewClient(fname, initial, lname, street1, street2, city,
                        state, zip, phone, email, gender, DOB);

                        if (result == 0)
                        {
                            MessageBox.Show("This client already exists in the database.", "Existing Client",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else if (result == -1)
                        {
                            //throws the error before it gets to this point
                            MessageBox.Show("Error while inserting record.", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else //any other value
                        {
                            MessageBox.Show("Success. New client's ID is: " + result, "New Client ID", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                            btnClientClear_Click(sender, e);
                        }
                    }
                    catch (Exception ex) //catches date of birth 
                    {
                        erpEmployee.SetError(txtClientDOB, "Error: Dates only");
                    }
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }

        private void txtClientFName_TextChanged(object sender, EventArgs e)
        {
            CheckClientFields();
        }

        private void txtClientLName_TextChanged(object sender, EventArgs e)
        {
            CheckClientFields();
        }

        private void txtClientGender_TextChanged(object sender, EventArgs e)
        {
            CheckClientFields();
        }

        private void txtClientDOB_TextChanged(object sender, EventArgs e)
        {
            CheckClientFields();
        }

        /***     PHYSICIAN TAB     ***/

        private void CheckPhyFields()
        {
            if(txtPhyFName.Text.Trim().Length > 0 && txtPhyLName.Text.Trim().Length > 0)
            {
                btnPhySave.Enabled = true;
            } else
            {
                btnPhySave.Enabled = false;
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
            string fname = "", initial = "", lname = "", phone = "", email = "";

            try
            {
                DatabaseConnections npf = new DatabaseConnections();

                fname = txtPhyFName.Text.Trim();
                initial = txtPhyMidInt.Text.Trim();
                lname = txtPhyLName.Text.Trim();
                phone = txtPhyPhone.Text.Trim();
                email = txtPhyEmail.Text.Trim();

                int result = npf.NewPhysician(fname, initial, lname, phone, email);

                if (result == 0)
                {
                    MessageBox.Show("This physician already exists in the database.", "Existing Client",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (result == -1)
                {
                    MessageBox.Show("Error while inserting record.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else //any other value
                {
                    MessageBox.Show("Success. New physician's ID is: " + result, "New Physician ID",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    btnPhyClear_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }

        private void txtPhyFName_TextChanged(object sender, EventArgs e)
        {
            CheckPhyFields();
        }

        private void txtPhyLName_TextChanged(object sender, EventArgs e)
        {
            CheckPhyFields();
        }

        /***     PRESCRIPTION TAB     ***/

        private void CheckPreFields()
        {
            if(txtPreClientID.Text.Trim().Length > 0 && txtPrePhysicanID.Text.Trim().Length > 0
                && txtPreMedicationID.Text.Trim().Length > 0 && txtPreNumOfRefills.Text.Trim().Length > 0
                && dtpPreExpirationDate.Value != DateTime.Now)
            {
                btnPreSave.Enabled = true;
            } else
            {
                btnPreSave.Enabled = true;
            }

            erpEmployee.Clear();
        }

        private void btnPreClear_Click(object sender, EventArgs e)
        {
            txtPreClientID.Clear();
            txtPrePhysicanID.Clear();
            txtPreMedicationID.Clear();
            txtPreNumOfRefills.Clear();
            dtpPreExpirationDate.Value = DateTime.Now;
        }

        private void btnPreSave_Click(object sender, EventArgs e)
        {
            int clientid = 0, physicianid = 0, medicationid = 0, refillcounter = 0;
            DateTime expirydate;

            try
            {
                DatabaseConnections npf = new DatabaseConnections();

                try //client id try
                {
                    clientid = int.Parse(txtPreClientID.Text.Trim());

                    try //physician try
                    {
                        physicianid = int.Parse(txtPrePhysicanID.Text.Trim());

                        try //medication try
                        {
                            medicationid = int.Parse(txtPreMedicationID.Text.Trim());

                            try //expiry date try
                            {
                                expirydate = dtpPreExpirationDate.Value;

                                try //refill counter try
                                {
                                    refillcounter = int.Parse(txtPreNumOfRefills.Text.Trim());

                                    int result = npf.NewPrescription(clientid, physicianid, medicationid, expirydate, refillcounter);

                                    if (result == -1)
                                    {
                                        MessageBox.Show("Error while inserting record.", "Error",
                                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    else //any other value
                                    {
                                        MessageBox.Show("Success. New prescription ID is: " + result, "New Prescription ID",
                                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                                        btnPreClear_Click(sender, e);
                                    }

                                }
                                catch (Exception ex) //refill counter catch
                                {
                                    erpEmployee.SetError(txtPreNumOfRefills, "Error: numbers only");
                                }

                            }
                            catch (Exception ex) //expiry date catch
                            {
                                erpEmployee.SetError(dtpPreExpirationDate, "Error: Dates only");
                            }

                        }
                        catch (Exception ex) //medication id catch
                        {
                            erpEmployee.SetError(txtPreMedicationID, "Error: numbers only");
                        }

                    }
                    catch (Exception ex) //physician id catch
                    {
                        erpEmployee.SetError(txtPrePhysicanID, "Error: numbers only");
                    }

                }
                catch (Exception ex) //client id catch
                {
                    erpEmployee.SetError(txtPreClientID, "Error: numbers only");
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }

        private void txtPreClientID_TextChanged(object sender, EventArgs e)
        {
            CheckPreFields();
        }

        private void txtPrePhysicanID_TextChanged(object sender, EventArgs e)
        {
            CheckPreFields();
        }

        private void txtPreMedicationID_TextChanged(object sender, EventArgs e)
        {
            CheckPreFields();
        }

        private void dtpPreExpirationDate_ValueChanged(object sender, EventArgs e)
        {
            CheckPreFields();
        }

        private void txtPreNumOfRefills_TextChanged(object sender, EventArgs e)
        {
            CheckPreFields();
        }

        /***     REFILL TAB     ***/

        private void CheckRefillFields()
        {
            if(txtRefPrescriptionID.Text.Trim().Length > 0 && txtRefDosage.Text.Trim().Length > 0
                && txtRefFrequency.Text.Trim().Length > 0 && txtRefSupplyDays.Text.Trim().Length > 0
                && txtRefQuantitySupplied.Text.Trim().Length > 0 && cboRefPaymentType.SelectedIndex != -1)
            {
                btnRefSave.Enabled = true;

            } else
            {
                btnRefSave.Enabled = false;
            }

            erpEmployee.Clear();
        }

        private void btnRefClear_Click(object sender, EventArgs e)
        {
            txtRefPrescriptionID.Clear();
            txtRefDosage.Clear();
            txtRefFrequency.Clear();
            txtRefSupplyDays.Clear();
            txtRefQuantitySupplied.Clear();
            txtRefPrice.Clear();
            cboRefPaymentType.SelectedIndex = -1;
        }

        private void btnRefSave_Click(object sender, EventArgs e)
        {
            string dosage = "", frequency = "";
            int supplydays = 0, quantitysupplied = 0, prescriptionid = 0;

            try
            {
                DatabaseConnections nrf = new DatabaseConnections();

                try //prescription id
                {
                    prescriptionid = int.Parse(txtRefPrescriptionID.Text.Trim());

                    try
                    {
                        dosage = txtRefDosage.Text.Trim();
                        frequency = txtRefFrequency.Text.Trim();
                        supplydays = int.Parse(txtRefSupplyDays.Text.Trim());

                        try
                        {
                            quantitysupplied = int.Parse(txtRefQuantitySupplied.Text.Trim());

                            int result = nrf.NewRefill(prescriptionid, dosage, frequency, supplydays, quantitysupplied);

                            if (result == -1)
                            {
                                MessageBox.Show("Error while inserting record.", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else //any other value
                            {
                                MessageBox.Show("Success. New refill ID is: " + result, "New Refill ID",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                                btnRefClear_Click(sender, e);
                            }
                        }
                        catch (Exception ex) //quantity catch
                        {
                            erpEmployee.SetError(txtRefQuantitySupplied, "Error: numbers only");
                        }

                    }
                    catch (Exception ex) //supply days catch
                    {
                        erpEmployee.SetError(txtRefSupplyDays, "Error: numbers only");
                    }

                }
                catch (Exception ex) //prescription id catch
                {
                    erpEmployee.SetError(txtRefPrescriptionID, "Error: numbers only");
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmuRefillBack_Click(object sender, EventArgs e)
        {
            btnSearch_Click(sender, e);

        }

        private void cmuPrescriptionBack_Click(object sender, EventArgs e)
        {
            btnSearch_Click(sender, e);
        }
    }
}
