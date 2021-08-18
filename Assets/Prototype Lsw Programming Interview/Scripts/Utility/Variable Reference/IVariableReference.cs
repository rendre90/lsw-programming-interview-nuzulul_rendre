using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
namespace PrototypeLSWProgrammingInterview.Utility.VariableReference
{
    public interface IVariableReference
    {
        event Action OnUpdateVariable;

        string ConvertToString();
    }
}

