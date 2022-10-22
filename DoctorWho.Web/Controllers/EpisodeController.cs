using AutoMapper;
using DoctorWho.Web.Models;
using DoctorWho.Web.Services;
using Microsoft.AspNetCore.Mvc;

namespace DoctorWho.Web.Controllers
{
    [Route("api/episode")]
    [ApiController]
    public class EpisodeController : ControllerBase
    {
        private readonly IEpisodeService _episodeService;
        private readonly IMapper _mapper;

        public EpisodeController(IEpisodeService episodeService, IMapper mapper)
        {
            _episodeService = episodeService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<List<EpisodeDto>>> GetAllEpisodes()
        {
            return Ok(await _episodeService.GetAllEpisodesAsync());
        }
        //TODO validate if author and doctor exist, if not not send 400 response.
        [HttpPost]
        public async Task<ActionResult<int>> CreateEpisode([FromBody] EpisodeCreationDto episodeCreationDto)
        {
            EpisodeDto episodeDto = await _episodeService.CreateEpisode(_mapper.Map<EpisodeDto>(episodeCreationDto));
            return Ok(episodeDto.Id);
        }
    }
}