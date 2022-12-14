using static FinalProjectSimplified.Drawing.Draw;
using txt = FinalProjectSimplified.Texts;

namespace FinalProjectSimplified.UserInput;

internal class Input
{
    private const string INVALID_CHARS = ";+=´/)(\"§!'¨?,.:-_*-/+\\$@&#đĐ[]}{Ł€|<>ß¤÷×¸˝´°˛`˘°~^";

    public static int GetInt(string inputPrompt)
    {
        int i = 0;
        int output;

        do
        {
            if ( i == 1 ) { InputWarning(txt.INPUT_INT_WARNING); }

            InputPrompt(inputPrompt);
            i = 1;

        } 
        while ( !int.TryParse(Console.ReadLine()?.Trim(), out output)
                || output.ToString().Length > 9 );

        return output;
    }
    public static string GetString(string inputPrompt)
    {
        int i = 0;
        string output = string.Empty;

        do
        {
            if ( i == 1 ) { InputWarning(txt.INPUT_STRING_WARNING); }

            InputPrompt(inputPrompt);
            i = 1;

        } 
        while ( string.IsNullOrWhiteSpace(output = Console.ReadLine()?.Trim())
                || output.Any(char.IsDigit)
                || output.IndexOfAny(INVALID_CHARS.ToCharArray()) != -1 );

        return output;
    }
    public static void WaitForAnyKey()
    {
        Console.WriteLine();
        Console.Write(txt.CONTINUE_PROMPT);
        Console.ReadKey(true);
    }
}
