using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yugioh_bff.Application.Models
{
    class ImageRequest
    {
        private int id { get; set; }
        private string image_url { get; set; }
        private string image_url_small { get; set; }

        public ImageRequest()
        {

        }

        public ImageRequest(
            int id,
            string image_url,
            string image_url_small
        )
        {
            this.id = id;
            this.image_url = image_url;
            this.image_url_small = image_url_small;
        }
    }
}
