using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PrototypeLSWProgrammingInterview.System.CharacterAnimation;

namespace PrototypeLSWProgrammingInterview.System.CharacterController.PlayerCharacterController{
    public partial class PlayerCharacterController : BaseCharacterController
    {
        ICharacterAnimation characterAnimation;
        [SerializeField] Animator animator;
        void InitializeAnimation(){
            characterAnimation = new CharacterAnimationUsingAnimator(animator, "horizontal", "vertical","speed");
        }

        void SetAnimation(){
            characterAnimation.SetAnimation(characterMoveInput.horizontalValue, characterMoveInput.verticalValue);
        }
    }
}
