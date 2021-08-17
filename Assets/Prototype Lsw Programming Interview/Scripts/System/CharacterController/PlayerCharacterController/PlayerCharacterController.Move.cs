using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PrototypeLSWProgrammingInterview.System.Input;
using PrototypeLSWProgrammingInterview.System.Navigation;
using PrototypeLSWProgrammingInterview.Utility.VariableReference;

namespace PrototypeLSWProgrammingInterview.System.CharacterController.PlayerCharacterController{
    public partial class PlayerCharacterController : BaseCharacterController, IMove
    {
        IInputAxis characterMoveInput;
        [SerializeField]
        VariableFloatReference movementSpeed;
        void InitializeMove(){
            characterMoveInput = new ControllerInputAxis();
        }

        void ReadMoveInput(){
            characterMoveInput.ReadInput();
        }

        public void Move(){
            Vector2 dir = new Vector2(characterMoveInput.horizontalValue, characterMoveInput.verticalValue);
            rb.MovePosition(rb.position + dir * movementSpeed.Value * Time.fixedDeltaTime);
        }
    }
}
