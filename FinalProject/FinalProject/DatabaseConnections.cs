using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.VisualBasic;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Data.SqlClient;

namespace FinalProject
{
    class DatabaseConnections
    {
        static String ConnString = ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString;
        static SqlConnection myConn = new SqlConnection(ConnString);
        static System.Data.SqlClient.SqlCommand cmdString = new System.Data.SqlClient.SqlCommand();

        //select client by ID
        public DataSet GetClientByID(int clientid)
        {
            try
            {
                myConn.Open();
                cmdString.Parameters.Clear();
                cmdString.Connection = myConn;

                //stored procedure -> selectClient, takes @clientID
                cmdString.CommandType = CommandType.StoredProcedure;
                cmdString.CommandTimeout = 1500;
                cmdString.CommandText = "selectClient";

                //paramenters
                cmdString.Parameters.Add("@clientID", SqlDbType.Int).Value = clientid;

                SqlDataAdapter aAdapter = new SqlDataAdapter();
                aAdapter.SelectCommand = cmdString;

                DataSet aDataSet = new DataSet();
                aAdapter.Fill(aDataSet);

                return aDataSet;

            } catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            } finally
            {
                myConn.Close();
            }
        }

        //select all of a clients prescriptions
        public DataSet GetAllClientPrescriptions(int clientid)
        {
            try
            {
                myConn.Open();
                cmdString.Parameters.Clear();
                cmdString.Connection = myConn;

                //stored procedure -> selectPrescriptionPerClient, takes @clientID
                cmdString.CommandType = CommandType.StoredProcedure;
                cmdString.CommandTimeout = 1500;
                cmdString.CommandText = "selectPrescriptionPerClient";

                //paramenters
                cmdString.Parameters.Add("@clientID", SqlDbType.Int).Value = clientid;

                SqlDataAdapter aAdapter = new SqlDataAdapter();
                aAdapter.SelectCommand = cmdString;

                DataSet aDataSet = new DataSet();
                aAdapter.Fill(aDataSet);

                return aDataSet;

            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
            finally
            {
                myConn.Close();
            }
        }

        //select refill by ID
        public DataSet GetRefillByID(int refillid)
        {
            try
            {
                myConn.Open();
                cmdString.Parameters.Clear();
                cmdString.Connection = myConn;

                //stored procedure -> selectRefill, takes @refillID
                cmdString.CommandType = CommandType.StoredProcedure;
                cmdString.CommandTimeout = 1500;
                cmdString.CommandText = "selectRefill";

                //paramenters
                cmdString.Parameters.Add("@refillID", SqlDbType.Int).Value = refillid;

                SqlDataAdapter aAdapter = new SqlDataAdapter();
                aAdapter.SelectCommand = cmdString;

                DataSet aDataSet = new DataSet();
                aAdapter.Fill(aDataSet);

                return aDataSet;

            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
            finally
            {
                myConn.Close();
            }
        }
    }
}
