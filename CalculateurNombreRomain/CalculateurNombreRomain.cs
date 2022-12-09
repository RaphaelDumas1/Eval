namespace CalculateurNombreRomain
{
    public class CalculateurNombreRomain
    {
        public static string[] nombresUnite = {"", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX"};
        public static string[] nombresDizaine = {"", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
        public static  string Convertir(int nombre)
        {
            string str_nombre = nombre.ToString();
            int nombre_de_chiffre = str_nombre.Length;
            switch (nombre_de_chiffre)
            {
                case 1:
                    return nombresUnite[nombre];
                case 2:
                    char second_chiffre_str = str_nombre[1];
                    int second_chiffre = second_chiffre_str - '0';
                    char premier_chiffre_str = str_nombre[0];
                    int premier_chiffre = premier_chiffre_str - '0';
                    return (nombresDizaine[premier_chiffre] + nombresUnite[second_chiffre]);
                default:
                    return "erreur";

            }
        }
    }
}