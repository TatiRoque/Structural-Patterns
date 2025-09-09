using System;

namespace Adapter
{
    public class Program
    {
        static void Main(string[] args)
        {
            IPrinter printer = new ThermalAdapter(new OldThermalPrinter());
            printer.Print("Adapter it´s working");
        }
    }
}
