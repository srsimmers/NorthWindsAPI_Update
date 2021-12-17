using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NorthWindsAPI_Update.Data
{
    public class Products_Data
    {
        [Key] 
        public int ProductId { get; set; }

        public string ProductName { get; set; }

        public int SupplierId { get; set; }

        public string CategoryId { get; set; }
       
        public string QuantityPerUnit { get; set; }

        public string company_name { get; set; }
        public double unit_price { get; set; }
        public int units_in_stock { get; set; }
    }
}
