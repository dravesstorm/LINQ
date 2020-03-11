using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LINQ_fac_fib.Classes
{
    public class University
    {
        public List<Students> group = new List<Students>();

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < group.Count; i++)
            {
                yield return group[i];
            }
        }
    }
    
}
