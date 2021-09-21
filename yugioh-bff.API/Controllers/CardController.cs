using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using yugioh_bff.Application.Models;
using yugioh_bff.Application.UseCases;

namespace yugioh_bff.API.Controllers
{
    [Route("card/v1")]
    [ApiController]
    public class CardController : ControllerBase
    {
        private readonly ICardUseCase iCardUseCase;

        public CardController(
            ICardUseCase iCardUseCase
        )
        {
            this.iCardUseCase = iCardUseCase;
        }

        [Route("")]
        [HttpGet]
        [ProducesResponseType(typeof(CardResponse), 200)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        public async Task<ActionResult> GetCards()
        {
            return Ok(await iCardUseCase.GetCards(new CardRequest()));
        }
    }
}
