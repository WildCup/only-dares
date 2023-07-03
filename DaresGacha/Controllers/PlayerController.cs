using DaresGacha.Dtos.Player;
using DaresGacha.Services;
using Microsoft.AspNetCore.Mvc;

namespace DaresGacha.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PlayerController : ControllerBase
    {
        private readonly IPlayerService _playerService;

        public PlayerController(IPlayerService playerService)
        {
            _playerService = playerService;
        }


        [HttpPost]
        public async Task<IActionResult> Add(PlayerAddDto newPlayer)
        {
            var response = await _playerService.Add(newPlayer);
            if (response.Success == true)
                return Ok(response.Data);
            return (BadRequest(response.Exception));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var response = await _playerService.Delete(id);
            if (response.Success == true)
                return Ok();
            return (BadRequest(response.Exception));
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var response = await _playerService.GetAll();
            if (response.Success == true)
                return Ok(response.Data);
            return (BadRequest(response.Exception));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateLvl(int id, PlayerUpdateDto newPlayer)
        {
            newPlayer.Id = id;
            var response = await _playerService.Update(newPlayer);

            if (response.Success == true)
                return Ok();
            return (BadRequest(response.Exception));
        }
    }
}