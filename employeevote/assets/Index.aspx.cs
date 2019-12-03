using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using EncryptPwd;

namespace employeevote.assets
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnlogin_Click(object sender, EventArgs e)
        {
            if ((txtempid.Text == "admin") && (txtpwd.Text == "nipponadmin"))
            {
                Response.Redirect("AdminReport.aspx");

            }
            else
            {
                DataAccess DA = new DataAccess();
                Employeedetails Cobj = new Employeedetails();
                Cobj.EmployeeId = txtempid.Text.Trim();
                Cobj.Password = txtpwd.Text.Trim();
                if (DA.CheckCredentials(Cobj) ? true : false)
                {
                    string encryptpwd = Encrypt.getEncrValue(Cobj.Password, "10");
                    if (encryptpwd != "")
                    {
                        var result = DA.FetchEmpDetails(Cobj, encryptpwd);

                        if (Cobj.Status == "Active")
                        {
                            Session["division"] = Cobj.Division;
                            Session["department"] = Cobj.Department;
                            Session["BusinessUnit"] = Cobj.BusinessUnit;
                            Session["location"] = Cobj.Location;
                            Session["Empno"] = Cobj.EmpNo;
                            if (Cobj.Gender == "Male")
                            {
                                Session["Name"] = "Mr. " + Cobj.Name;
                            }
                            else
                            {
                                Session["Name"] = "Ms. " + Cobj.Name;
                            }

                            Response.Redirect("Vote.aspx");

                        }
                        else
                        {
                            string message = "Incorrect Login Credentials";

                            ScriptManager.RegisterStartupScript(this, typeof(Page), "Success", "<script>showpop5('" + message + "')</script>", false);


                        }


                    }
                    else
                    {

                        string message = "Incorrect Login Credentials";

                        ScriptManager.RegisterStartupScript(this, typeof(Page), "Success", "<script>showpop5('" + message + "')</script>", false);

                    }


                }
                else
                {

                    string message = "Employee does not exist";

                    ScriptManager.RegisterStartupScript(this, typeof(Page), "Success", "<script>showpop5('" + message + "')</script>", false);

                }


            }
        }
    }
}