using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using yugioh_bff.Domain.Enums;

namespace yugioh_bff.Application.Models
{
    public class CardRequest
    {
        private int id { get; set; }
        private string name { get; set; }

        [JsonConverter(typeof(JsonStringEnumConverter))]
        private CardType type { get; set; }
        private string desc { get; set; }
        private int atk { get; set; }
        private int def { get; set; }

        [Range(1, 12)]
        private int level { get; set; }

        [JsonConverter(typeof(JsonStringEnumConverter))]
        private CardRace race { get; set; }

        [JsonConverter(typeof(JsonStringEnumConverter))]
        private CardAttribute attribute { get; set; }

        private string archetype { get; set; }

        [Range(1, 12)]
        private int scale { get; set; }

        [Range(1, 8)]
        private int linkval { get; set; }
        private IEnumerable<string> linkmarkers { get; set; }
        private BanListRequest banlist_info { get; set; }
        private IEnumerable<SetRequest> card_sets { get; set; }
        private IEnumerable<ImageRequest> card_images { get; set; }
        private IEnumerable<PriceRequest> card_prices { get; set; }

        public CardRequest()
        {

        }

        public CardRequest(
            int id,
            string name,
            CardType type,
            string desc,
            int atk,
            int def,
            int level,
            CardRace race,
            CardAttribute attribute,
            string archetype,
            int scale,
            int linkval,
            IEnumerable<string> linkmarkers,
            BanListRequest banlist_info,
            IEnumerable<SetRequest> card_sets,
            IEnumerable<ImageRequest> card_images,
            IEnumerable<PriceRequest> card_prices
        )
        {
            this.id = id;
            this.name = name;
            this.type = type;
            this.desc = desc;
            this.atk = atk;
            this.def = def;
            this.level = level;
            this.race = race;
            this.attribute = attribute;
            this.archetype = archetype;
            this.scale = scale;
            this.linkval = linkval;
            this.linkmarkers = linkmarkers;
            this.banlist_info = banlist_info;
            this.card_sets = card_sets;
            this.card_images = card_images;
            this.card_prices = card_prices;
        }
    }
}
