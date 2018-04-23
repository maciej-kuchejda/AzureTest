using System;
using System.Collections.Generic;
using System.Text;

namespace AzureTest.DataContext.Repository
{
    public interface ICardRepository
    {
        IEnumerable<Card> GetAllCards();
    }
}
