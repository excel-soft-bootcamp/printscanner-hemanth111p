using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace printscan
{
    class PrintScanInterface
    {
        IPrintScan _PrintScan;
        public PrintScanInterface(IPrintScan PrintScan)
        {
            this._PrintScan = PrintScan;
        }
        public void PrinterScanner()
        {
            _PrintScan.PrintScan();
        }
    }
}
