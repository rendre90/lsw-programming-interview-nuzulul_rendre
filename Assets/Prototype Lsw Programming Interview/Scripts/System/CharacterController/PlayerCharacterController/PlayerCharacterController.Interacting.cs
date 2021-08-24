using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PrototypeLSWProgrammingInterview.System.Input;
using PrototypeLSWProgrammingInterview.System.Interaction;
namespace PrototypeLSWProgrammingInterview.System.CharacterController.PlayerCharacterController{
    public partial class PlayerCharacterController : BaseCharacterController
    {
        IInputKeyPress interactingInput;
        IInteracting interact;
        [SerializeField] [Range(0,10)] float radius = 2;

        void InitializeInteract(){
            interactingInput = new ControllerInputInteracting();
            interact = new InteractingWithRadius(transform, radius, 1 << LayerMask.NameToLayer("NPC") | 1 << LayerMask.NameToLayer("Environment"));
        }

        void ReadInteractionInput(){
            interactingInput.ReadInput();
            if(interactingInput.isKeyDown){
                interact.Interacting();
            }
        }

        void DetectOtherNpc(){
            interact.DetectInteractedObjs();
        }
    }
}
