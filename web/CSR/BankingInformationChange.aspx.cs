﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IDPRO
{
    public partial class BankingInformationChange : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("BankingInformationChangeConfirm.aspx");

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            Response.Redirect("ContactInformationChangeConfirm.aspx");
        }
    }
}