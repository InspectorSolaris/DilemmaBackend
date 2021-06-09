using Dilemma.Common.Dtos;
using Dilemma.Common.Interfaces;
using Dilemma.DAL.Context;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Dilemma.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DilemmaController : ControllerBase
    {
        private readonly DilemmaDbContext _context;

        private readonly IStatisticsService _statisticsService;

        private readonly IAnswerService _answerService;

        private readonly IWebHostEnvironment _webHostEnvironment;

        private readonly IConfiguration _configuration;

        public DilemmaController(
            DilemmaDbContext context,
            IStatisticsService statisticsService,
            IAnswerService answerService,
            IWebHostEnvironment webHostEnvironment,
            IConfiguration configuration)
        {
            _context = context;
            _statisticsService = statisticsService;
            _answerService = answerService;
            _webHostEnvironment = webHostEnvironment;
            _configuration = configuration;
        }

        [HttpGet("test")]
        public async Task<IActionResult> Test()
        {
            var dilemmas = await _context.Dilemmas
                .Select(x => new DilemmaDto()
                {
                    Id = x.Id,
                    Text = x.Text
                })
                .ToListAsync();

            var solutions = await _context.Solutions
                .Select(x => new SolutionDto()
                {
                    Id = x.Id,
                    DilemmaId = x.DilemmaId,
                    Text = x.Text,
                    Rate = x.Rate
                })
                .ToListAsync();

            return new JsonResult(new TestDto()
            {
                Dilemmas = dilemmas,
                Solutions = solutions
            });
        }

        [HttpGet("statistics")]
        public async Task<IActionResult> Statistics()
        {
            return new JsonResult(await _statisticsService.Get());
        }

        [HttpPost("answers")]
        public async Task<IActionResult> Answers([FromBody] IEnumerable<Guid> solutionsIds)
        {
            return new JsonResult(await _answerService.ProcessNewAnswersAsync(solutionsIds));
        }

        [HttpGet("solution-image/{id}")]
        public async Task<IActionResult> SolutionImage([FromRoute(Name = "id")] Guid solutionId)
        {
            var solution = await _context.Solutions.FirstOrDefaultAsync(x => x.Id == solutionId);

            if (solution == null)
            {
                return NotFound();
            }

            var path = $"{_webHostEnvironment.WebRootPath}{Path.DirectorySeparatorChar}{_configuration["Path:Images"]}{Path.DirectorySeparatorChar}{solution.Image}";
            var stream = System.IO.File.OpenRead(path);

            return File(stream, "image/jpeg");
        }
    }
}
