using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using yugioh_bff.Enums;

namespace yugioh_bff.Entities
{
    public class Card {
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
        private BanList banlist_info { get; set; }
        private IEnumerable<Set> card_sets { get; set; }
        private IEnumerable<Image> card_images { get; set; }
        private IEnumerable<Price> card_prices { get; set; }

    }
}
