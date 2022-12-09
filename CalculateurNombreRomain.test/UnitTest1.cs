namespace CalculateurNombreRomain.test
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        public void Test(int n)
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

        [Fact]

        public void Test6()
        {
            // ETANT DONNE un nombre 6
            var nombre = 6;
            // QUAND on utilise la methode convertir
            var resultat = CalculateurNombreRomain.Convertir(nombre);

            // ALORS on obtient V
            Assert.Equal("VI", resultat);
        }

        [Fact]

        public void Test7()
        {
            // ETANT DONNE un nombre 7
            var nombre = 7;
            // QUAND on utilise la methode convertir
            var resultat = CalculateurNombreRomain.Convertir(nombre);

            // ALORS on obtient VII
            Assert.Equal("VII", resultat);
        }

        [Fact]

        public void Test8()
        {
            // ETANT DONNE un nombre 8
            var nombre = 8;
            // QUAND on utilise la methode convertir
            var resultat = CalculateurNombreRomain.Convertir(nombre);

            // ALORS on obtient VIII
            Assert.Equal("VIII", resultat);
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