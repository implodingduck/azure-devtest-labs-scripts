using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using devtestlabsdemoapp.Data;
using devtestlabsdemoapp.Models;

namespace devtestlabsdemoapp.Pages.Quotes
{
    public class IndexModel : PageModel
    {
        private readonly devtestlabsdemoapp.Data.QuoteContext _context;

        public IndexModel(devtestlabsdemoapp.Data.QuoteContext context)
        {
            _context = context;
        }

        public IList<Quote> Quote { get;set; }

        public async Task OnGetAsync()
        {
            Quote = await _context.Quote.ToListAsync();
        }
    }
}
