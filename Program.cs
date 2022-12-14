using FinalProjectSimplified;
using FinalProjectSimplified.InsuranceLogic;
using FinalProjectSimplified.UserInput;
using FinalProjectSimplified.Drawing;
using txt = FinalProjectSimplified.Texts;

internal class Program
{
    private static void Main(string[] args)
    {
        do
        {
            int menuOption = 0;

            Draw.AppTitle();
            Draw.OptionsMenu();

            while ( menuOption < 1 || menuOption > 4 )
            {
                menuOption = Input.GetInt(txt.MENU_OPTION_PROMPT);
            }

            switch ( menuOption )
            {
                case 1:
                    Globals.Insurances.Add(InsuranceFactory.CreateNewInsurance());
                    Input.WaitForAnyKey();
                    break;

                case 2:
                    if ( Globals.Insurances.Count == 0 )
                    {
                        Console.WriteLine(txt.EMPTY_INSURANCES_LIST_WARNING);
                        Input.WaitForAnyKey();
                        break;
                    }

                    Draw.InsurancesColumnDescription();
                    Draw.InsurancesListInColumns(Globals.Insurances);
                    Input.WaitForAnyKey();
                    break;

                case 3:
                    if ( Globals.Insurances.Count == 0 )
                    {
                        Console.WriteLine(txt.EMPTY_INSURANCES_LIST_WARNING);
                        Input.WaitForAnyKey();
                        break;
                    }

                    Insurance? insuranceFound = Search.ForInsuranceByName(Globals.Insurances);

                    if ( insuranceFound == null )
                    {
                        Console.WriteLine(txt.INSURANCE_NOT_FOUND_WARNING);
                        Input.WaitForAnyKey();
                        break;
                    }

                    Draw.InsurancesColumnDescription();
                    Draw.Insurance(insuranceFound);
                    Input.WaitForAnyKey();
                    break;

                case 4:
                    Globals.AppState = AppState.EXIT;
                    break;
            }

        } while ( Globals.AppState != AppState.EXIT );

    }
}