namespace ConsoleLib;

internal class ErrorSystem
{
    public static void ShowCriticalError(string smallErrorDescription, bool inFrench = false)
    {
        if (inFrench)
        {
            Console.WriteLine(
                $"\nAVERTISSEMENT : une erreur {smallErrorDescription} mène à l'incapacité " +
                 "de poursuivre les opérations de ce programme.\nFermeture du programme...");
        }
        else
        {
            Console.WriteLine(
                $"\nWARNING : a critical error {smallErrorDescription} prevents the program " +
                 "from pursuing operations.\nProgram exiting...");
        }
    }
}
