using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using yugioh_bff.Enums;

namespace yugioh_bff.Models
{
    public class CardRequest
    {
        private int id { get; set; }
        private string name { get; set; }

        private string type { get; set; }
        private string desc { get; set; }
        private int atk { get; set; }
        private int def { get; set; }

        private int level { get; set; }

        private string race { get; set; }

        private string attribute { get; set; }

        private string archetype { get; set; }

        private int scale { get; set; }

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
            string type,
            string desc,
            int atk,
            string race,
            string attribute,
            string archetype,
            int linkval,
            IEnumerable<string> linkmarkers
        )
        {
            this.id = id;
            this.name = name;
            this.type = type;
            this.desc = desc;
            this.atk = atk;
            this.race = race;
            this.attribute = attribute;
            this.archetype = archetype;
            this.linkval = linkval;
            this.linkmarkers = linkmarkers;
        }

        public CardRequest(
            int id,
            string name,
            string type,
            string desc,
            int atk,
            int def,
            int level,
            string race,
            string attribute,
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
