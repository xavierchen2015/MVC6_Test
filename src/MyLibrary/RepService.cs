using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyLibrary
{
    public class RepService : IRepService
    {
        private int i=0;
        public int GetCounter()
        {
            return i++;
        }
    }
}
