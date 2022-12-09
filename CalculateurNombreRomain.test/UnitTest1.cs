namespace CalculateurNombreRomain.test
{


    public class UnitTest1
    {
        public static IEnumerable<(int valeur, string romain)> liste_multiple_cinq  => new[]
        {   
            (0, ""),
            (5, "V"),
            (10, "X"),
            (15, "XV"),
            (20, "XX"),
            (25, "XXV"),
            (30, "XXX"),
        };
        private static IEnumerable<object[]> multiple_de_cinq_plus_trois()
        {
            foreach (var (valeur, romain) in liste_multiple_cinq)
            {
                yield return new object[] { valeur, valeur, romain };
                yield return new object[] { valeur, valeur + 1, romain };
                yield return new object[] { valeur, valeur + 2, romain };
                yield return new object[] { valeur, valeur + 3, romain };
            }
        }
        public static object[][] cas_multiple_de_cinq_plus_trois=> multiple_de_cinq_plus_trois().ToArray();
        [Theory]
        [MemberData(nameof(cas_multiple_de_cinq_plus_trois))]
        public void Test_multiple_cing_plus_trois(int multiple_de_cinq, int nombre, string romain)
        {
            // ETANT DONNE un nombre n multiple de 5 ainsi que les trois nombres qui le suivent
            // QUAND on utilise la methode convertir
            var resultat = CalculateurNombreRomain.Convertir(nombre);

            // ALORS on obtient une string composee du multiple de cing plus n-multipledecinq fois I 
            var attendu = romain + new string('I', nombre - multiple_de_cinq);
            Assert.Equal(attendu, resultat);
        }

        [Fact]

        public void Test4()
        {
            // ETANT DONNE un nombre 4
            var nombre = 4;
            // QUAND on utilise la methode convertir
            var resultat = CalculateurNombreRomain.Convertir(nombre);

            // ALORS on obtient IV
            Assert.Equal("IV", resultat);
        }

        [Fact]

        public void Test9()
        {
            // ETANT DONNE un nombre 9
            var nombre = 9;
            // QUAND on utilise la methode convertir
            var resultat = CalculateurNombreRomain.Convertir(nombre);

            // ALORS on obtient IX
            Assert.Equal("IX", resultat);
        }

    }
}