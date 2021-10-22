namespace yugioh_bff.Models
{
    public class PriceRequest
    {
        private string cardmarket_price { get; set; }
        private string tcgplayer_price { get; set; }
        private string ebay_price { get; set; }
        private string amazon_price { get; set; }
        private string coolstuffinc_price { get; set; }

        public PriceRequest()
        {

        }

        public PriceRequest(
            string cardmarket_price,
            string tcgplayer_price,
            string ebay_price,
            string amazon_price,
            string coolstuffinc_price
        )
        {
            this.cardmarket_price = cardmarket_price;
            this.tcgplayer_price = tcgplayer_price;
            this.ebay_price = ebay_price;
            this.amazon_price = amazon_price;
            this.coolstuffinc_price = coolstuffinc_price;
        }
    }
}
