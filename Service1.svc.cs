//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Runtime.Serialization;
//using System.ServiceModel;
//using System.ServiceModel.Web;
//using System.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace WCFForInsertValues
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.



    public class Service1 : IService1
    {

        public string InsertLandLord(LandLord landinfo)
        {
            string message = "";
            SqlConnection con = new SqlConnection("data source = Karabinasql; initial catalog = UPD8_Test; persist security info = False; user id = OS_TestApp; password = Skywalker_J3d1; Max Pool Size = 200; Connection Timeout = 240");
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert into LandLordInfo(VatNo,RegistrationNo,Client,Property,Building,Premises,Meter,Rental,RentalDate,RentalEsc) VALUES(@VatNo,@RegistrationNo,@Client,@Property,@Building,@Premises,@Meter,@Rental,@RentalDate,@RentalEsc)", con);
            cmd.Parameters.AddWithValue("@VatNo", landinfo.VatNo);
            cmd.Parameters.AddWithValue("@RegistrationNo", landinfo.RegistrationNo);
            cmd.Parameters.AddWithValue("@Client", landinfo.Client);
            cmd.Parameters.AddWithValue("@Property", landinfo.Property);
            cmd.Parameters.AddWithValue("@Building", landinfo.Building);
            cmd.Parameters.AddWithValue("@Premises", landinfo.Premises);
            cmd.Parameters.AddWithValue("@Meter", landinfo.Meter);
            cmd.Parameters.AddWithValue("@Rental", landinfo.Rental);
            cmd.Parameters.AddWithValue("@RentalDate", landinfo.RentalDate);
            cmd.Parameters.AddWithValue("@RentalEsc", landinfo.RentalEsc);

            int result = cmd.ExecuteNonQuery();

            if(result == 1)
            {
                message = landinfo.VatNo + "Details Successfully";
            }
            else
            {
                message = landinfo.VatNo + "Details not inserted";
            }

            con.Close();
            return message;
        }

    }
}
