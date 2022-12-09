namespace CalculateurNombreRomain.test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            // ETANT DONNE une nombre 1
            int nombre = 1;

            // QUAND on utilise la methode convertir
            var resultat = CalculateurNombreRomain.Convertir(1);

            // Alors on obtient I
            Assert.Equal("I", resultat);
        }
        [Fact]
        public void Test2()
        {
            // ETANT DONNE une nombre 2
            int nombre = 2;

            // QUAND on utilise la methode convertir
            var resultat = CalculateurNombreRomain.Convertir(2);

            // Alors on obtient II
            Assert.Equal("II", resultat);
        }
    }
}