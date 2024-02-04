using System.Runtime.InteropServices;

public class LinqQueries
{
    private List<Book> librosCollection = new List<Book>();
    public LinqQueries()
    {
        using (StreamReader reader = new StreamReader("books.json"))
        {
            string Json = reader.ReadToEnd();
            librosCollection = System.Text.Json.JsonSerializer.Deserialize<List<Book>>(
                Json, new System.Text.Json.JsonSerializerOptions()
                {
                    PropertyNameCaseInsensitive = true
                }) ??
                Enumerable.Empty<Book>().ToList();
        }


    }

    public IEnumerable<Book> TodaLaColeccion()
    {
        return librosCollection;
    }

    public IEnumerable<Book> LibrosDespuesdel2000()
    {
        // extension Method
        //return librosCollection.Where(p => p.PublishedDate.Year > 2000);

        //Query Expression
        return from l in librosCollection where l.PublishedDate.Year > 2000 select l;
    }

    public IEnumerable<Book> LibrosConMasde250PagConPalabrasInAction()
    {
        //Extension Method
        //return librosCollection.Where(p => p.PageCount > 250 && p.Title.Contains("in Action"));

        //Query Expression
        return from l in librosCollection where l.PageCount > 250 && l.Title.Contains("in Action") select l;
    }

    public bool LibrosTodosconStatus()
    {
        return librosCollection.All(p => p.Status != string.Empty);
    }

    public IEnumerable<Book> LibrosDePython()
    {
        return librosCollection.Where(p => p.Categories.Contains("Python"));
    }
    public IEnumerable<Book> LibrosJavaPorNombreAscendente()
    {
        return librosCollection.Where(p => p.Categories.Contains("Java")).OrderBy(p => p.Title);
    }
    public IEnumerable<Book> LibrosMas450paginasDescendente()
    {
        return librosCollection.Where(p => p.PageCount > 450).OrderByDescending(p => p.PageCount);
    }
    public IEnumerable<Book> TresLibrosconFechaPubRecienteJava()
    {
        return librosCollection
        .Where(p => p.Categories.Contains("Java"))
        .OrderBy(p => p.PublishedDate)
        .TakeLast(3);
    }
    public IEnumerable<Book> TercerCuartoLibroConMas400Paginas()
    {
        return librosCollection
        .Where(p => p.PageCount > 400)
        .Take(4)
        .Skip(2);
    }
}