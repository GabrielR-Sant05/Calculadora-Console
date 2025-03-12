//libs padrões que não estão sendo utilizadas
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Classe calculadora e seu namespace
namespace se_usar_ia_se_ta_fudido
{
    public class Calculadora
    {
        //propriedades da classe
        public string Operacao { get; set; }
        public List<double> Valores { get; set; }
        public double result { get; set; }

        //métodos da classe
        //List é uma estrutura de dados que armazena uma coleção de elementos
        //foi utilizado para simular os varios valores que o usuário pode digitar, ao invés de criar várias variáveis, criamos uma lista direto
        public double Soma(List<double> valores, double result)
        {
            //inicializa a variável result, que é o resultado da operação, com 0, por result ser double, foi utilizado o Convert.ToDouble para converter o 0 para double
            result = Convert.ToDouble(0);
            //foreach é um laço de repetição que percorre todos os elementos de uma coleção, útil para diversas situações, semelhante a dois fors aninhados em C
            foreach (var valo in valores)
                {                     
                  result += valo;
                }             
            return result;
        }
        //Compare os metodos da Classe calculadora com os metodos da program que estão no arquivo Program.cs
        //vai ver que la os metodos estão sendo chamados de forma direta, aqui estão sendo chamados de forma indireta, através de um objeto da classe Calculadora
        //também é possivel observar que os metodos la estão como void e aqui estão como double, isso é porque os metodos la não retornam valor, apenas fazem a operação
        //enquanto os metodos aqui retornam o resultado da operação, por isso return result
        public double Sub(List<double> valores, double result)
        {
            result = Convert.ToDouble(0);
            foreach (var valo in valores)
            {
                result -= valo;
            }
            return result;
        }
        public double Mult(List<double> valores, double result)
        {
            result = Convert.ToDouble(0);
            foreach (var valo in valores)
            {
                result *= valo;
            }
            return result;
        }

        public double Div(List<double> valores, double result)
        {
            result = Convert.ToDouble(0);
            foreach (var valo in valores)
            {
                result /= valo;
            }
            return result;
        }
    }
}
