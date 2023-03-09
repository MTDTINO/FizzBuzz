namespace FizzBuzzPractice.Kata
{
    public class FizzBuzzTest
    {
        [Fact]
        public void ShouldReturnFizzWhenDivisibleBy3()
        {
            FizzBuzz fizzBuzz = new FizzBuzz();
            var Fizz = fizzBuzz.FBuzz(3);
            Assert.Equal("Fizz",Fizz);
        }

        [Fact]
        public void ShouldReturnBuzzWhenDivisibleBy5() {
            FizzBuzz fizzBuzz = new FizzBuzz();
            var Buzz = fizzBuzz.FBuzz(5);
            Assert.Equal("Buzz",Buzz);
        }

        [Fact]
        public void ShouldReturnFizzBuzzWhenDivisibleBy3and5() {
            FizzBuzz fizzBuzz = new FizzBuzz();
            var FizzBuzz = fizzBuzz.FBuzz(15);
            Assert.Equal("FizzBuzz",FizzBuzz);
        }
    }
}