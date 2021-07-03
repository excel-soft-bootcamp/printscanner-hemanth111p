using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace printscan
{
    class PrintScanner:IScan,IPrint
    {
        IPrint _printerRef;
        IScan _scannerRef;

        public void SetPrinter(IPrint printerRef)
        {
            this._printerRef = printerRef;
        }
        public void SetScanner(IScan scanRef)
        {

            this._scannerRef = scanRef;
        }
        public void Print()
        {
            //Delegate Call To Either NanoLaserPrinter or Printer
            this._printerRef.Print();
        }
        public void Scan()
        {
            //Delegate Call To Scanner
            this._scannerRef.Scan();
        }

    }

}

