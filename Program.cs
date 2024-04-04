

using System.Timers;

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
//ImprimirValores(queries.TercerCuartoLibroConMas400Paginas());


//Cantidad de libros que tienen entre 200 y 500 páginas con COUNT:
//Console.WriteLine($"Cantidad de libros entre 200 y 500 páginas: {queries.cuentaLibrosMasDe200Paginas()}");

//La mínima Fecha de Publicación de la lista de libros:
//Console.WriteLine($"La fecha de publicación mínima es: {queries.minimaFachaPublicacionDeLibros()}");

//Mostrar el conteo del número mayor de páginas de la lista de libros existentes:
//Console.WriteLine($"El libro con mayor número de páginas, tiene en total {queries.cantidadLibrosConMayorNumeroPaginas()} páginas");

//Libro con menor numero de paginas y que sea mayor a cero.
//var libroMenorPag = queries.libroConMenorCantidadDePaginasMenorCero();
//Console.WriteLine($"El libro con menor cantidad de páginas es: {libroMenorPag.Title} - {libroMenorPag.PageCount}");

//Libro con fecha de publicación más reciente
//var libroFechaReciente = queries.libroConFechaMasReciente();
//Console.WriteLine($"El libro más reciente es: {libroFechaReciente.Title} y la fecha es: {libroFechaReciente.PublishedDate.ToShortDateString()} ");

//Suma de páginas de todos los libros con páginas entre 
//Console.WriteLine($"La suma de todas las páginas de los libros entre 0 a 500 páginas es: { queries.sumaCantidadPaginasLibrosEntre0y500()} páginas en total");

//Libros publicados después del 2015
//Console.WriteLine($"Estos son los libros {queries.librosconFechaPublicacionPosterior2015()}");

//Promedio de caracteres de la lista de libros
//Console.WriteLine($"Promedio de caracteres de la lista de libros:{queries.promedioCaracteresTitulo()}");

//Grupos de libros que son mayores al año 2000.
ImprimirGrupo(queries.librosDespuesdel2000AgrupadosPorAnio());

void ImprimirValores(IEnumerable<Book> listaDeLibros)
{
    System.Console.WriteLine("{0, -60} {1,9} {2,11}\n", "Title", "N. Paginas", "Fecha publicacion");
    foreach (var item in listaDeLibros)
    {
        System.Console.WriteLine("{0, -60} {1,9} {2,11}\n", item.Title, item.PageCount, item.PublishedDate.ToShortDateString());
    }

}

void ImprimirGrupo(IEnumerable<IGrouping<int,Book>> ListadeLibros)
{
    foreach (var grupo in ListadeLibros)
    {
        Console.WriteLine("");
        System.Console.WriteLine($"Grupo: { grupo.Key }");
        System.Console.WriteLine("{0, -60} {1,9} {2,11}\n", "Title", "N. Paginas", "Fecha publicacion");

        foreach(var item in grupo){
            System.Console.WriteLine("{0, -60} {1,9} {2,11}\n", item.Title, item.PageCount, item.PublishedDate.ToShortDateString());
        }
        
    }

}