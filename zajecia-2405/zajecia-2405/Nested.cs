using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zajecia_2405
{
    internal class Nested
    {
        public class Calculate
        {
            public void squareRoot(float number)
            {
                float y = 0.0000001f;

                float result = number / 2;

                while (Math.Abs(result - (number / result)) > y)
                {
                    result = (result + (number / result)) / 2;

                    if (result * result == 2)
                    {
                        Console.WriteLine(result);
                    }
                }

                Console.WriteLine(result);
            }
        }
    }
}
