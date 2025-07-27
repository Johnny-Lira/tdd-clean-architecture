using FluentAssertions;

namespace FizzBuzz.Tests;

public class FizzBuzzTests
{
    [Theory]
    [InlineData(1)]
    [InlineData(2)]
    [InlineData(4)]
    public void GiveANumberNotDivisibleBy3or5_ThenReturnsNumberString(int number)
    {
        var result = FizzBuzzGame.Play(number);

        result.Should().Be(number.ToString());
    }

    [Theory]
    [InlineData(5)]
    [InlineData(10)]
    [InlineData(20)]
    public void GivenANumberDivisibleBy5_ThenReturnsBuzz(int number)
    {
        var result = FizzBuzzGame.Play(number);

        result.Should().Be("Buzz");
    }
    
    [Theory]
    [InlineData(3)]
    [InlineData(6)]
    [InlineData(9)]
    public void GivenANumberDivisibleBy3_ThenReturnsFizz(int number)
    {
        var result = FizzBuzzGame.Play(number);

        result.Should().Be("Fizz");
    }
}