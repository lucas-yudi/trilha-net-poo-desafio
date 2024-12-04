namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone //REGRA 2 CONCLUIDA!!
    {
        public Nokia(string modelo) : base(modelo)
        {
        }
        public Nokia(string modelo, string numero, string imei, int memoria) : base(modelo, numero, imei, memoria) { }

        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp){
            Console.WriteLine($"Instalando Aplicativo {nomeApp} em SEU ANDROID!");
        }
    }
}