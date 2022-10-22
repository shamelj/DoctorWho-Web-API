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
        private readonly IEnemyService _enemyService;
        private readonly IMapper _mapper;
        private readonly ICompanionService _companionService;

        public EpisodeController(IEpisodeService episodeService, IMapper mapper, IEnemyService enemyService)
        {
            _episodeService = episodeService;
            _mapper = mapper;
            _enemyService = enemyService;
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

        [HttpPost("{episodeId:int}/enemy/{enemyId:int}")]
        public async Task<ActionResult> AddEnemyToEpisode([FromRoute] int episodeId,[FromRoute] int enemyId)
        {
            if ( ! await _episodeService.ExistsAsync(episodeId) || ! await _enemyService.EnemyExists(enemyId))
                return BadRequest();
            await _episodeService.AddEnemyToEpisode(episodeId, enemyId);
            return Ok();
        }
        [HttpPost("{episodeId:int}/companion/{companionId:int}")]
        public async Task<ActionResult> AddCompanionToEpisode([FromRoute] int episodeId,[FromRoute] int companionId)
        {
            if ( ! await _episodeService.ExistsAsync(episodeId) || ! await _companionService.Exists(companionId) )
                return BadRequest();
            await _episodeService.AddCompanionToEpisode(episodeId, companionId);
            return Ok();
        }
    }
}