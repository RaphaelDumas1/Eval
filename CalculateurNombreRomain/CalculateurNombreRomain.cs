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
                case 2:
                    return "II";
                case 3:
                    return "III";
                default:
                    return "Erreur";
            }
        }
    }
}