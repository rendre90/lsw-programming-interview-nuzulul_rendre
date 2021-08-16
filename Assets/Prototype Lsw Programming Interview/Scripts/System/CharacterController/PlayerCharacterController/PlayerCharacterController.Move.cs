using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PrototypeLSWProgrammingInterview.System.CharacterInput;
using PrototypeLSWProgrammingInterview.System.Navigation;
using PrototypeLSWProgrammingInterview.Utility.VariableReference;

namespace PrototypeLSWProgrammingInterview.System.CharacterController.PlayerCharacterController{
    public partial class PlayerCharacterController : BaseCharacterController, IMove
    {
        ICharacterInput characterInput;
        [SerializeField]
        VariableFloatReference movementSpeed;
        void InitializeMove(){
            characterInput = new ControllerInput();
        }

        void SetDirection(){
            characterInput.ReadInput();
        }

        public void Move(){
            Vector2 dir = new Vector2(characterInput.horizontalValue, characterInput.verticalValue);
            rb.MovePosition(rb.position + dir * movementSpeed.Value * Time.fixedDeltaTime);
        }
    }
}
