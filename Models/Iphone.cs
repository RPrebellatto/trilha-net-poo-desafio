namespace DesafioPOO.Models
{
    // Implementado
    public class IPhone : Smartphone
    {
        public IPhone(string numero, string modelo, string iMEI, int memoria) : base (numero, modelo, iMEI, memoria)
        {

        }

        // Implementado
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no IPhone");
        }
    }
}