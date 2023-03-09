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
    }
}