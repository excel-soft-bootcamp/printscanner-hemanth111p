using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace printscan
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
           
            PrintAndScan PrintScan = new PrintAndScan(new Printer(),new Scanner());
            PrintScanInterface PrinterScanner = new PrintScanInterface(PrintScan);
            PrinterScanner.PrinterScanner();




        }
    }
}
