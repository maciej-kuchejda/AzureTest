using System;
using System.Collections.Generic;
using System.Text;
using AzureTest.DataContext.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DbContext = AzureTest.DataContext.Context.DbContext;

namespace AzureTets.Tests
{
    public abstract class BaseCardTests
    {
        protected DbContext Context;
        protected ICardRepository CardRepository;

        [TestInitialize]
        public virtual void SetUp()
        {
            var options = new DbContextOptionsBuilder<DbContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;
            Context = new DbContext(options);
            CardRepository = new CardRepository(Context);

            Context.Database.EnsureDeleted();
            Context.Database.EnsureCreated();
        }

        [TestCleanup]
        public virtual void TeadDown()
        {
            Context.Dispose();
        }
    }
}
