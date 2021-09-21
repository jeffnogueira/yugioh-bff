using System.Collections.Generic;
using System.Threading.Tasks;
using yugioh_bff.Application.Models;

namespace yugioh_bff.Application.UseCases
{
    public interface ICardUseCase
    {
        Task<IEnumerable<CardResponse>> GetCards(CardRequest resquest);
    }
}
