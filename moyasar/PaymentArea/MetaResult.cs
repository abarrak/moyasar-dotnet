﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace moyasar.PaymentArea
{
   public class MetaResult:PaymentResultBase
    {
       public string CurrentPage { get; set; }
       public string NextPage { get; set; }
       public string PrevPage { get; set; }
       public string TotalPages { get; set; }
       public string TotalCount { get; set; }
    }
}
