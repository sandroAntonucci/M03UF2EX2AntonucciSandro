using System;
using ClassLibraryOperationModules;

namespace MyApplication
{

    public static class Operations
    {

        public static void Main()
        {

            const string MsgMenu = "Introdueix el que vols fer:\n\n1. Validar si un nombre és senar\n2. Calcular la potència d'un nombre\n3. Retornar un valor aleatori\n4. Comptar el nombre de vocals o consonants en un text\n5. Sortir\n\n - ";

            int option;

            do
            {
                Console.Write(MsgMenu);
                option = Convert.ToInt32(Console.ReadLine());
            } while (option < 1 || option > 5);
            
            switch(option)
            {
                // Validar Num Senar
                case 1:
                    break;

                // Calcular potència
                case 2:
                    break;

                // Retornar valor aleatori
                case 3:
                    break;

                // Nombre de vocals o consonants
                case 4:
                    break;
            }

        }

    }

}