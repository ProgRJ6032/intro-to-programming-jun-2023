

namespace GreeterPractice;

public class GreetingTests
{
    [Theory]
    [InlineData("Hello, Windom!", "Windom")]
    [InlineData("Hello, Cooper!", "Cooper")]
    [InlineData("Hello, Chief!", null)]
    [InlineData("HELLO, BOB!", "BOB")]
    [InlineData("Hello, Bob and Sue!", "Bob", "Sue")]
    [InlineData("Hello, Bob, Jim, and Sue!", "Bob", "Jim", "Sue")]
    [InlineData("HELLO, BOB, JIM, AND SUE!", "BOB", "JIM", "SUE")]
    [InlineData("Hello, Bob, Jim, AND SUE!", "Bob", "SUE", "Jim")]

    public void SingleName(string expected, params string[] names)
    {
        var greeter = new GreetingMaker();
        string greeting = greeter.Greet(names);
        Assert.Equal(expected, greeting);
    }


}
