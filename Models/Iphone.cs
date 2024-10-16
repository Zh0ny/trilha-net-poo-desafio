namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public Iphone(string number, string model, string imei, int memory) : base(number, model, imei, memory)
        {
            Number = number;
            Model = model;
            Imei = imei;
            Memory = memory;
        }

        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstallApplication(string appName)
        {
            Console.WriteLine($"Installing an App on your Iphone named: {appName}");
        }
    }
}