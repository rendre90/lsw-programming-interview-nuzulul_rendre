using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PrototypeLSWProgrammingInterview.System.Input{
    public class ControllerInputInteracting : IInputKeyPress
    {
        public  bool isKeyDown{get; private set;}
        public bool isKeyUp{get; private set;}
        void IBaseInput.ReadInput(){
            isKeyUp = false;
            isKeyDown = false;
            if(UnityEngine.Input.GetKeyDown(KeyCode.E)){
                isKeyDown = true;
            }
            if(UnityEngine.Input.GetKeyUp(KeyCode.E)){
                isKeyUp = true;
            }
        }
    }
}
