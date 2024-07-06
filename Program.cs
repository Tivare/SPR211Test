using MyProject.Models;

namespace MyProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
           var book = new Book() { Id = 1, Name = "Harry Potter", Authtor="J.K.Rowling", Price = 1000};
            Console.WriteLine(book);

        }
    }
}
