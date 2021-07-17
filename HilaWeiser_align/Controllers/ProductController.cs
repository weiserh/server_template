using align_bl;
using HilaWeiser_align.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HilaWeiser_align.Controllers
{

    [EnableCors("UserPolicy")]
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        public IManager _manager { get; set; }
        public ProductController(IManager manager)
        {
            _manager = manager;
        }

        // GET: api/<ProductController>
        [HttpGet]
        public async Task<Response<List<Product>>> Get()
        {
            Response<List<Product>> response = new Response<List<Product>>();

            List<Product> products = await _manager.GetProducts();

            if (products != null)
            {
                response.SetSuccess(products);
            }
            else
            {
                response.SetFail("Fail to get");
            }
            return response;
        }

        // GET api/<ProductController>/5
        [HttpGet("{id}")]
        public async Task<Response<Product>> Get([FromQuery] int id)
        {
            Response<Product> response = new Response<Product>();

            Product product = (await _manager.GetProducts())[0];

            if (product != null)
            {
                response.SetSuccess(product);
            }
            else
            {
                response.SetFail("Fail to get");
            }
            return response;
        }

        // POST api/<ProductController>
        [HttpPost]
        public async Task<Response<int>> Post([FromBody] Product product)
        {
            Response<int> response = new Response<int>();
            
            int newProduct = await _manager.AddProduct(product);

            if (newProduct > 0)
            {
                response.SetSuccess(newProduct);
            }
            else
            {
                response.SetFail("Fail to add");
            }
            return response;
        }

        // PUT api/<ProductController>/5
        [HttpPut]
        public async Task<Response<bool>> Put([FromBody] Product product)
        {
            Response<bool> response = new Response<bool>();

            bool isSuccess = await _manager.UpdateProduct(product);
            if (isSuccess)
            {
                response.IsSuccess = true;
            }
            else
            {
                response.SetFail("Fail to update");
            };
            return response;
        }

        // DELETE api/<ProductController>/5
        [HttpDelete("{id}")]
        public async Task<Response<bool>> Delete([FromQuery] int id)
        {
            Response<bool> response = new Response<bool>();

            bool isSuccess = await _manager.DeleteProduct(id);

            if (isSuccess)
            {
                response.IsSuccess = true;
            }
            else
            {
                response.SetFail($"Fail to delete {id}");
            }
            return response;
        }
    }
}
