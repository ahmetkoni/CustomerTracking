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
    public class SessionsController : ControllerBase
    {
        public ISessionService _sessionService;
        public readonly IMapper _mapper;

        public SessionsController(ISessionService sessionService, IMapper mapper)
        {
            _sessionService = sessionService;
            _mapper = mapper;
        }
        [HttpPost]
        public IActionResult AddSessionService(SessionDto session)
        {
            var _mappedSession = _mapper.Map<Session>(session);
            var result = _sessionService.Add(_mappedSession);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }
    }
}
