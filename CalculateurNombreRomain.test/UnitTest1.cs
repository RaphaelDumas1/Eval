namespace CalculateurNombreRomain.test
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        public void Test123(int n)
        {
            // ETANT DONNE un nombre compris entre 1 et 3
            var nombre = n;
            // QUAND on utilise la methode convertir
            var resultat = CalculateurNombreRomain.Convertir(nombre);

            // ALORS on obtient une string composee de n fois I
            var attendu = new string('I', n);
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

        public void Test5()
        {
            // ETANT DONNE un nombre 5
            var nombre = 5;
            // QUAND on utilise la methode convertir
            var resultat = CalculateurNombreRomain.Convertir(nombre);

            // ALORS on obtient V
            Assert.Equal("V", resultat);
        }

        [Theory]
        [InlineData(6)]
        [InlineData(7)]
        [InlineData(8)]
        public void Test678(int n)
        {
            // ETANT DONNE un nombre compris entre 6 et 8
            var nombre = n;
            // QUAND on utilise la methode convertir
            var resultat = CalculateurNombreRomain.Convertir(nombre);

            // ALORS on obtient une string composee de V plus n-5 fois I
            var deuxieme_partie = new string('I', n - 5);
            var attendu = "V" + deuxieme_partie;
            Assert.Equal(attendu, resultat);
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

        [Fact]

        public void Test10()
        {
            // ETANT DONNE un nombre 10
            var nombre = 10;
            // QUAND on utilise la methode convertir
            var resultat = CalculateurNombreRomain.Convertir(nombre);

            // ALORS on obtient X
            Assert.Equal("X", resultat);
        }
    }
}