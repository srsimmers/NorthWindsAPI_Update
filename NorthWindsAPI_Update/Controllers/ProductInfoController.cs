using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NorthWindsAPI_Update.Data;
using NorthWindsAPI_Update.Models;

namespace NorthWindsAPI_Update.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductInfoController : ControllerBase
    {
        private Northwind _dbContext;

        public ProductInfoController(Northwind dbContext)
        {
            _dbContext = dbContext; 
        }

        [HttpGet("GetProduct")]
        public IActionResult Get()
        {
            try
            {
                var products = _dbContext.Products.ToList();
                return Ok(products);
            }
            catch (Exception)
            {
                return StatusCode(500, "An error has occured");
            }


            
        }

        [HttpPost("PlaceOrder")]
        public IActionResult Create([FromBody] Cust_Model request)
        {

            Cust_Model order = new Cust_Model();
            order.Order_Id = request.Order_Id;
            order.Customer_Id = request.Customer_Id;
            order.Ship_Name = request.Ship_Name;
            order.Ship_Address = request.Ship_Address;
            order.Ship_City = request.Ship_City;
            order.Ship_Region = request.Ship_Region;
            order.Ship_Postal_Code = request.Ship_Postal_Code;
            order.Ship_Country = request.Ship_Country;
            order.Product_Id = request.Product_Id;
            order.Unit_Price = request.Unit_Price;
            order.Quantity = request.Quantity;
            order.Discount = request.Discount;

            try
            {
                _dbContext.Cust_Model.Add(order);
                _dbContext.SaveChanges();

            }
            catch (Exception)
            {

                return StatusCode(500, "An error has occured");
            }

            var orders = _dbContext.Cust_Model.ToList();
            return Ok(orders); 

        }

    }

}
