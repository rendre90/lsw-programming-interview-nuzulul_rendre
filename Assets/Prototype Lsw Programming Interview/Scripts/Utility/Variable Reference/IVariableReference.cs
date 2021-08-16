using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PrototypeLSWProgrammingInterview.Utility.VariableReference
{
    public interface IVariableReference<T>
    {
        T Value{get;}
        void DecreaseValue(T otherValue);
        void IncreaseValue(T otherValue);
    }
}

