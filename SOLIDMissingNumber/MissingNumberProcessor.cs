using SOLIDMissingNumber.Implementations;
using SOLIDMissingNumber.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDMissingNumber
{
    public class MissingNumberProcessor(IMissingNumberService missingNumberService)
    {
        public IMissingNumberService _missingNumberService = missingNumberService;

        public int FindMissingNumber(int[] numbers)
        {
            var result  = _missingNumberService.FindMissingNumber(numbers);
            return result;
        }
    }
}
