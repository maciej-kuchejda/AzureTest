using System;
using System.Collections.Generic;
using System.Text;
using AzureTest.DataContext.Context;
using SQLitePCL;

namespace AzureTest.DataContext.Repository
{
    public class CardRepository : ICardRepository
    {
        private readonly DbContext _context;

        public CardRepository(DbContext context)
        {
            _context = context;
        }

        public IEnumerable<Card> GetAllCards()
        {
            return _context.Cards;
        }
    }
}
