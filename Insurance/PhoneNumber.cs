using System.Text;

namespace FinalProjectSimplified.InsuranceLogic;

internal class PhoneNumber
{
    public int AreaCode { get; init; }
    public int Number { get; init; }

    public PhoneNumber(int areaCode, int number)
    {
        AreaCode = areaCode;
        Number = number;
    }

    public PhoneNumber(int number)
    {
        AreaCode = 420;
        Number = number;
    }

    public string GetFormattedNumber()
    {
        StringBuilder sb = new();

        string numberString = Number.ToString();
        int numberLength = numberString.Length;

        for (int i = 0; i < numberLength; i++)
        {
            if (i % 3 == 0 && i != 0)
            {
                sb.Append(' ');
            }
            sb.Append(numberString[i]);
        }

        return sb.ToString();
    }
}
