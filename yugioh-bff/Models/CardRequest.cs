using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace yugioh_bff.Models
{
    public class CardRequest
    {
        public int id { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string desc { get; set; }
        public int atk { get; set; }
        public int def { get; set; }

        [Range(1, 12)]
        public int level { get; set; }
        public string race { get; set; }
        public string attribute { get; set; }

        public string archetype { get; set; }

        [Range(1, 12)]
        public int scale { get; set; }

        [Range(1, 8)]
        public int linkval { get; set; }
        public IEnumerable<string> linkmarkers { get; set; }
        public BanListRequest banlist_info { get; set; }
        public IEnumerable<SetRequest> card_sets { get; set; }
        public IEnumerable<ImageRequest> card_images { get; set; }
        public IEnumerable<PriceRequest> card_prices { get; set; }

        public CardRequest()
        {

        }
    }
}
