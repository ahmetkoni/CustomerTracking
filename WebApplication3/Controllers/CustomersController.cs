using AutoMapper;
using Business.Abstract;
using Entities.Concrete;
using Entities.Concrete.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        public ICustomerService _customerService;
        public readonly IMapper _mapper;
        public CustomersController(
            IMapper mapper,
            ICustomerService customerService)
        {
            _mapper = mapper;
            _customerService = customerService;
        }
        [HttpPost]
        public IActionResult AddCustomer(CustomerDto customer)
        {
            var _mappedCustomer = _mapper.Map<Customer>(customer);

            var result = _customerService.Add(_mappedCustomer);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getall")]
        public IActionResult Get()
        {
            var result = _customerService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("delete")]
        public IActionResult Delete(string Id)
        {
            var result = _customerService.Delete(Id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("update")]
        public IActionResult Update(Customer customer)
        {
            var result = _customerService.Update(customer);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}



//    var customer = new Customer
//    {
//        BuyProductDate = customerdto.BuyProductDate,
//        CompanyAddress = customerdto.CompanyAddress,
//        CompanyName = customerdto.CompanyName,
//        CompanyWebAddress = customerdto.CompanyWebAddress,
//        CompanyWorkSpace = customerdto.CompanyWorkSpace,
//        EndProductDate = customerdto.EndProductDate,
//        LicenseTime = customerdto.LicenseTime,
//        ManagerEMail = customerdto.ManagerEMail,
//        ManagerName = customerdto.ManagerName,
//        ManagerPhone = customerdto.ManagerPhone,
//        Note = customerdto.Note,
//        Price = customerdto.Price,
//        ProductId = customerdto.ProductId,
//        Version = customerdto.Version
//    };
//    var result = _customerService.Add(customer);
//            if (result.Success)
//            {
//                return Ok(result);
//}
//return BadRequest(result);
//        }
//    }
//}
