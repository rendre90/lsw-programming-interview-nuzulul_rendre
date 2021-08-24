using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PrototypeLSWProgrammingInterview.System.Input{
    public class ControllerInputOneAxis : IInputAxis
    {
        public float horizontalValue{get;private set;}
        public float verticalValue{get; private set;}
        bool isLastHorizontal = false;
        void IBaseInput.ReadInput(){
            if(UnityEngine.Input.GetButtonDown("Horizontal")){
                isLastHorizontal = true;
            }

            if(UnityEngine.Input.GetButtonDown("Vertical")){
                isLastHorizontal = false;
            }
            
            horizontalValue = UnityEngine.Input.GetAxis("Horizontal");
            verticalValue = UnityEngine.Input.GetAxis("Vertical");
            if(horizontalValue != 0 && verticalValue != 0){
                if(isLastHorizontal) verticalValue = 0;
                else horizontalValue = 0;
            }
        }
    } 
}
