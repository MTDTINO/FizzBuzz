namespace FizzBuzzPractice.Kata
{
    public class FizzBuzzTest
    {
        [Fact]
        public void Test1()
        {
            FizzBuzz fizzBuzz = new FizzBuzz();
            var Fizz = fizzBuzz.FBuzz(5);

            Assert.Equal("Fizz",Fizz);
        }
    }
}