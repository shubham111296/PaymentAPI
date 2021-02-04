using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PaymentsAPI.Models
{
    public class VerifyPaymentReq
    {

        public static bool ShouldPaymentProcess(ReqProp req)
        {
            if (!string.IsNullOrEmpty(req.creditCardNo) && !string.IsNullOrEmpty(req.cardHolder) && 
                (!string.IsNullOrEmpty(req.expirationDate.ToString()) && req.expirationDate > DateTime.Now) &&
                req.amount > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}