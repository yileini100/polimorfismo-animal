// See https://aka.ms/new-console-template for more information
using polimorfismo_animal;

Console.WriteLine("POLIMORFISMO ANIMAL");
Console.WriteLine();

perro perro = new perro();
gato gato = new gato();
List<animal> animales = new List<animal> { perro, gato };

foreach (var animal in animales)
{
    Console.WriteLine(animal.HacerSonido());
}


