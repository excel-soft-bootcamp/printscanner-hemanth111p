using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace printscan
{
   public class PrintAndScan
    {
        IPrint _print;
        IScan _scan;
        public PrintAndScan(IPrint print)
        {
            this._print = print;
            
        }
        
        public PrintAndScan(IScan scan)
        {
            this._scan = scan;
        }
        
        public PrintAndScan(IPrint print,IScan scan)
        {
            this._print = print;
            this._scan = scan;
        }
        public void PrintScan()
        {
            _print.Print();
            _scan.Scan();
        } 
        public void PrintOnly()
        {
            _print.Print();
        }
        public void ScanOnly()
        {
            _scan.Scan();
        }


    }
}
