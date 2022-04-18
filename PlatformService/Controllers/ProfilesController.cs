using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PlatformService.Data;
using PlatformService.Dtos;

namespace PlatformService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfilesController : ControllerBase
    {
        private readonly IProfileRepo _repository;
        private readonly IMapper _mapper;

        public ProfilesController(IProfileRepo repository, AutoMapper.IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        [HttpGet]
        public ActionResult<IEnumerable<ProfileReadDtos>> GetProfiles()
        {
            Console.WriteLine("---> Getting Profiles");
            var profileItems = _repository.GetAllProfiles();

            return Ok(_mapper.Map<IEnumerable<ProfileReadDtos>>(profileItems));
        }
        [HttpGet("{id}", Name = "GetProfileById")]
        public ActionResult<ProfileReadDtos> GetProfileById(Guid id)
        {
            Console.WriteLine("---> Getting Profile by [d");
            var profileItem = _repository.GetProfileById(id);
            if (profileItem == null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<ProfileReadDtos>(profileItem));
        }
        [HttpPost]
        public ActionResult<ProfileReadDtos> CreateProfile([FromBody] ProfileCreateDtos profileCreateDtos)
        {
            Console.WriteLine("---> Create Profile");
            Models.Profile profileModel = _mapper.Map<Models.Profile>(profileCreateDtos);
            _repository.CreateProfile(profileModel);
            _repository.SaveChanges();
            var profileDtoCreated = _mapper.Map<ProfileReadDtos>(profileModel);
            if (profileModel.Name == null)
            {              
                return BadRequest("Not a good profile data");
            }
            return Ok(profileDtoCreated); 
        }   
    }
}
