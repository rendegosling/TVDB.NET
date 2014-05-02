﻿using System;
using System.Linq;
using NUnit.Framework;

namespace TVDB.NET.Tests
{
    [TestFixture]
    public class TVDBTests : TVDBTestBase
    {
        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void Constructor_EmtptyNullApiKey_ThrowsException()
        {
            //arrange
            //act
            var tvdb = new TVDBNet("");
        }

        [Test]
        public void SearchShow_GameOf_WillReturn_5Item()
        {
            //arrange
            var tvdb = new TVDBNet(ApiKey);

            //act
            var results = tvdb.Search("Game of").ToList();

            //Assert
            Assert.True(results.Any());
            Assert.True(results.Count == 14, "Expected 5 but {0}", results.Count);
        }

        [Test]
        public void SearchShow_GameOfThrones_WillReturn_1Item()
        {
            //arrange
            var tvdb = new TVDBNet(ApiKey);

            //act
            var results = tvdb.Search("Game of Thrones").ToList();

            //Assert
            Assert.True(results.Any());
            Assert.True(results.Count == 1, "Expected 1 but {0}", results.Count);
        }

        [Test]
        public void TvDbResponseSerializer_Deserialize_ReturnsObject()
        {
            var xml = GetTestXml();

            var deserializer = new TVDBSerializer();

            var series = deserializer.Deserialize(xml);

            Assert.That(series != null);

        }
    }
}