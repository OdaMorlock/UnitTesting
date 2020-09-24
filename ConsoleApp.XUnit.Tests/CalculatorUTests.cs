using System;
using Xunit;

namespace ConsoleApp.XUnit.Tests
{
    // TDD = Test Driven Development (Test first then Code)
    // Enhetstest (Unit Test), IntegrationTest(Integration Test), End to End test
    //Red,Green,Refact


    public class CalculatorUTests
    {
        [Theory]
        [InlineData(1,1,2)]
        [InlineData(2, 2, 4)]
        public void Add_Should_Add_Two_Values(int value1, int value2, int expected)
        {
            var _calc = new Calculator();            
            Assert.Equal(expected, _calc.Add(value1, value2));
        }


        

        /*[Fact]
        public void Create_Should_Create_A_Person()
        {
            var person = new Person();
            bool actual = person.Create();
            Assert.True(actual);

        arange - setup

        act - actual

        assert  

        }*/
    }

    
}
