using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using devtestlabsdemoapp.Models;

namespace devtestlabsdemoapp.Data
{
    public class QuoteContext : DbContext
    {
        public QuoteContext (DbContextOptions<QuoteContext> options)
            : base(options)
        {
        }

        public DbSet<Quote> Quote { get; set; }

        

    }
}
