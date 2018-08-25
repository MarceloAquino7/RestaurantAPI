using Business;
using System;
using Xunit;

namespace UnitTest
{
    public class UnitTestInvalid
    {
        [Fact]
        public void SimpleInvalidInput()
        {
            string sample = " ";
            string result = MealBLL.ProcessRequest(sample);
            Assert.Equal("Invalid Meal Id", result);
        }

        [Fact]
        public void SimpleInvalidCharacter()
        {
            string sample = "foo";
            string result = MealBLL.ProcessRequest(sample);
            Assert.Equal("Invalid Meal Id", result);
        }

        [Fact]
        public void SimpleInvalidMealTime()
        {
            string sample = "noon";
            string result = MealBLL.ProcessRequest(sample);
            Assert.Equal("Invalid Meal Id", result);
        }

        [Fact]
        public void IgnoringInvalidOptions()
        {
            string sample = "night,1,2,abcde,3,4";
            var sample_processed = MealBLL.ProcessRequest(sample);

            Assert.Equal("steak, potato, wine, cake", sample_processed);
        }

        [Fact]
        public void InputWithMultipleError()
        {
            string sample = "night,1,2,8,10,jk,,";
            var sample_processed = MealBLL.ProcessRequest(sample);

            Assert.Equal("steak, potato, error, error", sample_processed);
        }
    }
}
