using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace PrototypeLSWProgrammingInterview.System.Input{
    public interface IInputKeyPress : IBaseInput
    {
        bool isKeyDown{get;}
        bool isKeyUp{get;}
    }
}
