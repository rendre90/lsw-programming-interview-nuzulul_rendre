using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
namespace PrototypeLSWProgrammingInterview.Utility.VariableReference
{
    public abstract class BaseVariableReference : ScriptableObject, IVariableReference
    {
        public virtual event Action OnUpdateVariable;
        string IVariableReference.ConvertToString(){
            return ToString();
        }
        public abstract void ForceRefresh();
    }
}
