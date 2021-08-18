using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PrototypeLSWProgrammingInterview.Utility.VariableReference.ReferenceUtility{
    public interface IReferenceUtility<T>
    {
        void DecreaseValue(T otherValue);
        void IncreaseValue(T otherValue);
    }
}
