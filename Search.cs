using txt = FinalProjectSimplified.Texts;
using FinalProjectSimplified.UserInput;
using FinalProjectSimplified.InsuranceLogic;

namespace FinalProjectSimplified;

internal class Search
{
    public static Insurance? ForInsuranceByName(List<Insurance> insurances)
    {
        string firstNameToFind = Input.GetString(txt.FIRST_NAME_PROMPT).ToLower();
        string LastNameToFind = Input.GetString(txt.LAST_NAME_PROMPT).ToLower();

        for (int i = 0; i < insurances.Count; i++)
        {
            if (firstNameToFind + LastNameToFind
                == insurances[i].Insured.FirstName.ToLower() + insurances[i].Insured.LastName.ToLower())
            {
                return new Insurance(insurances[i]);
            }
        }
        return null;
    }
}
