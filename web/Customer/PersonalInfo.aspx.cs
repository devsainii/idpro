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
    public partial class PersonalInfo : System.Web.UI.Page
    {
        Employee emp = new Employee();
        customer customer = new customer();
        Account account = new Account();
        CustomerDAO customeDao = new CustomerDAO();
        CustomerServices customerService = new CustomerServices();
        UserServices dsf = new UserServices();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["username"] == null)
            {
                Response.Redirect("~/EmployeeLogin.aspx");
            }

            if (!Page.IsPostBack)
            {

                fillstates();
            }



            //if (txtcofirstname.Text != null && txtcolastname.Text != null && txtssn1co.Text != null && txtssn2co.Text != null && txtssn3co.Text != null)
            //{

            //}


        }

        public void fillstates()
        {


            DataSet ds = new DataSet();
            ds = customeDao.getstates();
            ddlcity.DataSource = ds;
            ddlcity.DataTextField = "statename";
            ddlcity.DataValueField = "stateid";
            ddlcity.DataBind();



        }


        protected void btn_Click(object sender, EventArgs e)
        {

            customer.cofirstname = txtcofirstname.Text.Trim();
            customer.colastname = txtcolastname.Text.Trim();
            customer.cossn = txtssn1co.Text += txtssn2co.Text += txtssn3co.Text;
            customer.Codob = Convert.ToDateTime(txtDOB.Text.Trim());



            customer.firstname = txtFname.Text.Trim();
            customer.lastname = txtLname.Text.Trim();
            customer.address1 = txtAddress.Text.Trim();
            customer.address2 = txtAddress1.Text.Trim();
            customer.city = txtCity.Text.Trim();
            customer.zip = txtZip.Text.Trim();

            customer.states = ddlcity.SelectedItem.Text.Trim();
            customer.dob = Convert.ToDateTime(txtDOB.Text.Trim());
            customer.ssn = txtSsn1.Text += txtSsn2.Text += txtSsn3.Text;
            customer.phone1 = txtphone1.Text.Trim();
            customer.phone2 = txtphone2.Text.Trim();
            customer.primaryemail = txtPEmail.Text.Trim();
            customer.secondaryemail = txtSEmail.Text.Trim();
            Int32 ssncounter;
            Int32 ssncounter1;
            ssncounter = customeDao.getNumberOfCustomerBySSN(customer.ssn);
            ssncounter1 = customeDao.getNumberOfCustomerBySSN(customer.cossn);
            if (ssncounter > 0 || ssncounter1 > 0)
            {

                lblmsg.Text = "Sorry User will already exist with SSN";
            }
            else
            {

                lblmsg.Text = customerService.customeradd(customer, account);

            }





            pnlmsg.Visible = true;
            pnltext.Visible = false;


        }

        public void add()
        {

            if (txtcofirstname.Text != "")
            {
                txtcolastname.Attributes.Add("required pattern", "[a-zA-Z ]+");
                txtssn1co.Attributes.Add("required pattern", "[a-zA-Z ]+");
            }
            else
            {

            }
            //string strfirstname = txtFname.Text.Trim();
            //string strlastname = txtLname.Text.Trim();
            //string straddress1 = txtAddress1.Text.Trim();
            //string straddress2 = txtAddress.Text.Trim();
            //string city = txtCity.Text.Trim();
            //string zip = txtZip.Text.Trim();
            //string dob = txtDOB.Text.Trim();
            //string ssn = txtSsn1.Text + txtSsn2.Text + txtSsn3.Text;
            //string phone1 = txtphone1.Text;
            //string phone2 = txtphone2.Text;
            //string pemail = txtPEmail.Text;
            //string Semail = txtSEmail.Text;
            //string returnString = customeDao.addcustomer(strfirstname, strlastname, straddress1, straddress2, city, zip, dob, ssn, phone1, phone2, pemail, Semail);
        }

        protected void txtcofirstname_TextChanged(object sender, EventArgs e)
        {
            if (txtcofirstname.Text != null)
            {

                txtcolastname.Attributes.Add("required pattern", "[a-zA-Z ]+");
                txtssn1co.Attributes.Add("required pattern", "[0-9]+");
                txtssn2co.Attributes.Add("required pattern", "[0-9]+");
                txtssn3co.Attributes.Add("required pattern", "[0-9]+");

            }
        }

        protected void txtcolastname_TextChanged(object sender, EventArgs e)
        {
            if (txtcolastname.Text != null)
            {

                txtcofirstname.Attributes.Add("required pattern", "[a-zA-Z ]+");
                txtssn1co.Attributes.Add("required pattern", "[0-9]+");
                txtssn2co.Attributes.Add("required pattern", "[0-9]+");
                txtssn3co.Attributes.Add("required pattern", "[0-9]+");

            }
        }

        protected void txtssn1co_TextChanged(object sender, EventArgs e)
        {
            if (txtssn1co.Text != null)
            {

                txtcofirstname.Attributes.Add("required pattern", "[a-zA-Z ]+");
                txtcolastname.Attributes.Add("required pattern", "[a-zA-Z ]+");
                txtssn2co.Attributes.Add("required pattern", "[0-9]+");
                txtssn3co.Attributes.Add("required pattern", "[0-9]+");

            }
        }

        protected void txtssn2co_TextChanged(object sender, EventArgs e)
        {
            if (txtssn2co.Text != null)
            {

                txtcofirstname.Attributes.Add("required pattern", "[a-zA-Z ]+");
                txtcolastname.Attributes.Add("required pattern", "[a-zA-Z ]+");
                txtssn1co.Attributes.Add("required pattern", "[0-9]+");
                txtssn3co.Attributes.Add("required pattern", "[0-9]+");

            }
        }

        protected void txtssn3co_TextChanged(object sender, EventArgs e)
        {
            if (txtssn3co.Text != null)
            {

                txtcofirstname.Attributes.Add("required pattern", "[a-zA-Z ]+");
                txtcolastname.Attributes.Add("required pattern", "[a-zA-Z ]+");
                txtssn1co.Attributes.Add("required pattern", "[0-9]+");
                txtssn2co.Attributes.Add("required pattern", "[0-9]+");

            }
        }


    }
}