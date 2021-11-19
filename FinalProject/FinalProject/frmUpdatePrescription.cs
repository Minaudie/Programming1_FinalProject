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
                //prescriptionID
                ds = upf.GetPrescriptionByID(int.Parse(frmEmployee.g_prescriptionID.ToString()));
                if (ds.Tables[0].Rows.Count > 0)
                {
                    txtUpdatePrescriptionID.Text = ds.Tables[0].Rows[0]["prescriptionID"].ToString();
                    txtUpdatePrescriptionID.Enabled = false;
                    txtUpdatePreClientID.Text = ds.Tables[0].Rows[0]["clientID"].ToString();
                    txtUpdatePrePhysicanID.Text = ds.Tables[0].Rows[0]["physician"].ToString();
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

        }
    }
}