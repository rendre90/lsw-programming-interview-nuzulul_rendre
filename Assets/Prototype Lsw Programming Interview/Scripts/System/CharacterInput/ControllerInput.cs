using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PrototypeLSWProgrammingInterview.System.CharacterInput{
    public class ControllerInput : ICharacterInput
    {
        public float horizontalValue{get;private set;}
        public float verticalValue{get; private set;}
        void ICharacterInput.ReadInput(){
            horizontalValue = Input.GetAxis("Horizontal");
            verticalValue = Input.GetAxis("Vertical");
        }
    } 
}
