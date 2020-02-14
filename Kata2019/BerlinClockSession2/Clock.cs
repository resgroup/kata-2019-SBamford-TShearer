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
			TopRow = new Row(4, 5, 'R', currentTime.Hours).ToString();
		}

        void SetSecondRow()
        {
            SecondRow = new Row(4, 1, 'R', currentTime.Hours % 5).ToString();
        }

        void SetThirdRow()
        {
            ThirdRow = new Row(11, 5, 'Y', currentTime.Minutes).ToString();
        }

        void SetBottomRow()
        {
            BottomRow = new Row(4, 1, 'Y', currentTime.Minutes % 5).ToString();
        }

    }

	public class Row
	{

		IEnumerable<Light> Lights;
		char onSymbol;
		char offSymbol;
		int numberForEachLight;

		public Row(
			int numberOfLightsInRow,
			int valueForEachLight,
			char onSymbol,
			int valueToSetFrom)
		{
			this.onSymbol = onSymbol;
			this.numberForEachLight = valueForEachLight;
			this.offSymbol = 'O';
			SetLights(numberOfLightsInRow, valueToSetFrom);
		}

		void SetLights(int numberOfLights, int numberToSetFrom)
		{
			var lights = new List<Light>();
			int currentLightFloorValue = numberForEachLight;
			for (int position = 0; position < numberOfLights; position++)
			{
				lights.Add(
                    new Light(
                        position, 
                        numberToSetFrom >= currentLightFloorValue ? onSymbol : offSymbol));
				currentLightFloorValue += numberForEachLight;
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
}
