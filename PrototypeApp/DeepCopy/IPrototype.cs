using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypeApp.DeepCopy
{
    public interface IPrototype<T>
    {
        T DeepCopy();
    }
}
