#region Declaraciones
string cadena = "Xiuhtlaltzin permaneció mirando la espuma de su olla de chocolate.";
ConsoleKey opcion;
#endregion

#region Ejecucion
Console.Clear(); //Limpiamos la pantalla al iniciar
Console.WriteLine("\"" + cadena + "\"");
imprimirOpciones();

do
{
    Console.Write("Opcion: ");
    opcion = Console.ReadKey().Key;
    Console.WriteLine();
    imprimir(opcion);
} while (opcion != ConsoleKey.Escape);
#endregion

#region Funciones
void imprimir(ConsoleKey opcion)
{
    string resultado = "";
    switch (opcion)
    {
        case ConsoleKey.U:
            resultado = cadena.ToUpper();
            break;
        case ConsoleKey.L:
            resultado = cadena.ToLower();
            break;
        case ConsoleKey.I:
            resultado = cadena.Insert(24, "sentada, ");
            break;
        case ConsoleKey.M:
            resultado = cadena.Remove(35, 13);
            break;
        case ConsoleKey.R:
            resultado = cadena.Replace("Xiuhtlaltzin", "Ella");
            break;
        case ConsoleKey.S:
            resultado = cadena.Substring(32);
            break;
        default:
            return; //Salgo del método, ignorando las siguientes instrucciones
    }
    Console.ForegroundColor = ConsoleColor.DarkMagenta;
    Console.WriteLine(resultado);
    Console.ResetColor();
}


void imprimirOpciones()
{
    string[] opciones = { "To&Upper", "To&Lower", "&Insert", "Re&move", "&Replace", "&Substring" };

    Console.Write("| ");
    foreach (string opcion in opciones)
    {
        bool resaltar = false;
        foreach (char caracter in opcion)
        {
            if (caracter == '&')
            {
                resaltar = true;
                continue;
            }

            if (resaltar)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                resaltar = false;
            }
            Console.Write(caracter);
            Console.ResetColor();
        }
        Console.Write(" | ");
    }
    Console.WriteLine();
}
#endregion