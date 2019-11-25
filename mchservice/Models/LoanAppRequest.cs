using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CemesWebService.Models
{
    public class LoanAppRequest
    {
       public string phone { get; set; }
      public  string borrow_amount { get; set; }
     public   string frequency { get; set; }

     public   string ProductId { get; set; }

    }
}
