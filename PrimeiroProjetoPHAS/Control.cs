using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjetoPHAS
{
    class Control
    {
        Calculadora calc;//Conectando a variável calc a classe calculadora
        private int opcao;
        public Control()
        {
            calc = new Calculadora();//Instanciando
        }//Fim do construtor

        public int ConsultarOpcao
        { 
            get { return opcao; }
            set { opcao = value; }
        }

        //Coletar
        public void ColetarNum1()
        {
            Console.WriteLine("Informe um número: ");
            calc.ConsultarNum1 = Convert.ToDouble(Console.ReadLine());
        }//Fim do método ColetarNum1

        public void ColetarNum2()
        {
            Console.WriteLine("Informe outro número: ");
            calc.ConsultarNum2 = Convert.ToDouble(Console.ReadLine());
        }//Fim do método ColetarNum2

        public void Menu()
        {
            Console.WriteLine(" ------ MENU ------ " + 
                              "\n0. Sair" +
                              "\n1. Somar" +
                              "\n2. Subtrair" +
                              "\n3. Multiplicar" +
                              "\n4. Dividir" +
                              "\n5. Potência" +
                              "\n6. Raiz do 1° número" +
                              "\n\n. Escolha uma das opções acima: ");
            ConsultarOpcao = Convert.ToInt32(Console.ReadLine());
        }//Fim método Menu

        public void Operacao()
        {
            do
            {
                Menu();
                Console.Clear();
                switch (ConsultarOpcao) //Escolha caso
                {
                    case 0:
                        Console.WriteLine("Obrigado!");
                        break;
                    case 1:
                        ColetarNum1();//Pegando o 1° número
                        ColetarNum2();//Pegando o 2° número
                        Console.WriteLine("A soma dos números digitados é: " + calc.Somar());
                        break;
                    case 2:
                        ColetarNum1();
                        ColetarNum2();
                        Console.WriteLine("A subtração dos númeors dogitados é: " + calc.Subtrair());
                        break;
                    case 3:
                        ColetarNum1();
                        ColetarNum2();
                        Console.WriteLine("A multiplicação dos números digitados é: " + calc.Multiplicar());
                        break;
                    case 4:
                        ColetarNum1();
                        ColetarNum2();
                        if (calc.Dividir() == -1)
                        {
                            Console.WriteLine("Impossível dividir");
                        }
                        Console.WriteLine("A divisão dos números digitados é: " + calc.Dividir());
                        break;
                    case 5:
                        ColetarNum1();
                        ColetarNum2();
                        Console.WriteLine("A potencia dos números é: " + calc.Potencia());
                        break;
                    case 6:
                        ColetarNum1();
                        ColetarNum2();
                        Console.WriteLine("A raiz do primeiro número é: " + calc.Raiz());
                        break;
                    default:
                        Console.WriteLine("A opção escolhida não é válida! Tente novamente.");
                        break;
                }//Fim do switch
            } while (ConsultarOpcao != 0);//Repita até - faça enquanto
        }//Fim do operacao

    }//Fim da classe
}//Fim do projeto
