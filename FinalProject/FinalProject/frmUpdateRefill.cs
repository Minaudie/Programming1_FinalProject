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

        }

        private void btnUpdateRefillClear_Click(object sender, EventArgs e)
        {
            frmUpdateRefill_Load(sender, e);
        }
    }
}
