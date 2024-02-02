using System;
using DesafioPOO.Models;

namespace DesafioPOO
{
// TODO: Realizar os testes com as classes Nokia e Iphone
    class Program
    {
        static void Main()
        {
            try
            {
                // usuário para digitar para o nokia 
                Console.Write("Digite o número do Nokia: ");
                string numeroNokia = Console.ReadLine();

                Console.Write("Digite o modelo do Nokia: ");
                string modeloNokia = Console.ReadLine();

                Console.Write("Digite o IMEI do Nokia: ");
                string imeiNokia = Console.ReadLine();

                Console.Write("Digite a memória do Nokia (em GB): ");
                if (!int.TryParse(Console.ReadLine(), out int memoriaNokia))
                {
                    throw new ArgumentException("A memória deve ser um número inteiro.");
                }

                // Criando uma instância
                Nokia nokiaPhone = new Nokia(numeroNokia, modeloNokia, imeiNokia, memoriaNokia);

                // Chamando métodos e testando funcionalidades do Nokia
                Console.WriteLine($"Número do Nokia: {nokiaPhone.Numero}");
                Console.WriteLine($"Modelo do Nokia: {nokiaPhone.Modelo}");
                Console.WriteLine($"IMEI do Nokia: {nokiaPhone.IMEI}");
                Console.WriteLine($"Memória do Nokia: {nokiaPhone.Memoria}GB");

                nokiaPhone.Ligar();
                nokiaPhone.ReceberLigacao();
                nokiaPhone.InstalarAplicativo("AppNokia");

                Console.WriteLine();

                // Solicitar ao usuário para digitar informações para o iPhone
                Console.Write("Digite o número do iPhone: ");
                string numeroIphone = Console.ReadLine();

                Console.Write("Digite o modelo do iPhone: ");
                string modeloIphone = Console.ReadLine();

                Console.Write("Digite o IMEI do iPhone: ");
                string imeiIphone = Console.ReadLine();

                Console.Write("Digite a memória do iPhone (em GB): ");
                if (!int.TryParse(Console.ReadLine(), out int memoriaIphone))
                {
                    //messagem de erro 
                    throw new ArgumentException("A memória deve ser um número inteiro.");
                }

                // instância
                Iphone iphone = new Iphone(numeroIphone, modeloIphone, imeiIphone, memoriaIphone);

                // Chamando métodos e testando funcionalidades do iPhone
                Console.WriteLine($"Número do iPhone: {iphone.Numero}");
                Console.WriteLine($"Modelo do iPhone: {iphone.Modelo}");
                Console.WriteLine($"IMEI do iPhone: {iphone.IMEI}");
                Console.WriteLine($"Memória do iPhone: {iphone.Memoria}GB");

                iphone.Ligar();
                iphone.ReceberLigacao();
                iphone.InstalarAplicativo("AppiPhone");
            }
            catch (Exception ex)//lidar com erro 
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }
        }
    }
}
