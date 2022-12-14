using FinalProjectSimplified.InsuranceLogic;

namespace FinalProjectSimplified;

internal class Globals
{
    public static AppState AppState { get; set; } = AppState.RUNNING;
    public static List<Insurance> Insurances = new();
}
