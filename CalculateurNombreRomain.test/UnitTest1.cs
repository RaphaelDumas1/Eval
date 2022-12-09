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
    }
}