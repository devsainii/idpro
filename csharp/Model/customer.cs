using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using IDPRO.csharp.DAO;
namespace IDPRO.csharp.Model
{
    public class customer
    {
         Int32 IntCustomer;
         String FirstName,LastName,Address1, Address2, City, Zip, SSN, Phone1, Phone2, PrimaryEmail, States, SecondaryEmail;
         DateTime DOB ;
         String COFirstName,COLastName, CoSsn="";
         DateTime CoDOB;

         String DropPhone1, DropPhone2;
       
        public customer()
         {
             IntCustomer = 0;
             FirstName = LastName = Address1 = Address2 = City = Zip = SSN = Phone1 = Phone2 = States = PrimaryEmail = SecondaryEmail = "";
        //     DOB = DateTime.Parse("1/1/1753"); 
            
             COFirstName = COLastName = CoSsn = "";
             
             DropPhone1 = DropPhone2 = "";

          
         }


        public string dropphone1
        { 
            get { return DropPhone1 ;}
            set { DropPhone1 = value; }
        }
        public string dropphone2
        {
            get { return dropphone2; }
            set { DropPhone2 = value;}
        }
        public int intcustomer
        {
            get {return IntCustomer;}
            set {IntCustomer = value;}
        }
        public string firstname 
        {
            get { return FirstName; }
            set { FirstName = value;}
        }
        public string lastname
        {
            get { return LastName; }
            set { LastName = value; }
        }
        public string address1
        {
            get { return Address1; }
            set { Address1 = value;}
        }
        public string address2
        {
            get { return Address2; }
            set { Address2 = value;}
        }
        public string city
        {
            get { return City; }
            set { City = value;}
        }
        public string zip
        {
            get { return Zip; }
            set { Zip = value; }
        }
        public string states
        {
            get { return States; }
            set { States = value; }
        }

        public string ssn
        {
            get { return SSN; }
            set { SSN = value;}
        }
        public string phone1
        {
            get { return Phone1; }
            set { Phone1 = value;}
        }
        public string phone2
        {
            get { return Phone2; }
            set { Phone2 = value;}
        }
        public string primaryemail
        {
            get { return PrimaryEmail; }
            set { PrimaryEmail = value; }
        }
        public string secondaryemail
        {
            get { return SecondaryEmail; }
            set { SecondaryEmail = value; }
        }
        public DateTime dob
        {
            get { return DOB; }
            set { DOB = value; }
        }
        public string cofirstname
        {
            get { return COFirstName; }
            set { COFirstName = value; }
        }
        public string colastname
        {
            get { return COLastName;}
            set { COLastName = value; }
        }
        public string cossn
        {
            get { return CoSsn; }
            set { CoSsn = value; }
        }
        public DateTime Codob
        {
            get { return CoDOB; }
            set { CoDOB = value;}
        }

    }
  

}