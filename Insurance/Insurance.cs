namespace FinalProjectSimplified.InsuranceLogic;

internal class Insurance
{
    public int InsuranceID { get; init; }
    public Insured Insured  { get; init; }

    public Insurance(Insured insured)
    {
        Insured = insured;
        InsuranceID = Insured.GetHashCode() * 20;
    }
    public Insurance(Insurance insurance)
    {
        Insured = insurance.Insured;
        InsuranceID = insurance.InsuranceID;
    }
}
