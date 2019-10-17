using CoffeeReview;
using CoffeeReview.Models;
using CoffeeReview.Repositories;
using System;
using System.Linq;
using Xunit;

namespace CoffeeReview2.Tests
{
    public class CoffeeRepositoryTests : IDisposable
    {
        private CoffeeContext db;
        private CoffeeRepository underTest;

        public CoffeeRepositoryTests()
        {
            db = new CoffeeContext();
            db.Database.BeginTransaction();

            underTest = new CoffeeRepository(db);
        }

        public void Dispose()
        {
            db.Database.RollbackTransaction();
        }

        [Fact]
        public void Count_Starts_At_Zero()
        {
            var count = underTest.Count();

            Assert.Equal(0, count);
        }

        [Fact]
        public void Create_Increases_Count()
        {
            underTest.Create(new Coffee() { Brand = "Foo" });

            var count = underTest.Count();
            Assert.Equal(1, count);
        }

        [Fact]
        public void GetById_Returns_Created_Item()
        {
            var expectedCoffee = new Coffee() { Brand = "Baby Coffee" };
            underTest.Create(expectedCoffee);

            var result = underTest.GetById(expectedCoffee.Id);  // The Id was set by EF when we call Create above.

            Assert.Equal(expectedCoffee.Brand, result.Brand);
        }

        [Fact]
        public void Delete_Reduces_Count()
        {
            var coffee = new Coffee() { Brand = "Baby Coffee" };
            underTest.Create(coffee);

            underTest.Delete(coffee);
            var count = underTest.Count();

            Assert.Equal(0, count);
        }

        [Fact]
        public void GetAll_Returns_All()
        {
            underTest.Create(new Coffee() { Brand = "Baby Coffee" });
            underTest.Create(new Coffee() { Brand = "Never gonna give you up" });

            var all = underTest.GetAll();

            Assert.Equal(2, all.Count());
        }

        //Save or Update?
    }

    public class ReviewRepositoryTests : IDisposable
    {
        private CoffeeContext db;
        private ReviewRepository underTest;

        public ReviewRepositoryTests()
        {
            db = new CoffeeContext();
            db.Database.BeginTransaction();

            underTest = new ReviewRepository(db);
        }

        public void Dispose()
        {
            db.Database.RollbackTransaction();
        }

        [Fact]
        public void Count_Starts_At_Zero()
        {
            var count = underTest.Count();

            Assert.Equal(0, count);
        }

        [Fact]
        public void Create_Increases_Count()
        {
            underTest.Create(new Review() { Content = "Baby" });

            var count = underTest.Count();
            Assert.Equal(1, count);
        }

        [Fact]
        public void GetById_Returns_Created_Item()
        {
            var expectedReview = new Review() { Content = "Baby" };
            underTest.Create(expectedReview);

            var result = underTest.GetById(expectedReview.Id);  // The Id was set by EF when we call Create above.

            Assert.Equal(expectedReview.Coffee, result.Coffee);
        }

        [Fact]
        public void Delete_Reduces_Count()
        {
            var review = new Review() { Content = "Baby" };
            underTest.Create(review);

            underTest.Delete(review);
            var count = underTest.Count();

            Assert.Equal(0, count);
        }

        [Fact]
        public void GetAll_Returns_All()
        {
            underTest.Create(new Review() { Content = "Baby" });
            underTest.Create(new Review() { Content = "Baby" });

            var all = underTest.GetAll();

            Assert.Equal(2, all.Count());
        }

        //Save or Update?
    }
}
