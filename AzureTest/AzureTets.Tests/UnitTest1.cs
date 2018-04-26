using System;
using System.Collections.Generic;
using System.Linq;
using AzureTest.DataContext.Model;
using AzureTest.DataContext.Repository;
using FizzWare.NBuilder;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DbContext = AzureTest.DataContext.Context.DbContext;

namespace AzureTets.Tests
{
    [TestClass]
    public class UnitTest1 : BaseCardTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var cards = Builder<Card>.CreateListOfSize(1000)
                .All()
                .Random(1)
                .Build();

            Context.Cards.AddRange(cards);

            Context.SaveChanges();

            var result = CardRepository.GetAllCards().Count();

            Assert.AreEqual(1000, result);
        }
        [TestMethod]
        public void GetById()
        {
            int i = 1;
            string name = "dsa";
            var c1 = new Card()
            {
                Name = name,
                Description = "dsdasdas",
                Id =  i
            };
            var c2 = new Card()
            {
                Name = "dsa",
                Description = "dsdasdas",
                Id = 2
            };
            var c3 = new Card()
            {
                Name = "dsa",
                Description = "dsdasdas",
                Id = 3
            };
            Context.Cards.Add(c1);
            Context.Cards.Add(c2);
            Context.Cards.Add(c3);
            Context.SaveChanges();

            var result = CardRepository.GetCardById(i);

            Assert.IsNotNull(result);
            Assert.AreEqual(name, result.Name);
        }
    }
}
