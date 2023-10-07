//Ejercicio2

DateTime FechaActual = DateTime.Now;

DateTime FechaNavidad = new DateTime(FechaActual.Year, 12, 25);
DateTime FechaAñoNuevo = new DateTime(FechaActual.Year + 1, 1, 1);
int DiasNavidad = (FechaNavidad - FechaActual).Days;
int DiasAñoNuevo = (FechaAñoNuevo - FechaActual).Days;

Console.WriteLine($"Día actual: {FechaActual.Day}");
Console.WriteLine($"Mes actual: {FechaActual.Month}");
Console.WriteLine($"Año actual: {FechaActual.Year}");
Console.WriteLine($"Días faltantes para Navidad: {DiasNavidad}");
Console.WriteLine($"Días faltantes para Año Nuevo: {DiasAñoNuevo}");