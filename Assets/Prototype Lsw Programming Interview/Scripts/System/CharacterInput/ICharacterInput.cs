using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PrototypeLSWProgrammingInterview.System.CharacterInput{
    public interface ICharacterInput
    {
        void ReadInput();
        float horizontalValue{get;}
        float verticalValue{get;}
    }
}
