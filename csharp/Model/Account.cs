using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IDPRO.csharp.Model
{
    public class Account
    {
        Int32 AccountId;
        String Status, AddedBy;

        public Account()
        {
            AccountId = 0;
            Status = AddedBy = "";

        }
        public int accountid
        {

            get { return AccountId; }
            set { AccountId = value; }

        }
        public string status
        {
            get { return Status;}
            set { Status = value; }
        }
        public string addby
        {
            get { return AddedBy; }
            set { AddedBy = value; }
        }
    }
}