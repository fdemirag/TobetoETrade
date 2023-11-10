



using Business.Concretes;
using Entities.Concretes;

internal class Program
{
    private static void Main(string[] args)
    {
        Category category = new Category();
        category.Id = 1;
        category.Name = "Fatih";

        CategoryManager categoryManager = new CategoryManager();

        categoryManager.Add(category);
        Console.WriteLine(category.Id+category.Name);
        Console.Read();
    }
}