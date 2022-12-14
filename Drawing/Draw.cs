using System.Text;
using FinalProjectSimplified.InsuranceLogic;
using txt = FinalProjectSimplified.Texts;

namespace FinalProjectSimplified.Drawing;

internal class Draw
{
    private const int INSURANCE_ID_ALIGNMENT = -13;
    private const int FIRST_NAME_ALIGNMENT = -14;
    private const int LAST_NAME_ALIGNMENT = -15;
    private const int AGE_ALIGNMENT = -4;
    private const int PHONE_NUMBER_ALIGNMENT = -11;

    private const int ALIGNMENT_SPACES_TOTAL = -( INSURANCE_ID_ALIGNMENT
                                                  + FIRST_NAME_ALIGNMENT
                                                  + LAST_NAME_ALIGNMENT
                                                  + AGE_ALIGNMENT
                                                  + PHONE_NUMBER_ALIGNMENT ) + 9;

    private static readonly string _appTitleBorder = GetAppTitleBorder();

    public static void AppTitle()
    {
        Console.Clear();

        Console.WriteLine(_appTitleBorder);
        Console.WriteLine(txt.APP_TITLE);
        Console.WriteLine(_appTitleBorder);
        Console.WriteLine();
    }
    public static void OptionsMenu()
    {
        Console.WriteLine($"1 - {txt.ADD_INSURED_OPTION}");
        Console.WriteLine($"2 - {txt.PRINT_ALL_INSURED_OPTION}");
        Console.WriteLine($"3 - {txt.SEARCH_FOR_INSURED_OPTION}");
        Console.WriteLine($"4 - {txt.EXIT_APP_OPTION}");
        Console.WriteLine();
    }
    public static void InputPrompt(string inputPrompt)
    {
        Console.Write($"{inputPrompt}: ");
    }
    public static void InputWarning(string warning)
    {
        Console.WriteLine(warning);
    }
    public static void InsurancesColumnDescription()
    {
        StringBuilder sb = new();

        Console.WriteLine();
        Console.WriteLine($"{"ID pojištění", INSURANCE_ID_ALIGNMENT}|" +
            $"{"Křestní jméno", FIRST_NAME_ALIGNMENT}|" +
            $"{"Příjmení", LAST_NAME_ALIGNMENT}|" +
            $"{"Věk", AGE_ALIGNMENT}|" +
            $"{"Tel. číslo"}");

        for ( int i = 0; i < ALIGNMENT_SPACES_TOTAL; i++ )
        {
            if ( i == -INSURANCE_ID_ALIGNMENT ) { sb.Append('|'); }
            else if ( i == -( INSURANCE_ID_ALIGNMENT + FIRST_NAME_ALIGNMENT ) + 1 ) { sb.Append('|'); }
            else if ( i == -( INSURANCE_ID_ALIGNMENT + FIRST_NAME_ALIGNMENT + LAST_NAME_ALIGNMENT ) + 2 ) { sb.Append('|'); }
            else if ( i == -( INSURANCE_ID_ALIGNMENT + FIRST_NAME_ALIGNMENT + LAST_NAME_ALIGNMENT + AGE_ALIGNMENT ) + 3 ) { sb.Append('|'); }
            else if ( i == ALIGNMENT_SPACES_TOTAL + 4 ) { sb.Append('|'); }
            else { sb.Append('='); }
        }

        Console.WriteLine(sb);
    }
    public static void InsurancesListInColumns(List<Insurance> insurances)
    {
        foreach ( var insurance in insurances )
        {
            Draw.Insurance(insurance);
        }
    }
    public static void Insurance(Insurance insurance)
    {
        Console.WriteLine(
            $"{insurance.InsuranceID, INSURANCE_ID_ALIGNMENT}|" +
            $"{insurance.Insured.FirstName, FIRST_NAME_ALIGNMENT}|" +
            $"{insurance.Insured.LastName, LAST_NAME_ALIGNMENT}|" +
            $"{insurance.Insured.Age, AGE_ALIGNMENT}|" +
            $"{"+" + insurance.Insured.PhoneNumber.AreaCode} {insurance.Insured.PhoneNumber.GetFormattedNumber()}");
    }
    private static string GetAppTitleBorder()
    {
        StringBuilder sb = new();

        for ( int i = 0; i < txt.APP_TITLE.Length + 9; i++ )
        {
            sb.Append('=');
        }

        return sb.ToString();
    }
}
