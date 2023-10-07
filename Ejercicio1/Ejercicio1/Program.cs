//Ejercicio 1

Console.WriteLine(@"Bienvenido a su calculadora de distancia entre dos puntos

A continuacion necesito que ingrese P(x, y) y Q(h,k)");

Console.Write("Ingrese el valor de x: ");
double x = Convert.ToDouble(Console.ReadLine());

Console.Write("Ingrese el valor de y: ");
double y = Convert.ToDouble(Console.ReadLine());

Console.Write("Ingrese el valor de h: ");
double h = Convert.ToDouble(Console.ReadLine());

Console.Write("Ingrese el valor de k: ");
double k = Convert.ToDouble(Console.ReadLine());

double r = Math.Sqrt(Math.Pow(x - h, 2) + Math.Pow(y - k,2));

Console.WriteLine($"La distancia de los puntos P({x}, {y}) y Q({h}, {k}) es: {r}");