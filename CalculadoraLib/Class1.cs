using System;
using System.Text;

namespace CalculadoraLib
{
    public class CalculadoraMachine
    {
        public int FuncionSumar(int recibeValor1Numero, int recibeValor2Numero)
        {
            int variableDeResultado = recibeValor1Numero + recibeValor2Numero; 
            return variableDeResultado;
        }






        public int FuncionRestar(int recibeValor1Numero, int recibeValor2Numero)
        {
            int variableDeResultado = recibeValor1Numero - recibeValor2Numero;
            return variableDeResultado;
        }
        public int FuncionMultiplicar(int multiplicando, int multiplicador)
        {
            int total = multiplicador * multiplicando;
            return total;
        }
        public int FuncionDividir(int dividendo, int divisor)
        {
            int total = dividendo / divisor;
            return total;
        }
    }
        
}
