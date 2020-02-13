using System;
using System.Collections.Generic;
using System.Text;

namespace Kata2019
{
	public class SampleObject
	{
		public int exclamationMarks { get; set; }

		public SampleObject(int exclamationMarks)
		{
			this.exclamationMarks = exclamationMarks;
		}

		public string HelloWorld() => "Hello World" + new string('!', exclamationMarks);
	}
}
