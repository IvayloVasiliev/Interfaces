using System;
using System.Collections.Generic;
using System.Text;

namespace Ferrari
{
    public interface ICar
    {
        string Model { get;  }

        string DriversName { get; }

        string PushBrakes();

        string PushGas();

    }
}
