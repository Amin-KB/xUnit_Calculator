using System;
using Xunit;
using Calculator;

namespace TestProject1
{
    
    public class Multipling
    {
        [Fact]
        public void Test1()
        {
            //Arrange
            int a = 1;
            int b = 2;
            int result1 = 0;
            //Act
            var math = new Calculator.Math();
            result1 = math.Multipling(a, b);
            int result2 = math.Multipling(10, 5);
            int result3 = math.Multipling(5, -2);
            int result4 = math.Multipling(7, 5);
            int result5 = math.Multipling(-4, 5);
            int result6 = math.Multipling(5, 6);
            //Assert
            Assert.Equal(2, result1);
            Assert.Equal(50, result2);
            Assert.Equal(-10, result3);
            Assert.Equal(35, result4);
            Assert.Equal(-20, result5);
            Assert.Equal(35, result6);
        }
        [Theory]
        [InlineData(1,0,0)]
        [InlineData(0,5,0)]
        [InlineData(0,0,0)]
        public void Test2(int a,int b,int assumedResult)
        {
            //Arrange
            //Act
            var math = new Calculator.Math();
            var result = math.Multipling(a, b);
            //Assert
            Assert.Equal(assumedResult, result);
        }
        [Theory]
        [InlineData(-1, -6, 6)]
        [InlineData(-1, 6, -6)]        
        public void Test3(int a, int b, int assumedResult)
        {
            //Arrange
            //Act
            var math = new Calculator.Math();
            var result = math.Multipling(a, b);
            //Assert
            Assert.Equal(assumedResult, result);
        }
    }
}
