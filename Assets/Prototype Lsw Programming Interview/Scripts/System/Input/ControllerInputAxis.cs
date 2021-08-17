using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PrototypeLSWProgrammingInterview.System.Input{
    public class ControllerInputAxis : IInputAxis
    {
        public float horizontalValue{get;private set;}
        public float verticalValue{get; private set;}
        void IBaseInput.ReadInput(){
            horizontalValue = UnityEngine.Input.GetAxis("Horizontal");
            verticalValue = UnityEngine.Input.GetAxis("Vertical");
        }
    } 
}
