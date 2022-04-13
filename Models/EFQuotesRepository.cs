using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuotesSite.Models
{
    public class EFQuotesRepository : IQuotesRepository
    {
        private QuotesContext context { get; set; }
        public EFQuotesRepository (QuotesContext temp)
        {
            context = temp;
        }
        public IQueryable<Quote> Quotes => context.Quotes;
    }
}
