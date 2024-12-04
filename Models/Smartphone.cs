namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama

        public string Modelo { get; set; }

        public string Imei { get; set; }

        public int Memoria { get; set; }
        

        public Smartphone(string modelo)
        {
            Modelo = modelo;
        
            // TODO: Passar os parâmetros do construtor para as propriedades
        }

        public Smartphone(string modelo, string numero, string imei, int memoria)
        {
            Modelo = modelo;
            Numero = numero;
            Imei = imei;
            Memoria = memoria;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}