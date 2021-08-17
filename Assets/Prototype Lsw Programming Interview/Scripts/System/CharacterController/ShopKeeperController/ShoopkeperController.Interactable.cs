using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PrototypeLSWProgrammingInterview.System.Interaction;
using PrototypeLSWProgrammingInterview.System.Interaction.InteractableSign;

namespace PrototypeLSWProgrammingInterview.System.CharacterController.ShopKeeperController{
    public partial class ShoopkeperController : BaseCharacterController, IInteractable 
    {
        [SerializeField] GameObject signObj;
        public IInteractableSign interactableSign{get; private set;}

        void InitializeInteractable(){
            interactableSign = new InteractableSignWithImage(signObj);
        }
        void IInteractable.Interacted(){
            Debug.Log("Interacted");
        }
    }
}
