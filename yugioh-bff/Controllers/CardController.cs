using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using yugioh_bff.Models;
using yugioh_bff.Services;

namespace yugioh_bff.Controllers
{
    [Route("card/v1")]
    [ApiController]
    public class CardController : ControllerBase
    {
        private readonly CardService _cardService;

        public CardController(
            CardService cardService
        )
        {
            this._cardService = cardService;
        }

        [Route("")]
        [HttpGet]
        [ProducesResponseType(typeof(DataCardResponse), 200)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        public IActionResult GetCards([FromQuery] string fname)
        {
            return Ok(this._cardService.GetAllCards(fname).Result);
        }
    }
}
