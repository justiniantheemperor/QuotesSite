using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuotesSite.Models
{
    public interface IQuotesRepository
    {
        IQueryable<Quote> Quotes { get; }
    }
}
