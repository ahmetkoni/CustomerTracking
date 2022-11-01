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
    public class RoutineServicesController : ControllerBase
    {
        public IRoutineServiceService _routineService;
        public readonly IMapper _mapper;

        public RoutineServicesController(IRoutineServiceService routineService, IMapper mapper)
        {
            _routineService = routineService;
            _mapper = mapper;
        }
        [HttpPost]
        public IActionResult AddRoutineService(RoutineServiceDto routineService)
        {
            var _mappedServiceRoutine = _mapper.Map<RoutineService>(routineService);
            var result = _routineService.Add(_mappedServiceRoutine);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getall")]
        public IActionResult Get()
        {
            var result = _routineService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("delete")]
        public IActionResult Delete(string Id)
        {
            var result = _routineService.Delete(Id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("update")]
        public IActionResult Update(RoutineService routineService)
        {
            var result = _routineService.Update(routineService);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
