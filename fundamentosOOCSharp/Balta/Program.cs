using Balta.ContentContext;
using Balta.ContentContext.Enums;

Console.Clear();

var articles = new List<Article>();

articles.Add(new Article("Artigo sobre OOP", "orientacao-objetos-artigos"));
articles.Add(new Article("Artigo sobre C#", "csharp"));
articles.Add(new Article("Artigo sobre .NET", "dotnet"));

foreach (var article in articles)
{
    Console.WriteLine(article.Id);
    Console.WriteLine(article.Title);
    Console.WriteLine(article.Url);
}

var courses = new List<Course>();

var courseOOP = new Course("Fundamentos OOP", "fundamentos-oop");
var courseCsharp = new Course("Fundamentos C#", "fundamentos-csharp");
var courseDotNet = new Course("Fundamentos .NET", "fundamentos-dotnet");

courses.Add(courseOOP);
courses.Add(courseCsharp);
courses.Add(courseDotNet);

var careers = new List<Career>();

var careerDotNet = new Career("Especialista .nET", "especialista-dotnet");

var careerItemDotNet1 = new CareerItem(
        1, 
        "Especialista .nET", 
        "especialista-dotnet",
        null);
var careerItemDotNet2 = new CareerItem(
        2, 
        "Aprenda .NET", 
        "especialista-dotnet",
        null);
var careerItemDotNet3 = new CareerItem(
        3, 
        "OOP", 
        "especialista-dotnet",
        null);
careerDotNet.Items.Add(careerItemDotNet2);
careerDotNet.Items.Add(careerItemDotNet1);
careerDotNet.Items.Add(careerItemDotNet3);
careers.Add(careerDotNet);

foreach (var career in careers)
{
    Console.WriteLine(career.Title);
    foreach (var item in career.Items.OrderBy(x => x.Order))
    {
        Console.WriteLine($"{item.Order} - {item.Title}");
    }
}





