using AutoMapper;
using yugioh_bff.Models;

namespace yugioh_bff.Profiles
{
    public class CardProfile : Profile
    {
        public CardProfile()
        {
            CreateMap<CardRequest, CardResponse>();
        }
    }
}
