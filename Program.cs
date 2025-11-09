
Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Ingresa tu nombre: ");
string nombre = Console.ReadLine();
while (nombre !="0")
{
    
    if (string.IsNullOrWhiteSpace(nombre)) nombre = "<3";
    nombre = nombre.Replace(" ", ""); // sin espacios

    string[] colores = {
    "\u001b[38;5;196m", // rojo claro
    "\u001b[38;5;160m", // rojo
    "\u001b[38;5;124m", // rojo oscuro
    "\u001b[38;5;88m",  // más oscuro
    "\u001b[38;5;52m"   // casi negro
};

    int iLetra = 0;
    for (double y = 1.5; y > -1.5; y -= 0.1)
    {
        for (double x = -1.5; x < 1.5; x += 0.05)
        {
            double formula = x * x + y * y - 1;
            if (formula * formula * formula - x * x * y * y * y <= 0)
            {
                int capa = (int)((y + 1.5) / 0.6); // capa según la fila (más arriba = más claro)
                capa = Math.Clamp(capa, 0, colores.Length - 1);
                string color = colores[capa];
                Console.Write(color + nombre[iLetra % nombre.Length] + "\u001b[0m");
                Thread.Sleep(15);
                iLetra++;
            }
            else
            {
                Console.Write(" ");
            }
        }
        Console.WriteLine();
    }
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write("Te quiero ");
    Thread.Sleep(1500);
    foreach (char c in nombre)
    {
        Console.Write(c);
        Thread.Sleep(15);
    }
    Thread.Sleep(150);
    Console.Write(".");
    nombre = Console.ReadLine();
}

