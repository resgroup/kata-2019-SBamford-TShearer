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
			SetSecondRow();
			SetThirdRow();
			SetBottomRow();
		}

		public string Output()
		{
			var stringBuilder = new System.Text.StringBuilder();
			stringBuilder.AppendLine(TopYellowLight);
			stringBuilder.AppendLine(TopRow);
			stringBuilder.AppendLine(SecondRow);
			stringBuilder.AppendLine(ThirdRow);
			stringBuilder.Append(BottomRow);
			return stringBuilder.ToString();
		}

		TimeSpan GetTimeSpanFromTimeString(string timeString)
		{
			return TimeSpan.Parse(timeString);
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
			TopRow = new Row(4, Colour.Red, currentTime.Hours / 5).ToString();
		}

		void SetSecondRow()
		{
			SecondRow = new Row(4, Colour.Red, currentTime.Hours % 5).ToString();
		}

		void SetThirdRow()
		{
			ThirdRow = new Row(11, Colour.Yellow, currentTime.Minutes / 5).ToString();
		}

		void SetBottomRow()
		{
			BottomRow = new Row(4, Colour.Yellow, currentTime.Minutes % 5).ToString();
		}

	}

	public class Row
	{

		IEnumerable<Light> Lights;
		char onSymbol;
		char offSymbol = 'O';

		public Row(
			int numberOfLightsInRow,
			Colour colour,
			int numberOfLightsOn)
		{
			this.onSymbol = (char)colour;
			SetLights(numberOfLightsInRow, numberOfLightsOn);
		}

		void SetLights(int numberOfLights, int numberOfLightsOn)
		{
			var lights = new List<Light>();
			for (int position = 0; position < numberOfLights; position++)
			{
				lights.Add(
					new Light(
						position,
						position < numberOfLightsOn ? onSymbol : offSymbol));
			}
			Lights = lights;

		}
		public override string ToString()
		{
			string result = "";
			foreach (var currentLight in Lights)
			{
				result += currentLight.state;
			}
			return result;
		}

	}

	public class Light
	{
		public int position { get; }
		public char state { get; set; }

		public Light(int position, char state)
		{
			this.position = position;
			this.state = state;
		}

	}

	public enum Colour
	{
		Yellow = 'Y',
		Red = 'R'
	}
}
