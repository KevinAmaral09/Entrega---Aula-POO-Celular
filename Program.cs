using System;

namespace AulaPOOCelular
{
    class Program
    {
        static void Main(string[] args)
        {
            Celular celular1 = new Celular();

            celular1.modelo = "Iphone";
            celular1.cor = "Cinza";
            celular1.tamanho = 16;

            Console.WriteLine("Digite 1 para seu celular ligar, ou 2 para desligar o mesmo");
            int LigarOuDesligar = int.Parse(Console.ReadLine());

            if (LigarOuDesligar == 1)
            {
                celular1.ligar();
            }
            if (LigarOuDesligar == 2)
            {
                Console.WriteLine("Obrigado por escolher a Apple");
                celular1.desligar();
            }
            
            
            if (celular1.ligado == true)
                
                    Console.WriteLine(@"
|=================================================|
|                                                 |
|                   Você deseja:                  |
|             1 - Fazer uma ligação               |
|             2 - Enviar uma mensagem             |
|             3 - Desligar o celular              |
|             4 - Exibir informações do celular   |
|                                                 |
|=================================================|
                ");

                int opcaoMenu = int.Parse(Console.ReadLine());

                switch (opcaoMenu)
                {
                    case 1:
                        Console.WriteLine(celular1.ligacao());
                        Console.WriteLine($@"
|=================================================|
|                                                 |
|                                                 |
|           Digite o número  para qual você       |
|                    quer ligar                   |
|                                                 |
|                                                 |
|=================================================|
                            ");

                            string numeroEscolhido = Console.ReadLine();

                            Console.WriteLine($@"
|=================================================|
|                                                 |
|                                                 |
|             Ligando Para {numeroEscolhido}      |
|                                                 |
|                                                 |
|                                                 |
|=================================================|
                            ");

                            string enviarMensagem = Console.ReadLine();

                            Console.WriteLine($@"
|=================================================|
|                                                 |
|                                                 |
|              Escreva a sua mensagem             |
|                                                 |
|                                                 |
|                                                 |
|=================================================|
                            ");

                            string mensagem = Console.ReadLine();

                            Console.WriteLine($@"
|=================================================|
|                                                 |
|                                                 |
|    '{mensagem}'                                 |
|                  enviada para                   |
|                  {enviarMensagem}               |
|                                                 |
|=================================================| 
 
                            ");
                        break;
                        case 3:
                            celular1.desligar();
                        break;
                        case 4:
                            Console.WriteLine($@"
|=================================================|
|             Informações do Modelo               |
|                                                 |
|             Modelo: {celular1.modelo}           |
|             Cor: {celular1.cor}                 |
|             Tamanho: {celular1.tamanho}         |
|                                                 |
|=================================================|
                ");
                            break;
                    default:
                        break;
                }
                
        }
    }
}
