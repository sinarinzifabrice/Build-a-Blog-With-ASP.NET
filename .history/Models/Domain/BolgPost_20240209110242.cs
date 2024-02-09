using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Build_a_Blog_With_ASP.NET.Models.Domain
{
    public class BolgPost
    {
        public Guid Id { get; set; }
        public int Heading { get; set; }
        public string PageTitle { get; set; }
        public string Content { get; set; }
        public string ShortDescription { get; set; }
        public string FeatureImageUrl { get; set; }
        public DateTime PublishedDate { get; set; }
        public string Auth { get; set; }

    }
}