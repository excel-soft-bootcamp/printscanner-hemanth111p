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
            Printer _print = new Printer();
            _print.Print();
            Scanner _Scan = new Scanner();
            _Scan.Scan(); 

            PrintManager printing = new PrintManager();
            printing.PrintDocument(_print);
            ScanManager scanning = new ScanManager();
            scanning.ScanDocument(_Scan);

            PrintAndScan PrintScan1 = new PrintAndScan(new PrintManager());
            PrintScan1.PrintOnly();

            PrintAndScan PrintScan2 = new PrintAndScan(new ScanManager());
            PrintScan2.ScanOnly();

            PrintAndScan PrintScan = new PrintAndScan(new PrintManager(), new ScanManager());
            PrintScan.PrintScan();
            



        }
    }
}
