using DaresGacha.Dtos.Dare;
using DaresGacha.Services;
using Microsoft.AspNetCore.Mvc;

namespace DaresGacha.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DareController : ControllerBase
    {
        private readonly IDareService _dareService;

        public DareController(IDareService dareService)
        {
            _dareService = dareService;
        }


        [HttpPost]
        public async Task<IActionResult> Add(DareAddDto newDare)
        {
            var response = await _dareService.Add(newDare);
            if (response.Success == true)
                return Ok(response.Data);
            return (BadRequest(response.Exception));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var response = await _dareService.Delete(id);
            if (response.Success == true)
                return Ok();
            return (BadRequest(response.Exception));
        }

        [HttpGet]
        public async Task<IActionResult> GetAll(int? lvl = null, bool? done = null, bool? isDeleted = null)
        {
            var response = await _dareService.GetAll(lvl, done, isDeleted);
            if (response.Success == true)
                return Ok(response.Data);
            return (BadRequest(response.Exception));
        }

        [HttpGet("random")]
        public async Task<IActionResult> GetRandom()
        {
            var response = await _dareService.GetRandom();
            if (response.Success == true)
                return Ok(response.Data);
            return (BadRequest(response.Exception));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateLvl(int id, DareUpdateDto newDare)
        {
            newDare.Id = id;
            var response = await _dareService.Update(newDare);

            if (response.Success == true)
                return Ok();
            return (BadRequest(response.Exception));
        }

        [HttpPut("{id}/done")]
        public async Task<IActionResult> Done(int id, DareDoneDto done)
        {
            done.Id = id;
            var response = await _dareService.Done(done);

            if (response.Success == true)
                return Ok();
            return (BadRequest(response.Exception));
        }
    }
}