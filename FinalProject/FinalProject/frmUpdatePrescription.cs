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
    public partial class frmUpdatePrescription : Form
    {
        private frmEmployee frmEmployee;

        public frmUpdatePrescription(frmEmployee emp)
        {
            InitializeComponent();
            frmEmployee = emp;
        }

        private void frmUpdatePrescription_Load(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = new DataSet();
                DatabaseConnections upf = new DatabaseConnections();

                ds = upf.GetPrescriptionByID(frmEmployee.g_prescriptionID);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    txtUpdatePrescriptionID.Text = ds.Tables[0].Rows[0]["prescriptionID"].ToString();
                    txtUpdatePrescriptionID.Enabled = false;
                    txtUpdatePreClientID.Text = ds.Tables[0].Rows[0]["clientID"].ToString();
                    txtUpdatePrePhysicanID.Text = ds.Tables[0].Rows[0]["physicianID"].ToString();
                    txtUpdatePreMedicationID.Text = ds.Tables[0].Rows[0]["medicineID"].ToString();
                    dtpUpdatePreExpirationDate.Value = DateTime.Parse(ds.Tables[0].Rows[0]["expiryDate"].ToString());
                    txtUpdatePreNumOfRefills.Text = ds.Tables[0].Rows[0]["refillCounter"].ToString();
       
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }

        private void btnUpdatePreUpdate_Click(object sender, EventArgs e)
        {
            int clientid = 0, physicianid = 0, medicationid = 0, refillcounter = 0, prescriptionid = 0;
            DateTime expirydate;

            try
            {
                DatabaseConnections npf = new DatabaseConnections();
                prescriptionid = int.Parse(txtUpdatePreClientID.Text.Trim());

                try //client id try
                {
                    clientid = int.Parse(txtUpdatePreClientID.Text.Trim());

                    try //physician try
                    {
                        physicianid = int.Parse(txtUpdatePrePhysicanID.Text.Trim());

                        try //medication try
                        {
                            medicationid = int.Parse(txtUpdatePreMedicationID.Text.Trim());

                            try //expiry date try
                            {
                                expirydate = dtpUpdatePreExpirationDate.Value;

                                try //refill counter try
                                {
                                    refillcounter = int.Parse(txtUpdatePreNumOfRefills.Text.Trim());

                                    //int result =
                                     npf.UpdatePrescription(prescriptionid, clientid, physicianid, medicationid, expirydate, refillcounter);

                                    /*if (result == -1)
                                    {
                                        MessageBox.Show("Error while inserting record.", "Error",
                                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    else //any other value
                                    {
                                        MessageBox.Show("Success. New prescription ID is: " + result, "New Prescription ID",
                                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                                        this.Close();
                                    }*/
                                    MessageBox.Show("Prescription record updated successfully.", "Record Updated", MessageBoxButtons.OK,
                                         MessageBoxIcon.Information);
                                    this.Close();

                                }
                                catch (Exception ex) //refill counter catch
                                {
                                    erpUpdatePrescription.SetError(txtUpdatePreNumOfRefills, "Error: numbers only");
                                }

                            }
                            catch (Exception ex) //expiry date catch
                            {
                                erpUpdatePrescription.SetError(dtpUpdatePreExpirationDate, "Error: Dates only");
                            }

                        }
                        catch (Exception ex) //medication id catch
                        {
                            erpUpdatePrescription.SetError(txtUpdatePreMedicationID, "Error: numbers only");
                        }

                    }
                    catch (Exception ex) //physician id catch
                    {
                        erpUpdatePrescription.SetError(txtUpdatePrePhysicanID, "Error: numbers only");
                    }

                }
                catch (Exception ex) //client id catch
                {
                    erpUpdatePrescription.SetError(txtUpdatePreClientID, "Error: numbers only");
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }
    }

       
    
}