namespace FizzBuzzPractice.Kata
{
    public class FizzBuzz
    {
        public string Fizz(int number) {
            var numdivisibleby3 = number % 3;

            if (numdivisibleby3 == 0) return "Fizz";
            return number.ToString();
        }

        public string Buzz(int number) {
            var numdivisibleby5 = number % 5;
            if (numdivisibleby5 == 0) return "Buzz";
            return number.ToString();
        }

        public string FBuzz(int number) {
            var numdivisibleby3 = number % 3;
            var numdivisibleby5 = number % 5;

            if (numdivisibleby3 == 0 && numdivisibleby5 == 0) return "FizzBuzz";
            return number.ToString();
        }
    }
}
