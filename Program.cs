
namespace ProjetoSeletivoTarget
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Autor: Tailson Alves");
            Console.WriteLine("\n\"Abaixo estão contidas todas as questões para o\nprocesso seletivo de estagio na Target Sistemas.\nInforme o numero da questao para obter o resultado.\"");
            Console.WriteLine("\n\n\t- Questoes -\n");

            Console.WriteLine(" 1 - Encontre o valor de SOMA..");
            Console.WriteLine(" 2 - Fibonacci...");
            Console.WriteLine(" 3 - Descubra a logica e encontre o proximo elemento...");
            Console.WriteLine(" 4 - Interruptores...");
            Console.WriteLine(" 5 - Inversor de strings...");

            Console.Write("\n_ Informe o numero da questao: ");
            int questao = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("-----------------------------------\n");
            switch (questao)
            {
                case 1:
                    Questao1();
                    break;
                case 2:
                    Questao2();
                    break;
                case 3:
                    Questao3();
                    break;
                case 4:
                    Questao4();
                    break;
                case 5:
                    Questao5();
                    break;
                default:
                    Console.Write("Opcao invalida!");
                    break;
            }

            Console.ReadKey();
        }

        public static void Questao1()
        {
            int indice = 13;
            int soma = 0;
            int k = 0;

            while (k < indice)
            {
                k = k + 1;
                soma = soma + k;
            }

            Console.WriteLine("* O valor de Soma eh " + soma);
        }
        public static void Questao2()
        {
            int ant = 1;
            int ult = 0;
            int atual = 1;

            Console.Write("_ Numero a ser verificado: ");
            int valor = Convert.ToInt32(Console.ReadLine());

            while (atual < valor)
            {
                if (valor == 0 || valor == 1)
                {
                    Console.Write("\n* O valor {valor} pertence a sequencia de Fibonnacci.");
                }
                else
                {
                    atual = ant + ult;
                    ult = ant;
                    ant = atual;

                }
            }
            if (atual == valor)
            {
                Console.WriteLine($"\n* O valor {valor} pertence a sequencia de Fibonnacci.");
            }
            else
            {
                Console.WriteLine($"\n* O valor {valor} NAO pertence a sequencia de Fibonnacci.");
            }
        }
        public static void Questao3()
        {
            Console.WriteLine("a) : 9  \t* Numeros Impares");
            Console.WriteLine("b) : 128\t* O numero seguinte e o dobro do anterior");
            Console.WriteLine("c) : 49 \t* A raiz quadrada de cada numero segue a seq 0,1,2,3... logo 7^2 = 49");
            Console.WriteLine("d) : 100\t* A raiz quadrada de cada numero segue a seq dos numeros pares, logo 10 * 10 = 100");
            Console.WriteLine("e) : 13 \t* Sequencia de fibonacci, logo 13 = 8 + 5");
            Console.WriteLine("f) : 200\t* A fonetica da sequencia indica os numero naturais" +
            "que comecam com a letra D, logo a proximo numero depois de 19 que comeca com D eh Duzentos");
        }
        public static void Questao4()
        {
            Console.WriteLine(@"* Observa-se que a caracteristica ligado e desligado da lampada e insuficiente para 3 cenarios
      diferentes podendo ir apenas duas vezes visitar os quartos. No entanto, se considerarmos o aspecto fisico-quimico de
      uma lampada teremos 3 fatores de comparacao. Logo, para fazer o mapeamento dos interruptores basta deixar o interruptor A
      ligado por 30 minutos e depois apagar, logo apos isso ligasse o interruptor B e mantem o interruptor C desligado.");

            Console.WriteLine(@"- Tanto na primeira ida quanto na segunda ja se sabera o interruptor associado, pois temos o seguinte cenario:
      Lampada Apagada Quente: interruptor A
      Lampada Acesa:          interruptor B
      Lampada Apagada Fria:   interruptor D");

            Console.WriteLine("- O terceiro interruptor sera definido por exclusao das outras duas ja mapeadas.");



        }
        public static void Questao5()
        {

            Console.Write("_Digite um texto: ");
            string? entrada = Console.ReadLine();
            if (entrada is null)
            {
                return;
            }

            char[] texto = entrada.ToArray();

            int tamanho = texto.Count();
            string result = "";
            for (int i = tamanho - 1; i >= 0; i--)
            {
                result += texto[i];
            }

            Console.WriteLine("\n* String convertida: " + result);
        }

    }
}

