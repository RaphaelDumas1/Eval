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
    }
}