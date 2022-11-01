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
    public class InvestorsController : ControllerBase
    {
        public IInvestorService _investorService;
        public readonly IMapper _mapper;

        public InvestorsController(IInvestorService investorService, IMapper mapper)
        {
            _investorService = investorService;
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult AddInvestor(InvestorDto investor)
        {
            var _mappedInvestor = _mapper.Map<Investor>(investor);
            var result = _investorService.Add(_mappedInvestor);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getall")]
        public IActionResult Get()
        {
            var result = _investorService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("delete")]
        public IActionResult Delete(string Id)
        {
            var result = _investorService.Delete(Id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

    }
}
