using txt = FinalProjectSimplified.Texts;
using FinalProjectSimplified.UserInput;

namespace FinalProjectSimplified.InsuranceLogic;

internal class InsuranceFactory
{
    public static Insurance CreateNewInsurance()
    {
        Console.WriteLine();
        string firstName = Input.GetString(txt.FIRST_NAME_PROMPT);
        string lastName = Input.GetString(txt.LAST_NAME_PROMPT);
        int age = Input.GetInt(txt.AGE_PROMPT);
        int phoneNumber = Input.GetInt(txt.PHONE_NUMBER_PROMPT);

        PhoneNumber pn = new(phoneNumber);

        Insured insured = new(firstName, lastName, age, pn);
        return new Insurance(insured);
    }

    public static Insurance CreateTestInsurance()
    {
        PhoneNumber pn = new(777888999);

        Insured insured = new("TEST KŘESTNÍ", "TEST PŘÍJMENÍ", 999, pn);
        return new Insurance(insured);
    }
}
