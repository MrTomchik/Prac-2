using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetNumber
{
    class Seth
    {
        private int chislo = 0;
        private int nomer;
        public Seth(int nomer)
        {
            this.nomer = nomer;
        }
        public bool SetNumber(int nomer)
        {
            if (nomer == chislo + 1)
            {
                chislo++;
                return true;
            }
            else { nomer = 0; return false; }
        }
    }
}
