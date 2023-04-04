using Microsoft.AspNetCore.Mvc;
using SpeakEasyReal.Models;
using SpeakEasyReal.Interfaces;

namespace SpeakEasyReal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SoundController : Controller
    {
        private readonly ISound _soundRepo;
        public SoundController(ISound soundRepository)
        {
            _soundRepo = soundRepository;
        }

        // Get
        [HttpGet]
        public List<Sound> GetAllSounds()
        {
            return _soundRepo.GetAllSounds();
        }

        // Get by Id
        [HttpGet("{id}")]
        public Sound GetSoundById(int id)
        {
            return _soundRepo.GetSoundById(id);
        }
        
        // Post
        [HttpPost("postSound")]
        public IActionResult CreateSound(Sound sound)
        {
            var newSound = _soundRepo.CreateSound(sound);
            return Ok(newSound);
        }

        // Update
        [HttpPut("updateSound/{id}")]
        public IActionResult UpdateSound(Sound sound)
        {
            _soundRepo.UpdateSound(sound);
            return NoContent();
        }

        // Delete
        [HttpDelete("deleteSound/{id}")]
        public void DeleteSound(int id)
        {
            _soundRepo.DeleteSound(id);
        }

    }
}
