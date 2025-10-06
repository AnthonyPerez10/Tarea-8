// See https://aka.ms/new-console-template for more information
//Videos del 1 al 16 curso de Platzy Tema Linq
//ID: 11

//Video #8
LinqQueries queries = new LinqQueries();

ImprimirValores(queries.Todalacoleccion());
Console.WriteLine("\n");

//Libros despues del 2000
ImprimirValores(queries.Librosdespues2000()); 
Console.WriteLine("\n");

//Libros con mas de 250 paginas y contiene la palabra in Action
ImprimirValores(queries.librosConMas250pagConPalabraInAction()); 
Console.WriteLine("\n");

//Todos lo libros tiene status
Console.WriteLine($"Todos los libros tiene status: {queries.TodosLoLibroTieneStatus()}");
Console.WriteLine("\n");

//Algun libro fue publicado el 2005
Console.WriteLine($"Algun libro publicado en el 2005: {queries.TodosLibrospublicados2005()}");
Console.WriteLine("\n");

//Video 12: Uso de contains devolvemos los libros que contenga Phyton
//Libros de phyton
ImprimirValores(queries.LibrosDePhyton()); 
Console.WriteLine("\n");

//Libros de Java: Video N13. 
ImprimirValores(queries.LibrosJavaPorNombreAscendete());
Console.WriteLine("\n");

//Video Numero 13: OrdenByDescending
//Libros ordenados por cantidad de paginas
ImprimirValores(queries.Libros450pagians());
Console.WriteLine("\n");

//Video 14: Tres primeros 3 libros de Java publicados recietemente
ImprimirValores(queries.TresPrimerosLibrosOrdenadosPorFecha());
Console.WriteLine("\n");

//Video 15: Tercer y cuarto libro con mas de 450 paginas
ImprimirValores(queries.PrimerosCuatrosLibrosConSkip());

void ImprimirValores(IEnumerable<Book> lisdelibros)
{
    Console.WriteLine("{0,-60}, {1,15}, {2,15}\n", "Titulo", "N. Paginas", "Fecha de publicacion");
    foreach (var item in lisdelibros)
    {
        Console.WriteLine("{0,-60}, {1,15},{2,15}", item.Title, item.PageCount, item.PublishedDate.ToShortDateString());
    }
}

