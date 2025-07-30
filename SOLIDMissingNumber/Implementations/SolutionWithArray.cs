using SOLIDMissingNumber.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDMissingNumber.Implementations;

public class SolutionWithArray : IMissingNumberService
{
    public int FindMissingNumber(int[] numbers)
    {
        int min = numbers.Min();
        int max = numbers.Max();

        int[] expectedRange = [.. Enumerable.Range(min, max)];

        int missingNumber = expectedRange.Except(numbers).First();

        return missingNumber;
        
    }
}
