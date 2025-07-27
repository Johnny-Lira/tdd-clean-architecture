namespace FizzBuzz;

public static class FizzBuzzGame
{
    public static string Play(int number)
    {
        return (number % 3 == 0, number % 5 == 0) switch
        {
            (true, true) => nameof(Result.FizzBuzz),
            (true, false) => nameof(Result.Fizz),
            (false, true) => nameof(Result.Buzz),
            _ => number.ToString()
        };
    }

    private static bool IsDivisibleBy(
        this int i, int divisibleby)
        => i % divisibleby == 0;
}