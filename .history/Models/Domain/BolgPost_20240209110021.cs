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
        public int MyProperty { get; set; }
    }
}