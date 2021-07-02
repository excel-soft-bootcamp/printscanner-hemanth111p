using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace printscan
{
    class PrintScanner:IScan,IPrint
    {
        
                public void Print()
        {
            //Delegate Call To Either NanoLaserPrinter or Printer
            
        }
        public void Scan()
        {
            //Delegate Call To Scanner
        }

    }

}

