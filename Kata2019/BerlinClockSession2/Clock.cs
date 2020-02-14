using System;
using System.Collections.Generic;
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

		private bool CheckSecondsAreEven() => currentTime.Seconds % 2 == 0;

		void SetTopRow()
		{

		}

	}

	public class Row
	{

		char[] Lights;

		public Row(int numberOfLights)
		{
            this.Lights = new char[numberOfLights];
		}
	}
}
