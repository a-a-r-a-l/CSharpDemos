using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo21_AnonymousMethod
{

    delegate int ComputeHandler(int a, int b);

    class Calculator
    {
        public int Add(params int[] arr)
        {
            int result = 0;
            foreach(int i in arr)
            {
                result += i;
            }
            return result;
        }

        public int Compute(int a, int b, ComputeHandler objD)
        {
            int result = -1;

            // 1. Authentication
            // 2. Authorization
            // 3. Validation
            // 4. The Process / Activity
            // 5. Audit Log

            result = objD(a, b);

            return result;
        }

    }
}
