using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjetoPHAS
{
    class Program
    {
        static void Main(string[] args)
        {
            //Conectar o console com a Control
            Control controle = new Control();//Declaro e instancio a variável
            controle.Operacao();//Método Operação
            Console.ReadLine();//Leia - Mater o prompt aberto
        }//Fim do método main
    }//Fim da classe Program
}//Fim do projeto
