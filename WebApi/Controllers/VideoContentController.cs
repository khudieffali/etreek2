using AutoMapper;
using Business.Abstract;
using Entities.Concrete;
using Entities.Concrete.DTOs;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VideoContentController : ControllerBase
    {
        IVideoContentService _service;
        private readonly IMapper _mapper;

        public VideoContentController(IVideoContentService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        // GET: api/<VideoContentController>
        [HttpGet("videos/{courseId}")]
        public async Task<IEnumerable<VideoContentDTO>> Get(int? courseId)
        {
            var videoContents = await _service.GetVideoContents(courseId);
            var _mapperVideoContents=_mapper.Map<List<VideoContent>,List<VideoContentDTO>>(videoContents);
            return _mapperVideoContents;
        }

        // GET api/<VideoContentController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<VideoContentController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<VideoContentController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<VideoContentController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
