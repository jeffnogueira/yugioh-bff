using System.Collections.Generic;

namespace yugioh_bff.Models
{
    public class DataCardResponse
    {
        public IEnumerable<CardRequest> data { get; set; }
        public DataCardResponse()
        {

        }
    }
}
