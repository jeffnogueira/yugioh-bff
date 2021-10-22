namespace yugioh_bff.Models
{
    public class SetRequest
    {
        public string set_name { get; set; }
        public string set_code { get; set; }
        public string set_rarity { get; set; }
        public string set_rarity_code { get; set; }
        public string set_price { get; set; }

        public SetRequest()
        {

        }
    }
}
