using CentricExpress.Data;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CentricExpress.Business;
using CentricExpress.Data.Entities;
using FluentAssertions;
using Xunit;

namespace Business.Test
{
    public class SuperheroBusinessLogicTest
    {
        private readonly Mock<IDatabase> _databaseMock;
        private readonly SuperheroBusinessLogic SystemUnderTest;

        public SuperheroBusinessLogicTest()
        {
            var mockRepository = new MockRepository(MockBehavior.Strict);

            _databaseMock = mockRepository.Create<IDatabase>();
            SystemUnderTest = new SuperheroBusinessLogic(_databaseMock.Object);
        }

        [Fact]
        public void Given_When_GetIsCalled_Then_SuperheroesListIsReturned()
        {
            // Arrange
            var name = "Name";
            var expectedResult = new List<Superhero>
            {
                new Superhero(name, "superpower", 10)
            };
            _databaseMock.SetupGet(d => d.List).Returns(expectedResult);

            // Act
            var result = SystemUnderTest.Get();

            // Assert
            result.Should().HaveCount(1);
            result.First().Name.Should().Be(name);
        }
    }
}
