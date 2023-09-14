using ECom.Domain.Entities;
using ECom.Domain.Interface;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EComAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        public readonly IUnitOfWork UnitOfWork;
        public ProductController(IUnitOfWork unitOfWork)
        {
                this.UnitOfWork = unitOfWork;
        }
        // GET: api/<ProductController>
        [HttpGet]
        public IEnumerable<Product> GetAllProducts()
        {
            return this.UnitOfWork.productRepository.GetAll();
        }

        // GET api/<ProductController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ProductController>
        [HttpPost]
        public IActionResult PostProduct([FromBody] Product product)
        {
            this.UnitOfWork.productRepository.Add(product);
            this.UnitOfWork.Complete();
            return Ok();
        }

        // PUT api/<ProductController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ProductController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
