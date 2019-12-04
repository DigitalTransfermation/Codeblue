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
        [Route("api/Budget/Budgetcode")]    //used to save budget details in screen 1
        public HttpResponseMessage Budgetcode(Budgetcode BCOB)
        {
            try
            {
                var result = Daccess.CreateBudget(BCOB);

                if (result != "")
                {

                    return Request.CreateResponse(HttpStatusCode.Created, result); ;
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
        [Route("api/Budget/ShowBudgetDetails")]   //used to view budget details in screen 1
        public HttpResponseMessage ShowBudgetDetails(BudgetDetails Pdobj)
        {
            try
            {
                Daccess = new DA();
                var result = Daccess.bindShowBudgetDetails(Pdobj);
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
     
        [HttpPost]
        [Route("api/Budget/GetDealerValue")]
        public HttpResponseMessage GetDealerValue(SelectDealerValue Dealerobj)
        {
            try
            {
                Daccess = new DA();
                var result = Daccess.bindDealerValue(Dealerobj);
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
        [HttpGet]
        [Route("api/Budget/GetNewDealerValue")]
        public HttpResponseMessage GetNewDealerValue(SelectNewDealerValue Dealerobj)
        {
            try
            {
                Daccess = new DA();
                var result = Daccess.bindNewDealerValue(Dealerobj);
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
        [HttpPost]
        [Route("api/Budget/Userlogin")]
        public HttpResponseMessage Userlogin(user userobj)
        {
            try
            {
                Daccess = new DA();
                var result = Daccess.login(userobj);
                if (result ==null)
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

        [HttpPost]
        [Route("api/Budget/BudgetUpdate")]    //used to update budget details in screen 1
        public HttpResponseMessage BudgetUpdate(budgetupdate BCOB)
        {
            try
            {
                var result = Daccess.UpdateBudget(BCOB);

                if (result != "")
                {

                    return Request.CreateResponse(HttpStatusCode.Created, result); ;
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

    }
}