namespace Basics_07;

internal class Program
{
    static void Main(string[] args)
    {
        #region answer one
        //it can be seen here because it can be accesed in book class only because it private field
        //Book book = new Book();

        #endregion

        #region second answer
        Book book = new Book();
        //it can be accessed here because it's internal so it can accessed across the same project
        Console.WriteLine(book.copiesInStock);
        #endregion
    }
}