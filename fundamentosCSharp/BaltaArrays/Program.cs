Console.Clear();


 var arr = new int[5]{1 ,2 ,3 ,4 ,5};

arr[0] = 12;

Console.WriteLine(arr.Length);


foreach (var item in arr){
    Console.WriteLine(item);
}

var funcionarios = new Funcionario[5];

funcionarios[0] = new Funcionario() { Id = 12013, Nome = "Fritas"};

foreach (var funcionario in funcionarios){
    Console.WriteLine(funcionario.Id);
    Console.WriteLine(funcionario.Nome);
}

for (int i = 0; i < arr.Length; i++)
{
    Console.WriteLine(arr[i]);
}

struct Funcionario
{
    public int Id { get; set; }
    public string Nome { get; set; }
}

// var arr = new Test[1];

// arr[0] = new Test(){
//     Id = 1
// };

// Console.WriteLine(arr[0]);
// // Console.WriteLine(arr[1]);
// // Console.WriteLine(arr[2]);
// // Console.WriteLine(arr[3]);
// // Console.WriteLine(arr[4]);

// struct Test
// {
//     public int Id { get; set; }
// }

