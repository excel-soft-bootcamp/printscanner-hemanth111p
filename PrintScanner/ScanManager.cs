using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace printscan
{
    
        public class ScanManager:Scanner
        {
        public void ScanDocument(Scanner scaner)
        {
            scaner.Scan();
        }
    }

    
}
