using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class FirstWcfcs : IMyWcf
{
    public string Hello()
    {
        return "First worko";
    }

    public int AddNumbers(int a, int b)
    {
        return a + b;
    }

    public CustomerWcf GetCustomerById(int id)
    {
        CustomerWcf c = new CustomerWcf();
        c.FirstName = "Seba";
        c.ID = 5;
        c.LastName = "Kumo";
        return c;
    }

    public decimal GetValue(decimal gross)
    {
        return gross * 0.0976M;
    }

    public List<decimal> GetValues(List<decimal> grossValues)
    {
        List<decimal> returnValues = new List<decimal>();
        foreach (var value in grossValues)
            returnValues.Add(value * 0.0976M);
        return returnValues;
    }
}

