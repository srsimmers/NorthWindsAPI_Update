using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace NorthWindsAPI_Update.Data
{
    public class Cust_Data
    {
        [Key]
        public int Order_Id { get; set; }

        public int Customer_Id { get; set; }
      
        public string Ship_Name { get; set; }

        public string Ship_Address { get; set; }

        public string Ship_City { get; set; }
        public string Ship_Region { get; set; }

        public int Ship_Postal_Code { get; set; }
        public string Ship_Country { get; set; }

        public int Product_Id { get; set; }


        public int Unit_Price { get; set; }

  
        public int Quantity { get; set; }

        public int Discount { get; set; }
    }
}
