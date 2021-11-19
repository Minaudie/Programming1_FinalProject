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
    public partial class frmUpdateRefill : Form
    {
        private Employee frmEmployee;
        public frmUpdateRefill(Employee emp)
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
                ds = urf.GetRefillByID(int.Parse(Employee.g_refillID.ToString()));
                if (ds.Tables[0].Rows.Count > 0)
                {
                    txtUpdateRefillID.Text = ds.Tables[0].Rows[0]["refillID"].ToString();
                    txtUpdateRefillID.Enabled = false;
                    txtUpdateRefPrescriptionID.Text = ds.Tables[0].Rows[0]["perscriptionID"].ToString();
                    txtUpdateRefDosage.Text = ds.Tables[0].Rows[0]["dosage"].ToString();
                    txtUpdateRefFrequency.Text = ds.Tables[0].Rows[0]["frequency"].ToString();
                    txtUpdateRefSupplyDays.Text = ds.Tables[0].Rows[0]["supplyDays"].ToString();
                    txtUpdateRefQuantitySupplied.Text = ds.Tables[0].Rows[0]["quantity"].ToString();

                }
            }
            catch(Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }
    }
}
