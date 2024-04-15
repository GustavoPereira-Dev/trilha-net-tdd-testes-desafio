using TestesUnitarios.Desafio.Console;

namespace TestesUnitarios.Desafio.Tests
{
    public class CalculadoraTests
    {
        public Calculadora construirClasse(){
           
            Calculadora calc = new Calculadora("02/02/2020");

            return calc;
        }


        [Theory]
        [InlineData (1 , 2, 3)]
        [InlineData (4 , 5, 9)]
        
        public void TesteSomar(int val1, int val2, int resultado){
            Calculadora calc = construirClasse();

            int resultadoCalculadora = calc.somar(val1, val2);

            Assert.Equal(resultado,resultadoCalculadora);
        }

        [Theory]
        [InlineData (6 , 4, 2)]
        [InlineData (11 , 10, 1)]
        public void TesteSubtrair(int val1, int val2, int resultado){
            Calculadora calc = construirClasse();

            int resultadoCalculadora = calc.subtrair(val1, val2);

            Assert.Equal(resultado,resultadoCalculadora);
        }


        [Theory]
        [InlineData (2 , 3, 6)]
        [InlineData (4 , 2, 8)]
        public void TesteMultiplicar(int val1, int val2, int resultado){
            Calculadora calc = construirClasse();

            int resultadoCalculadora = calc.multiplicar(val1, val2);

            Assert.Equal(resultado,resultadoCalculadora);
        }


        [Theory]
        [InlineData (6 , 3, 2)]
        [InlineData (5 , 5, 1)]
        public void TesteDividir(int val1, int val2, int resultado){
            Calculadora calc = construirClasse();

            int resultadoCalculadora = calc.dividir(val1, val2);

            Assert.Equal(resultado,resultadoCalculadora);
        }


        [Fact]
        public void TesteDivisaoPorZero(){
            Calculadora calc = construirClasse();

            Assert.Throws<DivideByZeroException>(
                () => calc.dividir(3,0)
            );
        }

        [Theory]
        [InlineData (2 , 2, 4)]
        [InlineData (3 , 3, 27)]
        public void TesteExponenciar(int val1, int val2, int resultado){
            Calculadora calc = construirClasse();

            int resultadoCalculadora = calc.exponenciar(val1, val2);

            Assert.Equal(resultado,resultadoCalculadora);
        }

        [Theory]
        [InlineData (4 , 2, 2)]
        [InlineData (8 , 3, 2)]
        public void TesteRadiciar(int val1, int val2, int resultado){
            Calculadora calc = construirClasse();

            int resultadoCalculadora = calc.radiciar(val1, val2);

            Assert.Equal(resultado,resultadoCalculadora);
        }

        [Fact]
        public void TestarHistorico(){
            Calculadora calc = construirClasse();

            calc.somar(1,2);
            calc.subtrair(4,2);
            calc.multiplicar(3,2);
            calc.dividir(6,2);

            var lista = calc.historico();

            Assert.NotEmpty(lista);
            Assert.Equal(3, lista.Count);
        }
    }
}