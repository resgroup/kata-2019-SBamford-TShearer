using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Kata2019.BerlinClockSession2;

namespace Kata2019Tests.BerlinClockSession2
{
	public class ClockTest
	{
		[Fact]
		public void TestRoundYellowLightOn()
		{
			var clock = new Kata2019.BerlinClockSession2.Clock("12:51:09");
			Assert.Equal("O", clock.TopYellowLight);
		}

		[Fact]
		public void TestRoundYellowLightOff()
		{
			var clock = new Kata2019.BerlinClockSession2.Clock("12:51:10");
			Assert.Equal("Y", clock.TopYellowLight);
		}

		[Fact]
		public void TestTopRow()
		{
			var clock = new Kata2019.BerlinClockSession2.Clock("12:51:10");
			Assert.Equal("RROO", clock.TopRow);
		}

        [Fact]
        public void TestSecondRow()
        {
            var clock = new Kata2019.BerlinClockSession2.Clock("12:51:10");
            Assert.Equal("RROO", clock.SecondRow);
        }

        [Fact]
        public void TestThirdRow()
        {
            var clock = new Kata2019.BerlinClockSession2.Clock("12:51:10");
            Assert.Equal("YYYYYYYYYYO", clock.ThirdRow);
        }

        [Fact]
        public void TestBottomRow()
        {
            var clock = new Kata2019.BerlinClockSession2.Clock("12:51:10");
            Assert.Equal("YOOO", clock.BottomRow);
        }
    }
}
