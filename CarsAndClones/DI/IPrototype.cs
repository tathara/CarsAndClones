using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsAndClones.DI
{
    public interface IPrototype
    {
        ICar Clone();
    }
}
