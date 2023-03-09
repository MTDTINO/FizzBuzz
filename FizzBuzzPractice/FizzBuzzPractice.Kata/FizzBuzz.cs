namespace FizzBuzzPractice.Kata
{
    public class FizzBuzz
    {
        public string FBuzz(int number) {
            var numdivisibleby3 = number % 3;
            var numdivisibleby5 = number % 5;
            if (numdivisibleby3 == 0 && numdivisibleby5 == 0) return "FizzBuzz";
            if (numdivisibleby3 == 0) return "Fizz";
            if (numdivisibleby5 == 0) return "Buzz";
            return number.ToString();
        }
    }
}
