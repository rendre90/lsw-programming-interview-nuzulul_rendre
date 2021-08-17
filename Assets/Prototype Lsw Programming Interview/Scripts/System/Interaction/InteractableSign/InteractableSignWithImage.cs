using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PrototypeLSWProgrammingInterview.System.Interaction.InteractableSign{
    public class InteractableSignWithImage : IInteractableSign
    {
        GameObject signObj;
        public InteractableSignWithImage(GameObject signObj){
            this.signObj = signObj;
            DisableSign();
        }
        void IInteractableSign.EnableSign(){
            signObj.SetActive(true);
        }

        public void DisableSign(){
            signObj.SetActive(false);
        }
    }
}
