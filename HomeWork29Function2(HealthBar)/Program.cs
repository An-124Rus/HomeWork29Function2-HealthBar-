internal class Program
{
    private static void Main(string[] args)
    {
        int currentValue = 40;
        int maxValue = 100;
        
        Bar(currentValue, maxValue, ConsoleColor.Red, 3, 1);
    }

    static void Bar(int currentValue, int maxValue, ConsoleColor color, int columnPosition, int linePosition)
    {
        ConsoleColor defaultColor = Console.BackgroundColor;

        int convertToPercentValue = 10;
        int valueInPercent = currentValue / convertToPercentValue;
        int maxValueInPercent = maxValue / convertToPercentValue;
        string bar = "";

        for (int i = 0; i < valueInPercent; i++)
            bar += '#';

        Console.SetCursorPosition(columnPosition, linePosition);
        Console.Write('[');
        Console.BackgroundColor = color;
        Console.Write(bar);
        Console.BackgroundColor = defaultColor;

        bar = "";

        for (int i = valueInPercent; i < maxValueInPercent; i++)
            bar += '_';

        Console.Write(bar + ']');
    }
}