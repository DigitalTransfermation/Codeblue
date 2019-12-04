using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data.SqlClient;
using System.Configuration;
using NipponBudget.Models;

namespace NipponBudget.Controllers
{
    public class BudgetController : ApiController
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["connection"].ConnectionString);

        SqlCommand cmd = new SqlCommand();
        DA Daccess = new DA();

        [HttpPost]
        [Route("api/Budget/Budgetcode")]
        public HttpResponseMessage Budgetcode(Budgetcode BCOB)
        {
            try
            {
                var result = Daccess.CreateBudget(BCOB);

                if (result ? true : false)
                {

                    return Request.CreateResponse(HttpStatusCode.Created, BCOB); ;
                }
                else
                {
                    return Request.CreateErrorResponse(HttpStatusCode.Ambiguous, "Oops");
                }
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);

            }
        }
        [HttpGet]
        [Route("api/Budget/ShowBudget")]
        public HttpResponseMessage ShowProductDetails(ProductDetails Pdobj)
        {
            try
            {
                Daccess = new DA();
                var result = Daccess.bindShowProductDetails(Pdobj);
                if (result == null)
                {
                    return Request.CreateErrorResponse(HttpStatusCode.NotFound, "No Datafound");

                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.OK, result);

                }

            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "No data found");

            }

        }
    }
}