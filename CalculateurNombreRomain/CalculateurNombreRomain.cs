namespace CalculateurNombreRomain
{
    public class CalculateurNombreRomain
    {
        public static  string Convertir(int nombre)
        {
            switch (nombre)
            {
                case 1:
                    return "I";
                default:
                    return "Erreur";
            }
        }
    }
}