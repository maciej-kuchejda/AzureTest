using System;
using System.Collections.Generic;
using System.Text;
using AzureTest.DataContext.Model;

namespace AzureTest.DataContext.Repository
{
    public interface ICardRepository
    {
        IEnumerable<Card> GetAllCards();
        void Post(Card value);
        Card GetCardById(int id);
    }
}
