using AutoMapper;
using Business.Abstract;
using Entities.Concrete;
using Entities.Concrete.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PossibleCustomersController : ControllerBase
    {
        public IPossibleCustomerService _possibleCustomerService;
        public readonly IMapper _mapper;

        public PossibleCustomersController(IPossibleCustomerService possibleCustomerService, IMapper mapper)
        {
            _possibleCustomerService = possibleCustomerService;
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult AddPossibleCustomer(PossibleCustomerDto possibleCustomer)
        {
            var _mappedPossibleCustomer = _mapper.Map<PossibleCustomer>(possibleCustomer);
            var result = _possibleCustomerService.Add(_mappedPossibleCustomer);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getall")]
        public IActionResult Get()
        {
            var result = _possibleCustomerService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
