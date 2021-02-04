using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace PaymentsAPI.Models
{
    public class PaymentDBContext : DbContext
    {
        public DbSet<PaymentState> paymentStates { get; set; }
        public DbSet<ReqProp> reqProps { get; set; }

    }
}