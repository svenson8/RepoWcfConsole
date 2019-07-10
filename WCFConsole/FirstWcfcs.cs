using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class FirstWcfcs : IMyWcf
{
    public string Hello()
    {
        return "First work";
    }

    public int AddNumbers(int a, int b)
    {
        return a + b;
    }
}

