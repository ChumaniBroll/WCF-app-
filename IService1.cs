using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCFForInsertValues
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        string InsertLandLord(LandLord landinfo);
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class LandLord
    {
        string vatno = string.Empty;
        string registrationno = string.Empty;
        string client = string.Empty;
        string property = string.Empty;
        string building = string.Empty;
        string premises = string.Empty;
        string meter = string.Empty;
        double rental;
        DateTime rentaldate;
        int rentalecs = 0;

        [DataMember]
        public string VatNo
        {
            get { return vatno; }
            set { vatno = value; }
        }
        [DataMember]
        public string RegistrationNo
        {
            get { return registrationno; }
            set { registrationno = value; }
        }
        [DataMember]
        public string Client
        {
            get { return client; }
            set { client = value; }
        }
        [DataMember]
        public string Property
        {
            get { return property; }
            set { property = value; }
        }
        [DataMember]
        public string Building
        {
            get { return building; }
            set { building = value; }
        }
        [DataMember]
        public string Premises
        {
            get { return premises; }
            set { premises = value; }
        }
        [DataMember]
        public string Meter
        {
            get { return meter; }
            set { meter = value; }
        }
        [DataMember]
        public Double Rental
        {
            get { return rental; }
            set { rental = value; }
        } 
        [DataMember]
        public DateTime RentalDate
        {
            get { return rentaldate; }
            set { rentaldate = value; }
        }
        [DataMember]
        public int RentalEsc
        {
            get { return rentalecs; }
            set { rentalecs = value; }
        }

    }
}
