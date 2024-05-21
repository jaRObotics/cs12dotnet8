//TimesTable(number: 7, size: 10);

internal partial class Program
{
    private static void Main(string[] args)
    {
        TimesTable(2, 5);


        ConfigureConsole(); // Uses en-US by default.
                            //ConfigureConsole(useComputerCulture: true);
                            //ConfigureConsole(culture: "fr-FR");

        decimal taxToPay = CalculateTax(amount: 149, twoLetterRegionCode: "FR");
        WriteLine($"You must pay {taxToPay:C} in tax.");

        RunCardinalToOrdinal();

        RunFactorial();

        RunFibImperative();
        RunFibFunctional();
    }
}