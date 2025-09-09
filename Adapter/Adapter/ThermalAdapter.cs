using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class ThermalAdapter : IPrinter
    {
        private readonly OldThermalPrinter _legacy;
        public ThermalAdapter(OldThermalPrinter legacy)
        {
            _legacy = legacy;
        }
        public void Print(string data)
        {
            if (data.Length > 100)
            {
                data = data.Substring(0, 100); 
                Console.WriteLine("Text cut to 100 characters.");
            }
            _legacy.PrintTicket(data);
        }

    }
}
