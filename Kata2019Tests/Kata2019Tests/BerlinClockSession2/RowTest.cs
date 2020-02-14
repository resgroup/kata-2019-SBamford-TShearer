using System.Collections.Generic;
using System.Text;
using Xunit;
using Kata2019.BerlinClockSession2;

namespace Kata2019Tests.BerlinClockSession2
{
    public class RowTest
    {
        [Fact]
        public void TestTopRow()
        {
            int numberOfLightsInRow = 4;
            int numberOfHoursForEachLight = 5;
            char onSymbol = 'R';
            var hours = 12;
            var row = new Kata2019.BerlinClockSession2.Row(
                numberOfLightsInRow,
                numberOfHoursForEachLight,
                onSymbol,
                hours);
            Assert.Equal("RROO", row.ToString());
        }

        [Fact]
        public void TestSecondRow()
        {
            int numberOfLightsInRow = 4;
            int numberOfHoursForEachLight = 1;
            char onSymbol = 'R';
            var hours = 12 % 5;
            var row = new Kata2019.BerlinClockSession2.Row(
                numberOfLightsInRow,
                numberOfHoursForEachLight,
                onSymbol,
                hours);

            Assert.Equal("RROO", row.ToString());
        }

        [Fact]
        public void TestThirdRow()
        {
            int numberOfLightsInRow = 11;
            int numberOfMinutesForEachLight = 5;
            char onSymbol = 'Y';
            var minutes = 51;
            var row = new Kata2019.BerlinClockSession2.Row(
                numberOfLightsInRow,
                numberOfMinutesForEachLight,
                onSymbol,
                minutes);
            Assert.Equal("YYYYYYYYYYO", row.ToString());
        }

        [Fact]
        public void TestBottomRow()
        {
            int numberOfLightsInRow = 4;
            int numberOfMinutesForEachLight = 1;
            char onSymbol = 'Y';
            var minutes = 51 % 5;
            var row = new Kata2019.BerlinClockSession2.Row(
                numberOfLightsInRow,
                numberOfMinutesForEachLight,
                onSymbol,
                minutes);
            Assert.Equal("YOOO", row.ToString());
        }
    }
}
