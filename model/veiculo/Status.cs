using System;

namespace LoucaLiza.model.veiculo
{
    public class Status
    {
        public static string DISPONIVEL = "Disponível";
        public static string LOCADO = "Locado";

        public static string[] GetAvailable()
        {
            return new string[]
            {
                LOCADO,
                DISPONIVEL,
            };
        }

        public static bool? Parse(string value)
        {
            if (value == DISPONIVEL)
            {
                return true;
            }

            if (value == LOCADO)
            {
                return false;
            }

            return null;
        }
    }
}
