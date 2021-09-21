using AutoMapper;
using System.Collections.Generic;
using yugioh_bff.Application.Models;
using yugioh_bff.Domain.Gateways;
using System.Threading.Tasks;
using yugioh_bff.Domain.Entities;

namespace yugioh_bff.Application.UseCases
{
    public class CardUseCaseAsync : ICardUseCase
    {
        private readonly ICardGateway iCardGateway;
        private readonly IMapper iMapper;

        public CardUseCaseAsync(
            ICardGateway iCardGateway,
            IMapper iMapper
        )
        {
            this.iCardGateway = iCardGateway;
            this.iMapper = iMapper;
        }

        public async Task<IEnumerable<CardResponse>> GetCards(CardRequest request)
        {
            IEnumerable<Card> cards = await iCardGateway.GetCards();

            IEnumerable<CardResponse> list = iMapper.Map<IEnumerable<CardResponse>>(cards);

            return list;
        }
    }
}
