using Application.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyProyecto.CMD;
using MyProyecto.CMD.Entidades;
using Web.API.Requests;

namespace Web.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private ICustomerRepository _repository;
        public CustomerController(ICustomerRepository repository)
        {
            _repository = repository;
        }

        [HttpGet("{id}")]
        public ActionResult<IEnumerable<Customer>> Get(int id)
        {
            return Ok(_repository.Get(id));
        }

        [HttpPost("add")]
        public ActionResult<IEnumerable<Customer>> post([FromBody] CustomerAddRequest CustomerRequest)
        {
            Customer customer = new Customer();
            customer.CuilCuit = CustomerRequest.CuilCuit;
            customer.Email=CustomerRequest.Email;
            customer.Status=CustomerRequest.Status;
            customer.DocumentNumber=CustomerRequest.DocumentNumber; 
            customer.EmailConfirmed=CustomerRequest.EmailConfirmed;
            customer.LastName=CustomerRequest.LastName;
            customer.Name=CustomerRequest.Name;
            _repository.Add(customer);
            return Ok(customer);
        }
        [HttpPatch("update")]
        public ActionResult<IEnumerable<Customer>> update([FromBody] CustomerUpdateRequest customerUpdateRequest)
        {
            Customer customer=_repository.Get(customerUpdateRequest.Id);
            if (customer ==null)
            {
                return BadRequest("El id ingresado no existe");
            }
            customer.CuilCuit=customerUpdateRequest.CuilCuit!=null ? customerUpdateRequest.CuilCuit:customer.CuilCuit;
            customer.DocumentNumber = customerUpdateRequest.DocumentNumber != null ? customerUpdateRequest.DocumentNumber : customer.DocumentNumber;
            customer.Email = customerUpdateRequest.Email != null ? customerUpdateRequest.Email : customer.Email;
            customer.EmailConfirmed = customerUpdateRequest.EmailConfirmed != null ? customerUpdateRequest.EmailConfirmed : customer.EmailConfirmed;
            customer.Name = customerUpdateRequest.Name != null ? customerUpdateRequest.Name : customer.Name;
            customer.LastName = customerUpdateRequest.LastName != null ? customerUpdateRequest.LastName : customer.LastName;
            customer.Status = customerUpdateRequest.Status != null ? customerUpdateRequest.Status : customer.Status;
            _repository.Update(customer);
            return Ok(customer);

        }

        [HttpDelete("delete/{id}")]
        public ActionResult<IEnumerable<Customer>> delete(int id)
        {
            _repository.Delete(id);
            return Ok("Se elimino el id "+ id);
        }
    }

  
}
