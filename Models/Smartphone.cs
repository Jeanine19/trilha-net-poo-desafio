using System;

namespace DesafioPOO.Models
{

      // TODO: Implementar as propriedades faltantes de acordo com o diagrama
    public abstract class Smartphone
    {
       // Propriedade encapsulada
        public string Numero { get; set; } 
        public string Modelo { get; set; }
        public string IMEI { get; set; }
        public int Memoria { get; set; }

          // TODO: Passar os parâmetros do construtor para as propriedades
        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;

        }

        // Métodos
        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

       
        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        // Método abstrato 
        public abstract void InstalarAplicativo(string nomeApp);
    }
}
