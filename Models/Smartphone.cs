namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        private string Modelo { get; set; }
        private string IMEI { get; set; }
        private int Memoria { get; set; }

        public Smartphone()
        {
            
        }      

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
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
        protected void ExibirDadosSmartphone()
        {
            System.Console.WriteLine
            (@$"
            Dados do Smartphone
            _____________________________________

                Número de Telefone: {Numero}
                Nome do Modelo: {Modelo}
                Número do IMEI: {IMEI}
                Quantidade de Memória: {Memoria}GB
            ");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}