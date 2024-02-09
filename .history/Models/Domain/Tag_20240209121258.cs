using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Build_a_Blog_With_ASP.NET.Models.Domain
{
    public class Tag
    {
        public Guid Id { get; set; }
        public string name { get; set; }
        public string DisplayName { get; set; }
        public ICollection<BolgPost> Blog { get; set; }
    }
}