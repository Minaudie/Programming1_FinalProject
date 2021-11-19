using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Final_Project_Work_Space;

namespace FinalProject
{
    public partial class frmUpdatePrescription : Form
    {
        private Employee frmEmployee;
        public frmUpdatePrescription(Employee emp)
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
                ds = upf.GetPrescriptionByID(frmEmployee.prescriptionID.ToString());
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
    }
}