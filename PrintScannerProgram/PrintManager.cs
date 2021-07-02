using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace printscan
{
    
        public class PrintManager
        {
        public void PrintDocument(IPrint printer)
        {
            printer.Print();
        }
    }
       
}
