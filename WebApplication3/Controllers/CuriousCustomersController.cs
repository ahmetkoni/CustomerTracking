using AutoMapper;
using Business.Abstract;
using Entities.Concrete;
using Entities.Concrete.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CuriousCustomersController : ControllerBase
    {
        public ICuriousCustomerService _curiousCustomerService;
        public readonly IMapper _mapper;
        public CuriousCustomersController(
            IMapper mapper,
            ICuriousCustomerService curiousCustomerService)
        {
            _mapper = mapper;
            _curiousCustomerService = curiousCustomerService;
        }
        [HttpPost]
        public IActionResult AddCuriousCustomer(CuriousCustomerDto curiousCustomer)
        {
            var _mappedCuriousCustomer = _mapper.Map<CuriousCustomer>(curiousCustomer);

            var result = _curiousCustomerService.Add(_mappedCuriousCustomer);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getall")]
        public IActionResult Get()
        {
            var result = _curiousCustomerService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("delete")]
        public IActionResult Delete(string Id)
        {
            var result = _curiousCustomerService.Delete(Id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("update")]
        public IActionResult Update(CuriousCustomer curiousCustomer)
        {
            var result = _curiousCustomerService.Update(curiousCustomer);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
