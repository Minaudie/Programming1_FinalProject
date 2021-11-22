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
    public partial class frmUpdateRefill : Form
    {
        private frmEmployee frmEmployee;
        public frmUpdateRefill(frmEmployee emp)
        {
            InitializeComponent();
            frmEmployee = emp;
        }

        private void frmUpdateRefill_Load(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = new DataSet();
                DatabaseConnections urf = new DatabaseConnections();
                //refillID
                ds = urf.GetRefillByID(frmEmployee.g_refillID);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    txtUpdateRefillID.Text = ds.Tables[0].Rows[0]["refillID"].ToString();
                    txtUpdateRefillID.Enabled = false;
                    txtUpdateRefPrescriptionID.Text = ds.Tables[0].Rows[0]["prescriptionID"].ToString();
                    txtUpdateRefDosage.Text = ds.Tables[0].Rows[0]["dosage"].ToString();
                    txtUpdateRefFrequency.Text = ds.Tables[0].Rows[0]["frequency"].ToString();
                    txtUpdateRefSupplyDays.Text = ds.Tables[0].Rows[0]["supplyDays"].ToString();
                    txtUpdateRefQuantitySupplied.Text = ds.Tables[0].Rows[0]["quantitySupplied"].ToString();
                    txtUpdateRefAmountDue.Text = ds.Tables[0].Rows[0]["amountDue"].ToString();
                    txtUpdateRefAmountDue.Enabled = false;
                    dtpUpdateRefDateOfRefill.Value = DateTime.Parse(ds.Tables[0].Rows[0]["dateOfRefill"].ToString());
                    dtpUpdateRefDateOfRefill.Enabled = false;
                }
            }
            catch(Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }

        private void btnUpdateRefillUpdate_Click(object sender, EventArgs e)
        {
            string dosage = "", frequency = "";
            int supplydays = 0, quantitysupplied = 0, prescriptionid = 0;

            try
            {
                DatabaseConnections nrf = new DatabaseConnections();

                try //prescription id
                {
                    prescriptionid = int.Parse(txtUpdateRefPrescriptionID.Text.Trim());

                    try
                    {
                        dosage = txtUpdateRefDosage.Text.Trim();
                        frequency = txtUpdateRefFrequency.Text.Trim();
                        supplydays = int.Parse(txtUpdateRefSupplyDays.Text.Trim());

                        try
                        {
                            quantitysupplied = int.Parse(txtUpdateRefQuantitySupplied.Text.Trim());

                            int result = nrf.NewRefill(prescriptionid, dosage, frequency, supplydays, quantitysupplied);

                            if (result == -1)
                            {
                                MessageBox.Show("Error while inserting record.", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else //any other value
                            {
                                MessageBox.Show("Success. New refill ID is: " + result, "Updated Refill ID",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                                this.Close();
                            }
                        }
                        catch (Exception ex) //quantity catch
                        {
                            erpUpdateRefill.SetError(txtUpdateRefQuantitySupplied, "Error: numbers only");
                        }

                    }
                    catch (Exception ex) //supply days catch
                    {
                        erpUpdateRefill.SetError(txtUpdateRefSupplyDays, "Error: numbers only");
                    }

                }
                catch (Exception ex) //prescription id catch
                {
                    erpUpdateRefill.SetError(txtUpdateRefPrescriptionID, "Error: numbers only");
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }
    }

       
    
}
