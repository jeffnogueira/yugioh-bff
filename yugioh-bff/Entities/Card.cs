using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace yugioh_bff.Entities
{
    public class Card {
        private int id { get; set; }
        private string name { get; set; }
        private string type { get; set; }
        private string desc { get; set; }
        private int atk { get; set; }
        private int def { get; set; }

        [Range(1, 12)]
        private int level { get; set; }
        private string race { get; set; }
        private string attribute { get; set; }

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
