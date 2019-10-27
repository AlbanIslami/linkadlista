using System;

namespace ConsoleApp2
{
   class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Add First:");
        LinkedList minlista = new LinkedList();

        minlista.AddFirst("1");
        minlista.AddFirst("2");
        minlista.AddFirst("3");
        minlista.printAllNodes();

        Console.WriteLine();
    }
       

 }
}
