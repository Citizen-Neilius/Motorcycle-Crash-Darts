using System;
using System.Collections.Generic;
using System.Linq;
//using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SDEV_360_Motorcycle_Game
{

    // Neil Little -  SDEV 360 - 
    // Final Project: 
    // 01 May 2020
    class SQLDatabaseConnection
    {   //Class to create a data connection.  


        const string sDataSource = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Neilius\\source\\repos\\!!!!! SDEV 360\\SDEV 360 Motorcycle Wk7\\SDEV 360 Motorcycle Game\\SDEV 360 Motorcycle Game\\MotorCycleData.mdf\";Integrated Security = True";


        public SqlConnection dbConn()
        {
            SqlConnection oConn = new SqlConnection();

            try
            {
                oConn.ConnectionString = sDataSource;
                oConn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
                //connectection failed
                oConn = null;
            }//try-catch	   

            return oConn;
        }


    }//end dbConn
}