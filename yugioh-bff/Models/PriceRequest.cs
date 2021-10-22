namespace yugioh_bff.Models
{
    public class PriceRequest
    {
        public string cardmarket_price { get; set; }
        public string tcgplayer_price { get; set; }
        public string ebay_price { get; set; }
        public string amazon_price { get; set; }
        public string coolstuffinc_price { get; set; }

        public PriceRequest()
        {

        }
    }
}
