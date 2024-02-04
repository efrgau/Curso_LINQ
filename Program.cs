

LinqQueries queries = new LinqQueries();

//Toda la colección de los libros.
//ImprimirValores(queries.TodaLaColeccion());

//Libros despues del 2000
//ImprimirValores(queries.LibrosDespuesdel2000());

//Libros con mas de 250 páginas y tiene titulo la palabra "In Action"

//ImprimirValores(queries.LibrosConMasde250PagConPalabrasInAction());
//System.Console.WriteLine($"Todos los libros tienen el estatus: {queries.LibrosTodosconStatus()}");

//Imprimir los libros que contengan la categoría "PYTHON"
//ImprimirValores(queries.LibrosDePython());

//Imprimir los libros de categoria JAVA y ordenados por nombre
//ImprimirValores(queries.LibrosJavaPorNombreAscendente());

//Imprimir los libros con más de 450 páginas y ordenados por números de páginas en forma descendente
//ImprimirValores(queries.LibrosMas450paginasDescendente());

//Imprimir los tres primeros libros ordenados por Nombres que tenga JAVA y con fecha publicacion reciente
//ImprimirValores(queries.TresLibrosconFechaPubRecienteJava());

//Imprimir libros con más de 400 páginas
ImprimirValores(queries.TercerCuartoLibroConMas400Paginas());

void ImprimirValores(IEnumerable<Book> listaDeLibros)
{
    System.Console.WriteLine("{0, -60} {1,9} {2,11}\n", "Title", "N. Paginas", "Fecha publicacion");
    foreach (var item in listaDeLibros)
    {
        System.Console.WriteLine("{0, -60} {1,9} {2,11}\n", item.Title, item.PageCount, item.PublishedDate.ToShortDateString());
    }

}