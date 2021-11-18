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
        public void NewClient(string fname, string initial, string lname, string street1, string street2, string city, string state, string zip, string phone, string email, string gender, string DOB, string username )
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
                cmdString.Parameters.Add("@fName", SqlDbType.VarChar, 25).Value = fname;
                cmdString.Parameters.Add("@mInitial", SqlDbType.Char).Value = initial;
                cmdString.Parameters.Add("@lName", SqlDbType.VarChar, 25).Value = lname;
                cmdString.Parameters.Add("@street1", SqlDbType.VarChar, 100).Value = street1;
                cmdString.Parameters.Add("@street2", SqlDbType.VarChar, 100).Value = street2;
                cmdString.Parameters.Add("@city", SqlDbType.VarChar, 25).Value = city;
                cmdString.Parameters.Add("@addr_state", SqlDbType.VarChar, 25).Value = state;
                cmdString.Parameters.Add("@zip", SqlDbType.VarChar, 10).Value = zip;
                cmdString.Parameters.Add("@phone", SqlDbType.VarChar, 15).Value = phone;
                cmdString.Parameters.Add("@email", SqlDbType.VarChar, 100).Value = email;
                cmdString.Parameters.Add("@gender", SqlDbType.VarChar,1 ).Value = gender;
                cmdString.Parameters.Add("@DateOfBirth", SqlDbType.Date ).Value = DateTime.Parse(DOB);
                cmdString.Parameters.Add("@username", SqlDbType.VarChar, 25).Value = username;



                SqlDataAdapter aAdapter = new SqlDataAdapter();
                aAdapter.SelectCommand = cmdString;



                cmdString.ExecuteNonQuery();

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
        public void NewPhysician(string fname, string initial, string lname, string phone, string email)
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
                cmdString.Parameters.Add("@fName", SqlDbType.VarChar,25).Value = fname;
                cmdString.Parameters.Add("@mInitial", SqlDbType.Char).Value = initial;
                cmdString.Parameters.Add("@lName", SqlDbType.VarChar,25).Value = lname;
                cmdString.Parameters.Add("@phone", SqlDbType.VarChar,15).Value = phone;
                cmdString.Parameters.Add("@email", SqlDbType.VarChar,100).Value = email;





                SqlDataAdapter aAdapter = new SqlDataAdapter();
                aAdapter.SelectCommand = cmdString;



                cmdString.ExecuteNonQuery();
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
        public void NewRefill(int perscriptionid,string dosage, string frequency, int supplydays, int quantitysupplied)
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
                cmdString.Parameters.Add("@perscriptionID", SqlDbType.Int).Value = perscriptionid;
                cmdString.Parameters.Add("@dosage", SqlDbType.VarChar,50).Value = dosage;
                cmdString.Parameters.Add("@frequency", SqlDbType.VarChar,50).Value = frequency;
                cmdString.Parameters.Add("@supplyDays", SqlDbType.TinyInt).Value = supplydays;
                cmdString.Parameters.Add("@quantitySupplied", SqlDbType.TinyInt).Value = quantitysupplied;
                
                




                SqlDataAdapter aAdapter = new SqlDataAdapter();
                aAdapter.SelectCommand = cmdString;



                cmdString.ExecuteNonQuery();
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
        public void NewPerscription(int physician, int clientid, int medicationid,string expirydate, int refillcounter)
        {
            try
            {
                myConn.Open();
                cmdString.Parameters.Clear();
                cmdString.Connection = myConn;
                //stored procedure -> selectClient, takes @clientID
                cmdString.CommandType = CommandType.StoredProcedure;
                cmdString.CommandTimeout = 1500;
                cmdString.CommandText = "addNewPerscription";

                //paramenters
                cmdString.Parameters.Add("@clientID", SqlDbType.Int).Value = clientid;
                cmdString.Parameters.Add("@physicianID", SqlDbType.Int).Value = physician;
                cmdString.Parameters.Add("@medicineID", SqlDbType.Int).Value = medicationid;
                cmdString.Parameters.Add("@expiryDate", SqlDbType.Date).Value = DateTime.Parse(expirydate);
                cmdString.Parameters.Add("@refillCounter", SqlDbType.TinyInt).Value = refillcounter;




                SqlDataAdapter aAdapter = new SqlDataAdapter();
                aAdapter.SelectCommand = cmdString;



                cmdString.ExecuteNonQuery();
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
