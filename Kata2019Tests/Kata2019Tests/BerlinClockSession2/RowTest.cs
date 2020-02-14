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
			var onSymbol = Colour.Red;
			var hours = 12;
			var row = new Kata2019.BerlinClockSession2.Row(
				numberOfLightsInRow,
				onSymbol,
				hours / numberOfHoursForEachLight);
			Assert.Equal("RROO", row.ToString());
		}

		[Fact]
		public void TestSecondRow()
		{
			int numberOfLightsInRow = 4;
			int numberOfHoursForEachLight = 1;
			var onSymbol = Colour.Red;
			var hours = 12;
			var row = new Kata2019.BerlinClockSession2.Row(
				numberOfLightsInRow,
				onSymbol,
				(hours % 5) / numberOfHoursForEachLight);

			Assert.Equal("RROO", row.ToString());
		}

		[Fact]
		public void TestThirdRow()
		{
			int numberOfLightsInRow = 11;
			int numberOfMinutesForEachLight = 5;
			var onSymbol = Colour.Yellow;
			var minutes = 51;
			var row = new Kata2019.BerlinClockSession2.Row(
				numberOfLightsInRow,
				onSymbol,
				minutes / numberOfMinutesForEachLight);
			Assert.Equal("YYYYYYYYYYO", row.ToString());
		}

		[Fact]
		public void TestBottomRow()
		{
			int numberOfLightsInRow = 4;
			int numberOfMinutesForEachLight = 1;
			var onSymbol = Colour.Yellow;
			var minutes = 51;
			var row = new Kata2019.BerlinClockSession2.Row(
				numberOfLightsInRow,
				onSymbol,
				(minutes % 5) / numberOfMinutesForEachLight);
			Assert.Equal("YOOO", row.ToString());
		}
	}
}
