// See https://aka.ms/new-console-template for more information
using Balta.ContentContext;

var articles = new List<Article>();
articles.Add(new Article("Artigo sobre OOP", "orientacao-objetos"));
articles.Add(new Article("Artigo sobre C#", "csharp"));
articles.Add(new Article("Artigo sobre .Net", "dotnet"));


foreach (var article in articles)
{
    Console.WriteLine(article.Id);
    Console.WriteLine(article.Title);
    Console.WriteLine(article.Url);

}
var courses = new List<Course>();
var course = new Course("Fundamentos OOP", "fundamentos-oop");
var courseCsharp = new Course("Fundamentos c#", "fundamentos-csharp");
var courseAspNet = new Course("Fundamentos ASP.NET", "fundamentos-aspnet");
courses.Add(course);
courses.Add(courseCsharp);
courses.Add(courseAspNet);

var careers = new List<Career>();
var careerDotNet = new Career("Especialista .NET", "Especialista-dotnet");
var careerItem2 = new CareerItem(2, "Aprenda OOP", "", null);
var careerItem = new CareerItem(1, "Comece por aqui", "", null);
var careerItem3 = new CareerItem(3, "Aprenda .NET", "", null);
careerDotNet.Items.Add(careerItem2);
careerDotNet.Items.Add(careerItem);
careerDotNet.Items.Add(careerItem3);
careers.Add(careerDotNet);

foreach (var career in careers)
{
    Console.WriteLine(career.Title);
    foreach (var item in career.Items.OrderBy(x => x.Order))
    {
        Console.WriteLine($"{item.Order} - {item.Title}");
    }
}