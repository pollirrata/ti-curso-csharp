#region Inicializacion
Console.Clear();
Random genCodigoPostal = new Random();
DateTime hoy = DateTime.Now;

IRandomizerString randomizerFirstName = RandomizerFactory.GetRandomizer(new FieldOptionsFirstName());
IRandomizerString genApellido = RandomizerFactory.GetRandomizer(new FieldOptionsLastName());

FieldOptionsDateTime opcionesFecha = new FieldOptionsDateTime();
opcionesFecha.From = new DateTime(1955, 11, 5, 6, 15, 0);
opcionesFecha.To = new DateTime(1985, 10, 26, 1, 35, 0);
IRandomizerDateTime genFecha = RandomizerFactory.GetRandomizer(opcionesFecha);

#endregion

for (int i = 0; i < 10; i++)
{
    string id = Guid.NewGuid().ToString();
    Console.WriteLine(id);

    string nombre = randomizerFirstName.Generate() ?? "";
    string apellido = genApellido.Generate() ?? "";

    int cp = genCodigoPostal.Next(20000,20997);
    
    Console.WriteLine($"{nombre} {apellido} ({cp})");
    
    DateTime fecha = genFecha.Generate().Value;
    TimeSpan edad = hoy - fecha;

    Console.WriteLine($"{fecha}\t{edad.TotalDays / 365.2425}");

    Console.WriteLine();
}