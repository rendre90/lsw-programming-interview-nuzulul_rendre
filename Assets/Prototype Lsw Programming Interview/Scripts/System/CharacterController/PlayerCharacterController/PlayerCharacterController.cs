using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace PrototypeLSWProgrammingInterview.System.CharacterController.PlayerCharacterController{
    public partial class PlayerCharacterController : BaseCharacterController
    {
    
       protected override void Start(){
           base.Start();
           transform.tag = "Player";
           gameObject.layer = LayerMask.NameToLayer("CharacterPlayer");
           InitializeMove();
           InitializeInteract();
           InitializeAnimation();
       }

       void Update(){
           ReadMoveInput();
           ReadInteractionInput();
           SetAnimation();
           SetLayer();
       }

       void FixedUpdate(){
           Move();
           DetectOtherNpc();
       }
    }
}
