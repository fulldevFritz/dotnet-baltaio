Console.Clear();

var arr = new int[3];

try
{
    //System.IndexOutOfRangeException
    // for (int index = 0; index < 10; index++)
    // {
    //     Console.WriteLine(arr[index]);
    // }    
    Salvar("");
}
catch (IndexOutOfRangeException ex){
    Console.WriteLine(ex.Message);
    Console.WriteLine(ex.InnerException);
    Console.WriteLine("Não encontrei o indice na lista");
}
catch (Exception ex)
{
    Console.WriteLine("Ops deu erro");
    Console.WriteLine(ex.Message);
    Console.WriteLine(ex.InnerException);
}

static void Salvar(string texto){
    if(string.IsNullOrEmpty(texto)){
        throw new ArgumentNullException("Não pode ser nulo");
    }
}

public class MinhaException: Exception
{
    public DateTime QuandoAconteceu { get; set; }
}

