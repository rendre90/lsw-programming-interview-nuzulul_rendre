using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PrototypeLSWProgrammingInterview.System.CharacterInput;


namespace PrototypeLSWProgrammingInterview.System.CharacterController.PlayerCharacterController{
    public partial class PlayerCharacterController : BaseCharacterController
    {
    
       protected override void Start(){
           base.Start();
           transform.tag = "Player";
           InitializeMove();
       }

       void Update(){
           SetDirection();
       }

       void FixedUpdate(){
           Move();
       }
    }
}
