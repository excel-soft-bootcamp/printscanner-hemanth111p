﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace printscan
{
    
        public class PrintManager:Printer
        {
        public void PrintDocument(Printer printer)
        {
            printer.Print();
        }
    }
       
}
