using System;
using Xunit;
using AS1;


namespace AS2.Test
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(77, "1001101")]
        public void Test1(int x, string expectedresult)
        {
            string result;
            int num = x;
            result = "";
            while (num > 1)
            {
                int remainder = num % 2;
                result = Convert.ToString(remainder) + result;
                num /= 2;
            }
            result = Convert.ToString(num) + result;
            Assert.Equal(expectedresult, result);
        }
        
    }
}
