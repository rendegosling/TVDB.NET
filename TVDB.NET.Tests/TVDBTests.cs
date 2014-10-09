using System;
using System.Diagnostics;
using System.Linq;
using NUnit.Framework;

namespace TVDB.NET.Tests
{
    [TestFixture]
    public class TVDBTests : TVDBTestBase
    {

        [SetUp]
        public void Setup()
        {
            if (string.IsNullOrEmpty(YourTheTVDBAPIKey))
            {
                throw new Exception(APIKeyMissing);
            }
        }

        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void Constructor_EmtptyNullApiKey_ThrowsException()
        {
            //arrange
            //act
            var tvdb = new TVDBNet("");
        }

        [Test]
        public void SearchSeries_GameOf_WillReturn_5Item()
        {
            //arrange
            var tvdb = new TVDBNet(YourTheTVDBAPIKey);

            //act
            var results = tvdb.GetSeries("Game of").ToList();

            //Assert
            Assert.True(results.Any());
            Assert.True(results.Count == 15, "Expected 15 but {0}", results.Count);
        }

        [Test]
        public void SearchSeries_GameOfThrones_WillReturn_1Item()
        {
            //arrange
            var tvdb = new TVDBNet(YourTheTVDBAPIKey);

            //act
            var results = tvdb.GetSeries("Game of Thrones").ToList();

            //Assert
            Assert.True(results.Any());
            Assert.True(results.Count == 1, "Expected 1 but {0}", results.Count);
        }

        [Test]
        public void SearchSeries_PawnStars()
        {
            //arrange
            var tvdb = new TVDBNet(YourTheTVDBAPIKey);

            //act
            var results = tvdb.GetSeries("Pawn Stars").ToList();

            //Assert
            Assert.True(results.Any());
            results.ForEach(r=> Debug.WriteLine(r.SeriesName));
            //Assert.True(results.Count == 1, "Expected 1 but {0}", results.Count);
        }

        [Test]
        public void GetMirrors_Tests()
        {
            //arrange
            var tvdb = new TVDBNet(YourTheTVDBAPIKey);

            //act
            

            //Assert
            Assert.True(tvdb.Mirrors.Any());
     
           
        }

        [Test]
        public void GetServerTime_Tests()
        {
            //arrange
            var tvdb = new TVDBNet(YourTheTVDBAPIKey);

            //act
         

            //Assert
            Assert.True(tvdb.ServerTime != default(DateTime));


        }


    }

}
