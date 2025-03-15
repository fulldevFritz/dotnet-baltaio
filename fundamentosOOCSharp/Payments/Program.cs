internal class Program
{
    private static void Main(string[] args)
    {
        // Tipo de referencia
        // -> Endereço dos dados

        var customer = new Customer();
        customer.Name = "Fritas";
        Console.WriteLine("Hello, World!");
    }

    class Customer
    {
        public string Name { get; set; }
    }

    class Pagamento
    {
        // Propriedades
        DateTime Vencimento;

        // Metodos
        void Pagar(){
            ConsultarSaldoDoCartao();
        }

        private void ConsultarSaldoDoCartao(){

        }

    }
}