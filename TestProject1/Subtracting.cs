using System;
using Xunit;
using Calculator;

namespace TestProject1
{
    
    public class Subtracting
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
            result1=math.Subtracting(a, b);
           int result2=math.Subtracting(10, 5);
           int result3=math.Subtracting(5, -2);
           int result4=math.Subtracting(7, 5);
           int result5=math.Subtracting(-4, 5);
           int result6=math.Subtracting(5, 6);
            //Assert
            Assert.Equal(-1, result1);
            Assert.Equal(5, result2);
            Assert.Equal(7, result3);
            Assert.Equal(2, result4);
            Assert.Equal(-9, result5);
            Assert.Equal(-1, result6);
        }
        [Theory]
        [InlineData(0,0,0)]
        [InlineData(0,-10,-10)]
        [InlineData(-10,0,-10)]
        [InlineData(-5,-2,-7)]
        public void Test2(int a,int b, int assumedResult)
        {
            //Arrange
            //Act
            var math = new Calculator.Math();
            int result = math.Subtracting(a, b);
            //Assert
            Assert.Equal(assumedResult, result);
        }
    }
}
