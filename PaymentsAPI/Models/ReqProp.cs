using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PaymentsAPI.Models
{
    public class ReqProp
    {
        [Key,Required]
        public string creditCardNo { get; set; }
        [Required]
        public string cardHolder { get; set; }
        [Required]
        public DateTime expirationDate { get; set; }
        public string securityCode { get; set; }
        [Required,Range(1,double.MaxValue)]
        public double amount { get; set; }

        PaymentState PaymentState { get; set; }
    }
}