using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDMissingNumber.Interfaces;

public interface IMissingNumberService
{
    public int FindMissingNumber(int[] numbers);
}
