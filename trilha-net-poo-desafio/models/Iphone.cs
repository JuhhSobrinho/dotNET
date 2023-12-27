namespace trilha_net_poo_desafio.models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
            // Pode adicionar lógica específica da classe Nokia aqui, se necessário
        }
        public override void InstalarAplicativo(string nomeApp)
        {
            System.Console.WriteLine($"Instalar app {nomeApp}");
        }
    }
}