namespace ClassLibraryOperationModules
{
    public class OperationModules
    {

        public static bool IsNatural(int num)
        {
            return num > 0;
        }

        public static bool OddNum(int num)
        {
            // Retorna true si és senar
            return num % 2 == 1;
        }
    }
}
