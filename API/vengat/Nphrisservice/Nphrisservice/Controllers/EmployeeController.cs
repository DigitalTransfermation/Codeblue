using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Nphrisservice.Models;
using EncryptPwd;

namespace Nphrisservice.Controllers
{
    public class EmployeeController : ApiController
    {
        [HttpPost]
        [Route("api/Employee/Authenticate")]
        public HttpResponseMessage Authenticate(Employeedetails Cobj)
        {
            try
            {
                DataAccess DA = new DataAccess();
                if (DA.CheckCredentials(Cobj) ? true : false)
                {
                    string encryptpwd = Encrypt.getEncrValue(Cobj.Password, "10");
                    if (encryptpwd != "")
                    {
                        var result = DA.FetchEmpDetails(Cobj, encryptpwd);
                        if (result != null)
                        {
                            return Request.CreateResponse(HttpStatusCode.OK, result);
                        }
                        else
                        {
                            return Request.CreateResponse(HttpStatusCode.OK, new Employeedetails
                            {

                                Status = "No Results Found"

                            });

                        }
                    }
                    else
                    {
                        return Request.CreateResponse(HttpStatusCode.OK, new Employeedetails
                        {

                            Status = "No Results Found"

                        });


                    }


                }
                else
                {
                    return Request.CreateErrorResponse(HttpStatusCode.Ambiguous, "Sorry Employeeid Not Matching");

                }

            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);

            }
        }

        [HttpGet]
        [Route("api/Nphrisservice/EmployeesList")]
        public HttpResponseMessage EmployeesList(Employeedetails empobj)
        {
            try
            {



                DataAccess Daccess = new DataAccess();
                var result = Daccess.EmployeeList();

                return Request.CreateResponse(HttpStatusCode.OK, result);
            }

            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);

            }
        }


}
}
