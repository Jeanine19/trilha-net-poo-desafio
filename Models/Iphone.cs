using System;

namespace DesafioPOO.Models
{
    // Herda da classe "Smartphone"
    public class Iphone : Smartphone
    {
        // Construtor da classe Iphone
        public Iphone(string numero, string modelo, string imei, int memoria)
            : base(numero, modelo, imei, memoria)
        {
        }

        // Sobrescreve o metodo abstrato
        public override void InstalarAplicativo(string nomeApp)
        {
            
            Console.WriteLine($"Instalando {nomeApp} no iPhone...");
        }

       
    }
}
