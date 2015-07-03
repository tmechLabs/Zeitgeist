using System;
using System.Linq;
using Xunit;
using Zeitgeist.Web.API.Models;

namespace Zeitgeist.Web.API.Tests
{
    public class TimeEntryTests
    {

        [Fact]
        public void ShouldHaveStartTimeProperty()
        {
            // Arrange
            var sut = new TimeEntry();
            var expected = "StartTime";
            // Act
            var result = sut.GetType().GetProperty(expected);

            // Assert
            Assert.NotNull(result);
        }
        [Fact]
        public void ShouldHaveEndTimeProperty()
        {
            // Arrange
            var sut = new TimeEntry();
            var expected = "EndTime";
            // Act
            var result = sut.GetType().GetProperty(expected);

            // Assert
            Assert.NotNull(result);
        }
    }
}
