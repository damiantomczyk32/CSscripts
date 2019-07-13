using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HammingDistance
{
    class Check
    {
        public int Distance(string ciagA,string ciagB)
        {
            int counter = 0;
            ciagA = ciagA.Trim();
            ciagB = ciagB.Trim();
            if(ciagA.Length==ciagB.Length)
            {
                for(int i=0;i<ciagA.Length;i++)
                {
                    if (ciagA[i] != ciagB[i])
                        counter++;
                }
            }
            return counter;
        }
    }
}
