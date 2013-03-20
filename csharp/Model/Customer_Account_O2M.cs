using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IDPRO.csharp.Model
{
    public class Customer_Account_O2M
    {
        long customerID;
        long accountID;
        

        
        public long CustomerID
        {

            get { return customerID; }
            set { customerID = value; }

        }
         public long AccountID
        {

            get { return accountID; }
            set { accountID = value; }

        }
    }
}