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
    public class ForeignInvestorsController : ControllerBase
    {
        public IForeignInvestorService _foreignInvestorService;
        public readonly IMapper _mapper;
        public ForeignInvestorsController(IForeignInvestorService foreignInvestorService, IMapper mapper)
        {
            _foreignInvestorService = foreignInvestorService;
            _mapper = mapper;
        }
        [HttpPost]
        public IActionResult AddForeignInvestor(ForeignInvestorDto foreignInvestor)
        {
            var _mappedCustomer = _mapper.Map<ForeignInvestor>(foreignInvestor);

            var result = _foreignInvestorService.Add(_mappedCustomer);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getall")]
        public IActionResult Get()
        {
            var result = _foreignInvestorService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("delete")]
        public IActionResult Delete(string Id)
        {
            var result = _foreignInvestorService.Delete(Id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
