namespace FizzBuzzPractice.Kata
{
    public class FizzBuzzTest
    {
        [Fact]
        public void ShouldReturnFizzWhenDivisibleBy3()
        {
            FizzBuzz fizzBuzz = new FizzBuzz();
            var Fizz = fizzBuzz.Fizz(3);

            Assert.Equal("Fizz",Fizz);
        }

        [Fact]
        public void ShouldReturnBuzzWhenDivisibleBy5() {
            FizzBuzz fizzBuzz = new FizzBuzz();
            var Buzz = fizzBuzz.Buzz(5);
            Assert.Equal("Buzz",Buzz);
        }
    }
}