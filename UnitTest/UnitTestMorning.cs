using Business;
using System;
using Xunit;

namespace UnitTest
{
    public class UnitTestMorning
    {
        [Fact]
        public void MorningInput()
        {
            string sample = "morning,1,2,3";
            var sample_processed = MealBLL.ProcessRequest(sample);

            Assert.Equal("eggs, toast, coffee", sample_processed);
        }

        [Fact]
        public void MorningInputWithError()
        {
            string sample = "morning,1,2,3,4";
            var sample_processed = MealBLL.ProcessRequest(sample);

            Assert.Equal("eggs, toast, coffee, error", sample_processed);
        }


        [Fact]
        public void MorningInputWithMultiples()
        {
            string sample = "morning,1,2,3,3,3";
            var sample_processed = MealBLL.ProcessRequest(sample);

            Assert.Equal("eggs, toast, coffee(x3)", sample_processed);
        }


        [Fact]
        public void MorningInputWithMultiplesAndError()
        {
            string sample = "morning,1,2,3,3,3,4";
            var sample_processed = MealBLL.ProcessRequest(sample);

            Assert.Equal("eggs, toast, coffee(x3), error", sample_processed);
        }
    }
}
