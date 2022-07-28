using System;

namespace devtestlabsdemoapp.Models
{
    public class Quote
    {
        public int ID { get; set; }
        public string Verbage { get; set; }
        public string Source { get; set; }
    }
}

/// dotnet aspnet-codegenerator razorpage -m Quote -dc devtestlabsdemoapp.Data.QuoteContext -udl -outDir Pages\Quotes --referenceScriptLibraries --useSqlite