
Console.WriteLine("---------------------------------------");
Console.WriteLine("Bem vindo ao banco da indigo-hive");
var saldo = 0;
var opcao = 0;
var opcaoBlaze = 0;
Random random = new Random();
do
{
    Console.WriteLine("--------------------------------------");
    Console.WriteLine("Escolha alguma operação");
    Console.WriteLine("--------------------------------------");
    Console.WriteLine("1 - Depositar");
    Console.WriteLine("2 - Sacar");
    Console.WriteLine("3 - Ver Saldo");
    Console.WriteLine("4 - Apostar na blaze");
    Console.WriteLine("5 - Sair");
    Console.WriteLine("--------------------------------------");
    Console.WriteLine();

    opcao = int.Parse(Console.ReadLine());
    if (opcao == 1)
    {
        Console.WriteLine();
        Console.WriteLine("-----------------------------");
        Console.WriteLine("Quanto você quer depositar?");
        saldo += int.Parse(Console.ReadLine());
        Console.WriteLine("-----------------------------");
        Console.WriteLine($"Seu novo saldo é: {saldo}");
        Console.WriteLine("------------------------------");
        Console.WriteLine();
    }else if(opcao == 2)
    {
        Console.WriteLine("----------------------------");
        Console.WriteLine("Quanto você quer sacar?");
        var valor = int.Parse(Console.ReadLine());
        if (valor > saldo)
        {
            Console.WriteLine("Você não tem saldo o suficiente para sacar esse valor");
        }
        else
        {
            saldo -= valor;
            Console.WriteLine("----------------------------");
            Console.WriteLine($"Seu novo saldo é: {saldo}");
            Console.WriteLine("-----------------------------");
            Console.WriteLine();
        }

    }else if(opcao == 3)
    {
        Console.WriteLine($"Seu saldo é de: {saldo}");
    }else if(opcao == 4)
    {   
        Console.WriteLine("---------------------");
        Console.WriteLine("Bem vindo a blaze");
        Console.WriteLine("---------------------");
        Console.WriteLine();
        do
        {
            Console.WriteLine("-----------------");
            Console.WriteLine("1 - Foguetinho");
            Console.WriteLine("2 - Double");
            Console.WriteLine("3 - Voltar para o banco");
            opcaoBlaze = int.Parse(Console.ReadLine());

            if(opcaoBlaze == 1)
            {
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("Bem vindo ao foguetinho, quanto quer apostar??");
                var valorDaAposta = int.Parse(Console.ReadLine());
                if (valorDaAposta < saldo)
                {
                    saldo -= valorDaAposta;
                    Console.WriteLine("O foguetinho está em qual posição entre 0 a 10?");
                    var posicaoFoguete = int.Parse(Console.ReadLine());
                    var posicaoCerta = (random.Next(0, 11));
                    Console.WriteLine("-------------------------------------------------");
                    if (posicaoFoguete == posicaoCerta)
                    {
                        saldo += (valorDaAposta * posicaoCerta);
                        Console.WriteLine("-------------------------------------------------");
                        Console.WriteLine("Você ganhou!!");
                        Console.WriteLine($"Seu novo saldo é de {saldo}");
                    }
                    else
                    {
                        Console.WriteLine("-------------------------------------------------");
                        Console.WriteLine($"PERDEU, SEU SALDO ATUAL É DE: {saldo}");
                        Console.WriteLine("-------------------------------------------------");
                    }

                }
                else
                {
                    Console.WriteLine("------------------------------------------------------------------------");
                    Console.WriteLine("Você não possui saldo, volte para o menu inicial e faça um empréstimo!");
                    Console.WriteLine("------------------------------------------------------------------------");
                }
            }
            else if (opcaoBlaze == 2)
            {
                Console.WriteLine("-------------------------------------------------");
                Console.WriteLine("Bem vindo ao Double");
                Console.WriteLine("Quanto deseja apostar?");
                var valorDaAPosta = int.Parse (Console.ReadLine());
                Console.WriteLine("-------------------------------------------------");
                if (valorDaAPosta < saldo)
                {
                    saldo -= valorDaAPosta;
                    Console.WriteLine("-------------------------------------------------");
                    Console.WriteLine("Digite um número entre 0 e 5");
                    var numeroDouble = int.Parse(Console.ReadLine());
                    var numeroCerto = (random.Next(0, 5));
                    Console.WriteLine("-------------------------------------------------");
                    if (numeroDouble == numeroCerto)
                    {
                        saldo += (valorDaAPosta * 2);
                        Console.WriteLine("-------------------------------------------------");
                        Console.WriteLine("Você dobrou sua aposta!!");
                        Console.WriteLine($"Seu novo saldo é {saldo}");
                        Console.WriteLine("-------------------------------------------------");
                    }
                    else
                    {
                        Console.WriteLine("-------------------------------------------------");
                        Console.WriteLine($"PERDEU, SEU SALDO ATUAL É DE {saldo}");
                        Console.WriteLine("-------------------------------------------------");
                    }
                }
                else
                {
                    Console.WriteLine("------------------------------------------------------------------------");
                    Console.WriteLine("Você não possui saldo, volte para o menu inicial e faça um empréstimo!");
                    Console.WriteLine("------------------------------------------------------------------------");
                }
            }
        } 
        while (opcaoBlaze != 3);


    }
} while (opcao != 5);
