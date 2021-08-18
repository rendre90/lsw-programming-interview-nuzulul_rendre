using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PrototypeLSWProgrammingInterview.Utility.VariableReference.ReferenceUtility{
    public interface IReferenceLerpValue<T> 
    {
        T lerpValue{set;get;}
    }
}
