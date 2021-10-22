﻿namespace yugioh_bff.Models
{
    public class BanListRequest
    {
        private string ban_tcg { get; set; }
        private string ban_ocg { get; set; }
        private string ban_goat { get; set; }

        public BanListRequest()
        {

        }

        public BanListRequest(
            string ban_tcg,
            string ban_ocg,
            string ban_goat
        )
        {
            this.ban_tcg = ban_tcg;
            this.ban_ocg = ban_ocg;
            this.ban_goat = ban_goat;
        }
    }
}