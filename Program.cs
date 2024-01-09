using System;
using DesafioPOO.Models;

namespace DesafioPOO
{
    class Program
    {
        static void Main()
        {
            // Criando uma instância de Nokia
            Nokia nokiaPhone = new Nokia("123456789", "Nokia Model X", "IMEI123", 64);

            // Chamando métodos e testando funcionalidades do Nokia
            Console.WriteLine($"Número do Nokia: {nokiaPhone.Numero}");
            Console.WriteLine($"Modelo do Nokia: {nokiaPhone.Modelo}");
            Console.WriteLine($"IMEI do Nokia: {nokiaPhone.IMEI}");
            Console.WriteLine($"Memória do Nokia: {nokiaPhone.Memoria}GB");

            nokiaPhone.Ligar();
            nokiaPhone.ReceberLigacao();
            nokiaPhone.InstalarAplicativo("AppNokia");

            Console.WriteLine();

            // Criando uma instância de Iphone
            Iphone iphone = new Iphone("987654321", "iPhone 12", "IMEI456", 128);

            // Chamando métodos e testando funcionalidades do iPhone
            Console.WriteLine($"Número do iPhone: {iphone.Numero}");
            Console.WriteLine($"Modelo do iPhone: {iphone.Modelo}");
            Console.WriteLine($"IMEI do iPhone: {iphone.IMEI}");
            Console.WriteLine($"Memória do iPhone: {iphone.Memoria}GB");

            iphone.Ligar();
            iphone.ReceberLigacao();
            iphone.InstalarAplicativo("AppiPhone");
        }
    }
}
