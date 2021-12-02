namespace LoucaLiza.model.veiculo
{
    public class Status
    {
        public static string[] GetAvailable()
        {
            return new string[]
            {
                "Locado",
                "Disponível",
            };
        }
    }
}
