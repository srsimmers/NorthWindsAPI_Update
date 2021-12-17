using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NorthWindsAPI_Update.Models
{
    public class Cust_Model
    {
        [Key]
        [Column(name: "order_id", TypeName = "int")]
        public int Order_Id { get; set; }

        [Column(name: "customer_id", TypeName = "int")]
        public int Customer_Id { get; set; }

        [Column(name: "ship_name", TypeName = "nvarchar(40)")]
        public string Ship_Name { get; set; }


        [Column(name: "ship_address", TypeName = "nvarchar(40)")]
        public string Ship_Address { get; set; }


        [Column(name: "ship_city", TypeName = "nvarchar(40)")]
        public string Ship_City { get; set; }


        [Column(name: "ship_region", TypeName = "nvarchar(40)")]
        public string Ship_Region { get; set; }


        [Column(name: "ship_postal_code", TypeName = "int")]
        public int Ship_Postal_Code { get; set; }

        [Column(name: "ship_country", TypeName = "nvarchar(40)")]
        public string Ship_Country { get; set; }





        [Column(name: "product_id", TypeName = "int")]
        public int Product_Id { get; set; }

        [Column(name: "unit_price", TypeName = "int")]
        public int Unit_Price { get; set; }

        [Column(name: "quantity", TypeName = "int")]
        public int Quantity { get; set; }

        [Column(name: "discount", TypeName = "int")]
        public int Discount { get; set; }

    }
}
