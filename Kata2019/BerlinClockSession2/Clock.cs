using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kata2019.BerlinClockSession2
{
	public class Clock
	{
		public string TopYellowLight { get; private set; }
		public string TopRow { get; private set; }
		public string SecondRow { get; private set; }
		public string ThirdRow { get; private set; }
		public string BottomRow { get; private set; }

		TimeSpan currentTime;

		public Clock(string timeString)
		{
			currentTime = GetTimeSpanFromTimeString(timeString);
			SetTopYellowLight();
			SetTopRow();
		}

		TimeSpan GetTimeSpanFromTimeString(string timeString)
		{
			var timeElements = timeString.Split(":");
			return new TimeSpan(Int32.Parse(timeElements[0]), Int32.Parse(timeElements[1]), Int32.Parse(timeElements[2]));
		}

		void SetTopYellowLight()
		{
			if (CheckSecondsAreEven())
				TopYellowLight = "Y";
			else
				TopYellowLight = "O";
		}

		bool CheckSecondsAreEven() => currentTime.Seconds % 2 == 0;

		void SetTopRow()
		{
            if (currentTime.Hours < 5) {
                TopRow = "OOOO";
            } else if (currentTime.Hours < 10) {
                TopRow = "ROOO";
            } else if (currentTime.Hours < 15) {
                TopRow = "RROO";
            } else if (currentTime.Hours < 20) {
                TopRow = "RRRO";
            } else {
                TopRow = "RRRR";
            }
        }

	}

	public class Row
	{

		IEnumerable<char> Lights;

		public Row(int numberOfLights)
		{
			this.Lights = Enumerable.Repeat('O', numberOfLights);
		}
	}

    public abstract class LightState
    {

    }
}
