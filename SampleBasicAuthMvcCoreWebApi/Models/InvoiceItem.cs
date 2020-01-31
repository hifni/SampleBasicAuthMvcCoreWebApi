using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleBasicAuthMvcCoreWebApi.Models
{
    public class InvoiceItem
    {
        public int InvoiceId { get; set; }
        public decimal InvoiceValue { get; set; }
    }
}
