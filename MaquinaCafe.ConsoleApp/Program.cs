using MaquinaCafe.Domain.Enums;
using MaquinaCafe.Domain.Entities;
using System.Drawing;

Cafetera cafetera = new Cafetera(50);
Vaso vasosPequenos = new Vaso(5, 3);
Vaso vasosMedianos = new Vaso(5, 5);
Vaso vasosGrandes = new Vaso(5, 7);
Azucarero azucarero = new Azucarero(20);

MaquinaDeCafe maquinaCafe = new MaquinaDeCafe(
                                   cafetera,
                                   vasosPequenos,
                                   vasosMedianos,
                                   vasosGrandes,
                                   azucarero);

bool continuar = true;

while (continuar)
{
    int opcionTipoVaso = 0;
    string tipoVaso = string.Empty;
    string mensajeErrorTipoVaso = "Opción no válida. Intente de nuevo.";
    int cantidadVasos = 0;
    int cantidadAzucar = 0;

    Console.Clear(); 
    Console.WriteLine("          /                                                      / " +
        "\r\n          _,   _,        o        _,      _|   _     _   _,  |\\  _ " +
        "\r\n /|/|/|  / |  / |  |  |  | /|/|  / |     / |  |/    /   / |  |/ |/ " +
        "\r\n  | | |_/\\/|_/\\/|_/ \\/|_/|/ | |_/\\/|_/   \\/|_/|_/   \\__/\\/|_/|_/|_/" +
        "\r\n                |)                                           |)    ");

    Console.WriteLine("\n");

    Console.WriteLine("░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░" +
        "\r\n░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░▒▒░░░░░░░░░░░░░░░░░░░░░░" +
        "\r\n░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░▓░░▓▓░░░░░░░░░░░░░░░░░░░░░" +
        "\r\n░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░▓░░▓▓▓░░░░░░░░░░░░░░░░░░░░" +
        "\r\n░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░▒▓░░░░░▓▓▓▓░░░░░░░░░░░░░░░░░░░░" +
        "\r\n░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░▒▓▓░░▒▓▓▓▓░░▓▒░░░░░░░░░░░░░░░░░" +
        "\r\n░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░▓▓█▒▓█▓▓▓▓░░░▓▓▒░░░░░░░░░░░░░░░░" +
        "\r\n░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░▒██▓░▓█▓▓▓▒░░▒▓▓▓░░░░░░░░░░░░░░░░░" +
        "\r\n░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░▒█▓░░████░░░▓██▒░░░░░░░░░░░░░░░░░░" +
        "\r\n░░░░░░░░░░░░░░░▒░░░░░░░░░░░░░░░░░░░░░░░░░░▓▓░░▓██▓░░▓█▓░░░░░░░░░░░░░░░░░░░░" +
        "\r\n░░░░░░░░░░░░░░░█▓░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░▓██░░▒█▒░░░░░░░░░░░░░░░░░░░░" +
        "\r\n░░░░░░░░░░░░░░▒▓▓█▓░░░░░░░░░░░░░░░░░░░░░░░░░░░░░▒█▓░░░▒░░░░░░░░░░░░░░░░░░░░" +
        "\r\n░░░░░░░░░░░░░░▓▒▓▓▓▓▓▒░░░░░░░░░░░░░░░░░▒▒▒▓▓▓▓▓▓▓██▓▓▓▓▓▓▓▒▒░░░░░░░░░░░░░░░" +
        "\r\n░░░░░░░░░░░░░░▓▒▒▓▓▓▓▓█▓░░░░░░░░░░░▒▓▓▓▒▒▒▒▒▒▒▒▓▓██▓▓▓▓▓▓▓▓▓▓▓▓▓▒░░░░░░░░░░" +
        "\r\n░░░░░░░░░░░░░░█▒▒▓▓█▓▓▓▓█▒░░░░░░░░░█▓▓▓▓▓▒░░▒▓▓▓█▓▓▓▓▓████████▓██▓▓▓▓▓▓░░░░" +
        "\r\n░░░░░░░░░░░░░░▓▒▒▒▓▓█▓█▓▓█░░░░░░░░░█▒▓▓████▓▓▓▓▓▓▓▓▓▓█████████▓▓█▓▓▓▓▓▓█▒░░" +
        "\r\n░░░░░░░░░░░░░░▒█▒▓▓▒▓██▓▓█▒░░░░░░░░█▒░░░░░▒▒▒▒▒▓▓▓▓▓▓▒▒▒▓▒▒▒▒▒▒▓█▓▒░░▒█▒█▒░" +
        "\r\n░░░░░▒▒▓▓▓▓▓▒▒▒▓▓▒▓▓▓▓████▓▒▒▓▓▓░░░▓▓░░░░░░░░░░░░░░░░░░▒▒▒▒▒▒▓▒█▓░░░░▓█▓█░░" +
        "\r\n░▒▓▓▓▓▓▓▓▓▒▒▒▓▓▓█▓▒▒▒▒▓███▓▓▓████░░▒█▒░░░░░░░░░░░░░░░░▒▒▒▒▒▒▒▓▓█▒░▒▒█▓▓█▒░░" +
        "\r\n░░▒▓█▓▓▓▓▓█▓▓▓▓▒▒▓▓▓▓▓▓██▓▓▓█████░░░▒█▒░░░░░░░░░░░░░▒▒▒▒▒▒▒▒▒▓█▓▓▓▓▓▓▓▒░░░░" +
        "\r\n░░░░░▓███▓▓▓▓██▓▓▒▓█▓▓▓████▓█▓██▒░░░░▒▓▒░░░░░░░░░░▒▒▒▒▒▒▒▒▒▒▓█▓▓▓▒▒▒░░░░░░░" +
        "\r\n░░░░░░░▒█████▓▓▓▓█▓▓▓██████████▓░░░░░▒▓█▒░░░░░░░▒▒▒▒▒▒▒▒▒▒▒▓█▓▒░░░░░░░░░░░░" +
        "\r\n░░░░░░░░░░▓▓▓▓▓▓▓██▓▓▓▓▓████▓▓▓▓▓▓▓▓▓▓▒▒▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓█▓▓▓▓▓▓▓▓▓▓▓▒▒░░░" +
        "\r\n░░░░░░░░▒▓▓████████▓▓██████▓░░░░░░▒▒▒▒▒▒░▒▓█▓▓▓▓▓▓▓▓▓▓▓██▓▒▒▒▒▒▒▒▒▒░░░░▒█▒░" +
        "\r\n░░░░░░░░▓█████████▓████████▓▓▓▓▓▒▒▒░░░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░▒▒▒▓▓▓▒▒░░" +
        "\r\n░░░░░░░░░▒▓▓██▓▓▒░▒█████▓████████▓▓▒▒▓██▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓███▒▒▒▒░░░░░░░░░" +
        "\r\n░░░░░░░░░░░░░░░░░░░░░░░░░▓█████████░░░░▒▒▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒░░░░░░░░░░░░░░░" +
        "\r\n░░░░░░░░░░░░░░░░░░░░░░░░░░░▒▓████▓▒░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░" +
        "\r\n░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░\r\n");
    

    // Selecciona la cantidad de vasos
    Console.Write("\nCantidad de vasos que desea: ");
    cantidadVasos = int.TryParse(Console.ReadLine(), out cantidadVasos) ? cantidadVasos : 0;

    // Selecciona la cantidad de azúcar
    Console.Write("Cantidad de azúcar que desea: ");
    cantidadAzucar = int.TryParse(Console.ReadLine(), out cantidadAzucar) ? cantidadAzucar : 0;

    // Selecciona el tipo de vaso
    Console.WriteLine("\nSelecciona el tipo de vaso: ");
    Console.WriteLine("1. Vaso pequeño");
    Console.WriteLine("2. Vaso mediano");
    Console.WriteLine("3. Vaso grande");
    Console.Write("\nOpción: ");

    opcionTipoVaso = int.TryParse(Console.ReadLine(), out opcionTipoVaso) ? opcionTipoVaso : 0;

    tipoVaso = opcionTipoVaso switch
    {
        (int)TipoVasos.Pequeno => TipoVasos.Pequeno.ToString(),
        (int)TipoVasos.Mediano => TipoVasos.Mediano.ToString(),
        (int)TipoVasos.Grande => TipoVasos.Grande.ToString(),
        _ => mensajeErrorTipoVaso,
    };

    if (tipoVaso.Equals(mensajeErrorTipoVaso))
    {
        Console.WriteLine("\n" + mensajeErrorTipoVaso);
        Console.WriteLine("Presione cualquier tecla para intentarlo nuevamente...");
        Console.ReadKey();
        continue; 
    }

    Vaso vaso = maquinaCafe.GetTipoVaso(tipoVaso);

    // Da n vasos con n cantidad de café y n cantidad de azúcar
    string vasoCafe = maquinaCafe.GetVasoDeCafe(vaso, cantidadVasos, cantidadAzucar);

    Console.WriteLine($"\n{vasoCafe}");

    // Pregunta si desea continuar o salir
    Console.Write("\n¿Desea otro vaso de café? (s/n): ");
    string respuesta = Console.ReadLine();
    continuar = respuesta?.ToLower() == "s";
}

Console.WriteLine("Gracias por usar la Máquina de Café.");


