using System;
using System.Collections.Generic;
using System.Text;

namespace DockerJenkinsTest
{
    public class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Add(double a, int b)
        {
            return (int)a + b;
        }

        public int Add(int a, double b)
        {
            return a + (int)b;
        }

        public int Add(double a, double b)
        {
            var result = a + b;
            return (int)result;
        }
    }
}
