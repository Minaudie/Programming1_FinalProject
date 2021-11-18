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
        //add Clinet Info
        public DataSet NewClient(int fname, int initial, int lname, int street1, int street2, int city, int state, int zip, int phone, int email, int gender, int DOB, int username )
        {
            try
            {
                myConn.Open();
                cmdString.Parameters.Clear();
                cmdString.Connection = myConn;
                //stored procedure -> selectClient, takes @clientID
                cmdString.CommandType = CommandType.StoredProcedure;
                cmdString.CommandTimeout = 1500;
                cmdString.CommandText = "addNewClient";
               
                //paramenters
                cmdString.Parameters.Add("@fName", SqlDbType.Int).Value = fname;
                cmdString.Parameters.Add("@mInitial", SqlDbType.Int).Value = initial;
                cmdString.Parameters.Add("@lName", SqlDbType.Int).Value = lname;
                cmdString.Parameters.Add("@street1", SqlDbType.Int).Value = street1;
                cmdString.Parameters.Add("@street2", SqlDbType.Int).Value = street2;
                cmdString.Parameters.Add("@city", SqlDbType.Int).Value = city;
                cmdString.Parameters.Add("@state", SqlDbType.Int).Value = state;
                cmdString.Parameters.Add("@zip", SqlDbType.Int).Value = zip;
                cmdString.Parameters.Add("@phone", SqlDbType.Int).Value = phone;
                cmdString.Parameters.Add("@email", SqlDbType.Int).Value = email;
                cmdString.Parameters.Add("@gender", SqlDbType.Int).Value = gender;
                cmdString.Parameters.Add("@DateOfBirth", SqlDbType.Int).Value = DOB;
                cmdString.Parameters.Add("@username", SqlDbType.Int).Value = username;




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
        public DataSet NewPhysician(int fname, int initial, int lname, int phone, int email)
        {
            try
            {
                myConn.Open();
                cmdString.Parameters.Clear();
                cmdString.Connection = myConn;
                //stored procedure -> selectClient, takes @clientID
                cmdString.CommandType = CommandType.StoredProcedure;
                cmdString.CommandTimeout = 1500;
                cmdString.CommandText = "addNewPhysician";

                //paramenters
                cmdString.Parameters.Add("@fName", SqlDbType.Int).Value = fname;
                cmdString.Parameters.Add("@mInitial", SqlDbType.Int).Value = initial;
                cmdString.Parameters.Add("@lName", SqlDbType.Int).Value = lname;
                cmdString.Parameters.Add("@phone", SqlDbType.Int).Value = phone;
                cmdString.Parameters.Add("@email", SqlDbType.Int).Value = email;





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
        public DataSet NewRefill(int dosage, int frequency, int supplydays, int quantitysupplied, int amountdue)
        {
            try
            {
                myConn.Open();
                cmdString.Parameters.Clear();
                cmdString.Connection = myConn;
                //stored procedure -> selectClient, takes @clientID
                cmdString.CommandType = CommandType.StoredProcedure;
                cmdString.CommandTimeout = 1500;
                cmdString.CommandText = "addNewRefill";

                //paramenters
                cmdString.Parameters.Add("@dosage", SqlDbType.Int).Value = dosage;
                cmdString.Parameters.Add("@frequency", SqlDbType.Int).Value = frequency;
                cmdString.Parameters.Add("@supplyDays", SqlDbType.Int).Value = supplydays;
                cmdString.Parameters.Add("@quantitySupplied", SqlDbType.Int).Value = quantitysupplied;
                cmdString.Parameters.Add("@amountDue", SqlDbType.Int).Value = amountdue;





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
