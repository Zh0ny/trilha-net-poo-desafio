namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        private string _number;
        public string Number
        {
            get { return _number; }
            set { _number = value; }
        }
        
        private string _model;
        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }
        
        private string _imei;
        public string Imei
        {
            get { return _imei; }
            set { _imei = value; }
        }
        
        private int _memory;
        public int Memory
        {
            get { return _memory; }
            set { _memory = value; }
        }
        
        public Smartphone(string number, string model, string imei, int memory)
        {
            Number = number;
            Model = model;
            Imei = imei;
            Memory = memory;
        }

        public void Call()
        {
            Console.WriteLine("Calling...");
        }

        public void RecieveCall()
        {
            Console.WriteLine("Recieving call...");
        }

        public abstract void InstallApplication(string appName);
    }
}