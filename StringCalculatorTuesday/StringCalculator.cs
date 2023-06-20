
namespace StringCalculator;

public class StringCalculator
{

    public int Add(string numbers)
    {
        if (numbers == "")
        {
            return 0;
        }
        else
        {
            return int.Parse(numbers);
        }
    }
}
