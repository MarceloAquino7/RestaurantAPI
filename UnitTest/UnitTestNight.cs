using Business;
using System;
using Xunit;

namespace UnitTest
{
    public class UnitTestNight
    {
        [Fact]
        public void NightInput()
        {
            string sample = "night,1,2,3";
            var sample_processed = MealBLL.ProcessRequest(sample);

            Assert.Equal("steak, potato, wine", sample_processed);
        }

        [Fact]
        public void NightInputWithError()
        {
            string sample = "night,1,2,3,4";
            var sample_processed = MealBLL.ProcessRequest(sample);

            Assert.Equal("steak, potato, wine, cake", sample_processed);
        }

        [Fact]
        public void NightInputWithMultiples()
        {
            string sample = "night,1,2,2,2,2";
            var sample_processed = MealBLL.ProcessRequest(sample);

            Assert.Equal("steak, potato(x4)", sample_processed);
        }

        [Fact]
        public void NightInputWithMultiplesAndError()
        {
            string sample = "night,1,2,2,2,2,4,5";
            var sample_processed = MealBLL.ProcessRequest(sample);

            Assert.Equal("steak, potato(x4), cake, error", sample_processed);
        }
    }
}
