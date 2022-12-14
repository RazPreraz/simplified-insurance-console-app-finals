namespace FinalProjectSimplified.InsuranceLogic;

internal abstract class Applicant
{
    public string FirstName { get; init; }
    public string LastName { get; init; }
    public int Age { get; init; }
    public PhoneNumber PhoneNumber { get; init; }

    protected Applicant(string firstName, string lastName, int age, PhoneNumber phoneNumber)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
        PhoneNumber = phoneNumber;
    }
    protected Applicant(Applicant applicant)
    {
        FirstName = applicant.FirstName;
        LastName = applicant.LastName;
        Age = applicant.Age;
        PhoneNumber = applicant.PhoneNumber;
    }
}
