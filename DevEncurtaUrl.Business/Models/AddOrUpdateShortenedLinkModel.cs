using System;
using System.Collections.Generic;
using System.Text;

namespace DevEncurtaUrl.Business.Models
{
    public class AddOrUpdateShortenedLinkModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string DestinationLink { get; set; }
    }
}
