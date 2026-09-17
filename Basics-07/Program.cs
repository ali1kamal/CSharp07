namespace Basics_07;

internal class Program
{
    static void Main(string[] args)
    {
        //I moved this object out regions to reduce reapting in code
        Book book = new Book();
        #region answer one
        //it can be seen here because it can be accesed in book class only because it private field

        #endregion

        #region second answer
        ////it can be accessed here because it's internal so it can accessed across the same project
        //Console.WriteLine(book.copiesInStock);
        #endregion

        #region third answer
        //book.Title= "Clean Codde";
        //Console.WriteLine(book.Title);
        #endregion

        #region fourth answer
        //book.genre = Genre.Science;
        //Console.WriteLine(book.genre);
        #endregion

        #region fifth answer
        int genreFiction = (int)Genre.Fiction;
        Console.WriteLine(genreFiction);

        int genrenonFiction = (int)Genre.NonFiction;
        Console.WriteLine(genrenonFiction);

        int genreScience = (int)Genre.Science;
        Console.WriteLine(genreScience);
        #endregion

    }
}