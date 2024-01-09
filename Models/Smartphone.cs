using System;

namespace DesafioPOO.Models
{
    // Classe abstrata que serve como base para os smartphones
    public abstract class Smartphone
    {
        // Propriedades comuns a todos os smartphones
        public string Numero { get; set; }
        public string Modelo { get; set; }
        public string IMEI { get; set; }
        public int Memoria { get; set; }

        // Construtor da classe Smartphone, inicializa as propriedades comuns
        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }

        // Método para ligar o smartphone
        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        // Método para receber uma ligação
        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        // Método abstrato para instalar um aplicativo, será implementado pelas subclasses
        public abstract void InstalarAplicativo(string nomeApp);
    }
}
