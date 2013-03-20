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

namespace IDPRO
{
    public partial class Main : System.Web.UI.MasterPage
    {
        MenuDao menudao = new MenuDao();

        public string str = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["username"] == null)
            {
                Response.Redirect("~/EmployeeLogin.aspx");
            }
            if (!IsPostBack)
            {
                fillmenu();
            }


            //string currentPath = Request.RawUrl;
            //if (currentPath.Contains("PersonalInfo.aspx"))
            //{
            //    sc.Visible = false;
            //    ob.Visible = false;
            //    cd.Visible = false;
            //    cs.Visible = false;
            //    neg.Visible = false;
            //    admin.Visible = false;

            //}
            //else if (currentPath.Contains("Customer.aspx"))
            //{
            //    sc.Visible = false;
            //    ob.Visible = false;
            //    cd.Visible = false;
            //    cs.Visible = false;
            //    neg.Visible = false;
            //    admin.Visible = false;

            //}

        }
        public void fillmenu()
        {
            string menu = "";

            str = Session["username"].ToString();
            DataSet ds = new DataSet();
            ds = menudao.getmenu(str);
            Repeater1.DataSource = ds;
            Repeater1.DataBind();
            string deptt = "";
            deptt = Session["department"].ToString ();
            if (deptt == "Sales")
            {

               // pnlsales.Visible = true;


            }
        }

       
    }
}