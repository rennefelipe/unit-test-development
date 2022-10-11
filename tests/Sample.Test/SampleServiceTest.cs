using Xunit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using Sample.Extensions;

namespace Sample.Test
{
    public class SampleServiceTest
    {
        private readonly SampleService _sampleService;

        public SampleServiceTest()
        {
            //arrange (qualque tipo de variável necessária para montar o teste)
            _sampleService = new SampleService();
        }

        [Fact]
        public void Sum_MultipleValues_ReturnSuccess()
        {
            //arrange
            var value1 = 2;
            var value2 = 4;
            var value3 = 6;
            var value4 = 8;
            var value5 = 12;
            var total = 2;
            var withTotal = 34;
            var withoutTotal = 32;

            //act
            var resultWithTotal = _sampleService.Sum(total, value1, value2, value3, value4, value5);
            var resultWithoutTotal = _sampleService.Sum(value1, value2, value3, value4, value5);

            //Assert
            Assert.Equal(withTotal, resultWithTotal);
            Assert.Equal(withoutTotal, resultWithoutTotal);
        }

        [Theory]
        [InlineData(-4)]
        [InlineData(-2)]
        [InlineData(0)]
        [InlineData(2)]
        public void IsEven_ValuesLessThan3_ReturnTrue(int value)
        {
            //act (chamada do método a ser testado, logo a unidade)
            var result = _sampleService.IsEven(value);

            //assert (o cenário proposto no resultado do teste)
            Assert.True(result);
        }

        [Theory]
        [InlineData(-4)]
        [InlineData(-5)]
        [InlineData(0)]
        [InlineData(2)]
        public void IsEven_ValuesLessThan3_ReturnFalse(int value)
        {
            //act (chamada do método a ser testado, logo a unidade)
            var result = _sampleService.IsEven(value);

            //assert (o cenário proposto no resultado do teste)
            Assert.False(result);
        }

        [Theory]
        [InlineData(-2)]
        [InlineData(-3)]
        [InlineData(-1)]

        public void IsOdd_ValuesLessThan3_ReturnTrue(int value)
        {
            //act (chamada do método a ser testado, logo a unidade)
            var result = _sampleService.IsOdd(value);

            //assert (o cenário proposto no resultado do teste)
            Assert.True(result);
        }

        [Theory]
        [InlineData(-4)]
        [InlineData(-2)]
        [InlineData(0)]
        [InlineData(2)]
        public void IsOdd_ValuesLessThan3_ReturnFalse(int value)
        {
            //act (chamada do método a ser testado, logo a unidade)
            var result = _sampleService.IsOdd(value);

            //assert (o cenário proposto no resultado do teste)
            Assert.False(result);
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(0)]
        [InlineData(1)]
        public void IsPrime_ValuesLessThan2_ReturnFalse(int value)
        {
            var result = _sampleService.IsPrime(value);

            Assert.False(result, $"{value} should not be prime");
        }

        [Theory]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(5)]
        [InlineData(7)]
        public void IsPrime_PrimesLessThan10_ReturnTrue(int value)
        {
            var result = _sampleService.IsPrime(value);

            Assert.True(result, $"{value} should be prime");
        }

        [Fact]
        public void IsMailValid_ReturnTrue()
        {
            //arrange
            var mail = "@rennefelipe@outlook.com.br";


            //act
            var result = mail.IsValidMail();

            //assert
            Assert.False(result);
        }

        [Fact]
        public void IsMailValid_ReturnFalse()
        {
            //arrange
            var mail = "@rennefelipe@outlook.com.br";


            //act
            var result = mail.IsValidMail();

            //assert
            Assert.True(result);
        }

        [Fact]

        public void IsDateValid_Returntrue()
        {
            var date = DateTime.Now;
            var result = date.ToStringShortPtBR();

        }






    }
}
