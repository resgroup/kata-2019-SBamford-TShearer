using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Kata2019;

namespace Kata2019Tests
{
	public class TestRepository
	{
		[Fact]
		public void TestSampleObject()
		{
			var sampleObject = new SampleObject(10);
			Assert.Equal("Hello World!!!!!!!!!!", sampleObject.HelloWorld());
		}
	}
}
