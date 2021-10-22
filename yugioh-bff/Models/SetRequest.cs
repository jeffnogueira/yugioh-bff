namespace yugioh_bff.Models
{
    public class SetRequest
    {
        private string set_name { get; set; }
        private string set_code { get; set; }
        private string set_rarity { get; set; }
        private string set_rarity_code { get; set; }
        private string set_price { get; set; }

        public SetRequest()
        {

        }

        public SetRequest(
            string set_name,
            string set_code,
            string set_rarity,
            string set_rarity_code,
            string set_price
        )
        {
            this.set_name = set_name;
            this.set_code = set_code;
            this.set_rarity = set_rarity;
            this.set_rarity_code = set_rarity_code;
            this.set_price = set_price;
        }
    }
}
