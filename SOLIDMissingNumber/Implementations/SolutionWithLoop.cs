using SOLIDMissingNumber.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDMissingNumber.Implementations;

public class SolutionWithLoop : IMissingNumberService
{
    public int FindMissingNumber(int[] numbers)
    {        

        int min = numbers.Min();
        int max = numbers.Max();

        for (int i = min; i <= max; i++)
        {

            if (!numbers.Contains(i))
                return i;

        }

        return -1;
    }
}
