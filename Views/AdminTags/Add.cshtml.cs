using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Build_a_Blog_With_ASP.NET.Views.AdminTags
{
    public class Add : PageModel
    {
        private readonly ILogger<Add> _logger;

        public Add(ILogger<Add> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}