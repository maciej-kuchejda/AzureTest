using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AzureTest.DataContext.Context;
using AzureTest.DataContext.Model;
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
            return _context.Cards.ToList();
        }

        public Card GetCardById(int id)
        {
            return _context.Cards.FirstOrDefault(x=> x.Id == id);
        }

        public void Post(Card value)
        {
            _context.Cards.Add(value);
            _context.SaveChanges();
        }
    }
}
