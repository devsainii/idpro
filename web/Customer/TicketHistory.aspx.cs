using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using IDPRO.csharp.Model;
using IDPRO.csharp.DAO;
using IDPRO.csharp.Services;
using System.Data.SqlClient;
using System.Data;
using IDPRO.csharp.Constants;
using System.Web.UI.HtmlControls;


namespace IDPRO.web.Customer
{
    public partial class TicketHistory : System.Web.UI.Page
    {
        Ticket ticket = new Ticket();
        TicketDao ticketdao = new TicketDao();
        public string str = "";

        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {


                ticketdao.getticketid(str);
                fillTickethistory();
                fillTicketassignmenthistory();
                fillTicketnotehistory();

            }

        }
        public void fillTickethistory()
        {

            DataSet ds = new DataSet();
            ds = ticketdao.gettickethistory(str);
            
            grdtickethistory.DataSource = ds;
            grdtickethistory.DataBind();
        }
        public void fillTicketassignmenthistory()
        {

            DataSet ds1 = new DataSet();
            ds1 = ticketdao.getticketassignmenthistory(str);
            gridassignmenthistory.DataSource = ds1;
            gridassignmenthistory.DataBind();
        }
        public void fillTicketnotehistory()
        {
            DataSet ds2 = new DataSet();
            ds2 = ticketdao.getticketnodehistory(str);

            gridnote.DataSource  = ds2;
            gridnote.DataBind();
        }

        protected void grdtickethistory_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "note")
            {

                grdnote.Visible = true;

            }

            if (e.CommandName == "assign")
            {

                grdassign.Visible = true;

            }
        }

       
    }
}