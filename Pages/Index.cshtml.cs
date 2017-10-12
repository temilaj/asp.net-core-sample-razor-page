using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace razor.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public string Message { get; private set; } = "PageModel in C#";
        private readonly ILogger<IndexModel> _logger;
        public IndexModel(IConfiguration config, ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            Message += $" Server time is { DateTime.Now }";
            _logger.LogCritical("Hey YO!");
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            return RedirectToPage("/Index");
        }
    }
}
