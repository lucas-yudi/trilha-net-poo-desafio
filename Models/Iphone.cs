namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone //REGRA 2 CONCLUIDA!
    {
        
        public Iphone(string modelo) : base(modelo)
        {
        }

        public Iphone(string modelo, string numero, string imei, int memoria) : base(modelo, numero, imei, memoria) { }

        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp){
            Console.WriteLine($"Instalando o Aplicativo {nomeApp} em SEU IPHONE!");
        }
    }
}