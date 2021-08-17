using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PrototypeLSWProgrammingInterview.System.Input{
    public interface IInputAxis : IBaseInput
    {
        float horizontalValue{get;}
        float verticalValue{get;}
    }
}
