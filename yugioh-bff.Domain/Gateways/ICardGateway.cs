using System.Collections.Generic;
using System.Threading.Tasks;
using yugioh_bff.Domain.Entities;

namespace yugioh_bff.Domain.Gateways
{
    public interface ICardGateway
    {
        Task<IEnumerable<Card>> GetCards();
    }
}
