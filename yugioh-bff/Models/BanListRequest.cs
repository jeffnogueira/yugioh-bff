namespace yugioh_bff.Models
{
    public class BanListRequest
    {
        public string ban_tcg { get; set; }
        public string ban_ocg { get; set; }
        public string ban_goat { get; set; }

        public BanListRequest()
        {

        }
    }
}
