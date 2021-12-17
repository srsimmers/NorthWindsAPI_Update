using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NorthWindsAPI_Update.Models
{
    public class Product_Model
    {
        [Key]
        [Column(name: "ProductID", TypeName = "int")]
        public int ProductId { get; set; }

        [Column(name: "ProductName", TypeName = "nvarchar(40)")]
        public string ProductName { get; set; }

        [Column(name: "SupplierID", TypeName = "int")]
        public int SupplierId { get; set; }


        [Column(name: "CategoryID", TypeName = "nvarchar(20)")]
        public string CategoryId { get; set; }


        [Column(name: "QuantityPerUnit", TypeName = "nvarchar(20)")]
        public string QuantityPerUnit { get; set; }

        [Column(name: "")]
        public string company_name { get; set; }
        public double unit_price { get; set; }
        public int units_in_stock { get; set; }
    }
}
