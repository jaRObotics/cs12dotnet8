using static System.Console;

internal partial class Program
{
    private static void Main(string[] args)
    {
        WriteLine("* Top-level functions example");
        WhatsMyNamespace(); // Call the function.

        void JaroMethod()
        {
            WriteLine();
        }

        Jaro2();
        var res = JaroMethodTest2();
    }

    public static void Jaro2() //static because I want ot cal it from Main (which is static)
    {
        WriteLine();
    }
}