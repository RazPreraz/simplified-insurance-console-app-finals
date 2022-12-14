namespace FinalProjectSimplified.InsuranceLogic;

internal class Insured : Applicant
{
    public Insured(Applicant applicant) : base(applicant)
    {
    }

    public Insured(string firstName, string lastName, int age, PhoneNumber phoneNumber) 
            : base(firstName, lastName, age, phoneNumber)
    {
    }
}
