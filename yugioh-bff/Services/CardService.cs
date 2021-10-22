using AutoMapper;
using yugioh_bff.Models;
using System.Net.Http;
using System.Threading.Tasks;

namespace yugioh_bff.Services
{
    public class CardService
    {
        private IMapper _mapper;
        static HttpClient httpClient = new HttpClient();

        public CardService(IMapper mapper)
        {
            _mapper = mapper;
        }

        public async Task<DataCardResponse> GetAllCards(string fname)
        {
            DataCardResponse dataCards = new DataCardResponse();
            HttpResponseMessage response = await httpClient.GetAsync("https://db.ygoprodeck.com/api/v7/cardinfo.php?fname=" + fname);

            dataCards = await response.Content.ReadAsAsync<DataCardResponse>();

            return _mapper.Map<DataCardResponse>(dataCards);
        }
    }
}
