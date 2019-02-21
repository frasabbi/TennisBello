using System;
using TennisFormFinal.Models;
using Xunit;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using TennisFormFinal.Component;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Moq;
using Microsoft.AspNetCore.Mvc.ViewComponents;

namespace TennisFormFinalTest
{
    public class UnitTest1
    {
        [Fact]
        public void Check_If_Add_To_Database_Works()
        {
            //Arrange
            var testReservation = new TennisReservation();
            testReservation.CourtId = 1;
            testReservation.ReservationTime = DateTime.Now;
            testReservation.MatchType = "Doppio";
            //{ CourtId = 1, ReservationTime = DateTime.Now, MatchType = "Doppio" };
            var options = new DbContextOptionsBuilder<TRDBContext>().UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Initial Catalog=TennisReservations;Integrated Security=True; MultipleActiveResultSets=true").Options;

            using (var context = new TRDBContext(options))
            {
                Repository repo = new Repository(context);
                var count = repo.Reservations.Count();
                //Act
                repo.AddReservation(testReservation);
                //Assert
                Assert.Equal(count + 1, repo.Reservations.Count());
                Assert.Equal(testReservation, repo.Reservations.Last());
            
                
            }

            using (var context = new TRDBContext(options))
            {
                var count = context.TReservations.Count();
                //Act
                context.TReservations.Remove(testReservation);
                context.SaveChanges();
                //Assert
                Assert.Equal(count -1, context.TReservations.Count());
                Assert.NotEqual(testReservation, context.TReservations.Last());
                
                
            }



        }


        [Fact]
        public void Check_If_Responds_To_Query()
        {
            var options = new DbContextOptionsBuilder<TRDBContext>().UseInMemoryDatabase(databaseName: "database_super_cazzuto").Options;

            
            using (var context = new TRDBContext(options))
            {
                context.TReservations.Add(new TennisReservation() { CourtId = 1, ReservationTime = DateTime.Now, MatchType = "Singolo" });
                context.TReservations.Add(new TennisReservation() { CourtId = 2, ReservationTime = DateTime.Now, MatchType = "Doppio" });
                context.TReservations.Add(new TennisReservation() { CourtId = 2, ReservationTime = DateTime.Now, MatchType = "Singolo" });
                context.TReservations.Add(new TennisReservation() { CourtId = 1, ReservationTime = DateTime.Now, MatchType = "Doppio" });

                context.SaveChanges();
            }

        
            using (var context = new TRDBContext(options))
            {
                var repo = new Repository(context);
                var result = repo.FindByMatchType("Doppio");
                Assert.Equal(2, result.Count());
            }


        }


        [Fact]
        public void Test_Perché_Luca_Se_L_è_Ricordato()
        {
            //var options = new DbContextOptionsBuilder<TRDBContext>().UseInMemoryDatabase(databaseName: "database_super_cazzuto").Options;


            //using (var context = new TRDBContext(options))
            //{
            //    context.TCourts.Add(new Court() { Name = "Nicolettodromo", Type = "Grass" });
            //    context.TCourts.Add(new Court() { Name = "Valeriorama", Type = "Grass" });
            //    context.TCourts.Add(new Court() { Name = "FrasabbiField", Type = "RedGround" });
            //    context.TCourts.Add(new Court() { Name = "Campetto di Gianluca", Type = "RedGround" });
            //    context.TCourts.Add(new Court() { Name = "Andredrome", Type = "Concrete" });


            //    context.SaveChanges();
            //}


            //using (var context = new TRDBContext(options))
            //{
            //    var navigationMenu = new NavigationMenuViewComponent(new Repository(context)) ;
            //    var viewComponentResult = navigationMenu.Invoke() as ViewComponentResult;
            //    IEnumerable<String> model = viewComponentResult.ViewData.Model as IEnumerable<String>;
            //    Assert.Equal("Grass", model.First());
            //}



            Mock<ITSRepository> mock = new Mock<ITSRepository>();
            mock.Setup(mockObject => mockObject.Courts).Returns((new Court[] {
                new Court() { Name = "Nicolettodromo", Type = "Grass" },
                new Court() { Name = "Valeriorama", Type = "Grass" },
                new Court() { Name = "FrasabbiField", Type = "RedGround" },
                new Court() { Name = "Campetto di Gianluca", Type = "RedGround" },
                new Court() { Name = "Andredrome", Type = "Concrete" }
            }).AsQueryable<Court>());

            NavigationMenuViewComponent target =
                new NavigationMenuViewComponent(mock.Object);

            IViewComponentResult viewComponentResult = target.Invoke();

            ViewViewComponentResult viewResultOfMyViewComponent = viewComponentResult as ViewViewComponentResult;
            // Act = get the set of categories
            IQueryable<string> resultsQuery =  viewResultOfMyViewComponent.ViewData.Model as IQueryable<string>;
            string[] results = resultsQuery.ToArray();
            // Assert
            Assert.True(Enumerable.SequenceEqual(new string[] {"Concrete", "Grass",
                "RedGround" }, results));

        }
    }
}
