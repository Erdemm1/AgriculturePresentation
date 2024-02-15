﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Team
    {
        public int TeamId { get; set; }
        public string PersonName { get; set; }
        public string Title { get; set; }
        public string ImageUrl { get; set; }
        public string FacebookUrl { get; set; }
        public string InstagramkUrl { get; set; }
        public string WebsiteUrl { get; set; }
        public string TwitterUrl { get; set; }
    }
}
