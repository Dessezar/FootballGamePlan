using FootballGamePlan.Api;
using FootballGamePlan.Api.Data;
using FootballGamePlan.Api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MyApp.Namespace
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlaysController : ControllerBase
    {
        private readonly AppDbContext _context;

        public PlaysController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> CreatePlay([FromBody] CreatePlayDto dto)
        {
            var play = new Play
            {
                Name = dto.Name,
                IsPass = dto.IsPass
            };

            _context.Plays.Add(play);
            await _context.SaveChangesAsync();

            return Ok(play);
        }

        [HttpGet]
        public async Task<IActionResult> GetPlays()
        {
            var plays = await _context.Plays.ToListAsync();
            return Ok(plays);
        }
    }
}
