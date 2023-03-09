namespace FizzBuzzPractice.Kata
{
    public class FizzBuzz
    {
        public string FBuzz(int number) {
            var numdivisibleby3 = number % 3;

            if (numdivisibleby3 == 0) return "Fizz";
            return number.ToString();
        }
    }
}
