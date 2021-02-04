using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using PaymentsAPI.Models;

namespace PaymentsAPI.Controllers
{
    public class ReqPropsController : ApiController
    {
        private PaymentDBContext db = new PaymentDBContext();

        public HttpResponseMessage Post([FromBody] ReqProp reqProp)
        {
            try
            {
                PaymentState payState = new PaymentState();
                HttpResponseMessage message;
                if (!ModelState.IsValid)
                {
                    return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                }
                bool reqValid = VerifyPaymentReq.ShouldPaymentProcess(reqProp);
                if (reqValid)
                {
                    double _amount = reqProp.amount;
                    if(_amount < 20)
                    {

                    }
                    else if(_amount >=21 && _amount <= 500)
                    {

                    }
                    else
                    {

                    }
                    db.reqProps.Add(reqProp);
                    message = Request.CreateResponse(HttpStatusCode.OK);

                }
                else
                {
                    message = Request.CreateResponse(HttpStatusCode.BadRequest);

                }
                payState.state = message.ToString();
                db.paymentStates.Add(payState);
                db.SaveChanges();
                return message;
            }
            catch(Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex);
            } 
                
            }

    }
}