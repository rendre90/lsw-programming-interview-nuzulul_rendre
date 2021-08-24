using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PrototypeLSWProgrammingInterview.System.CharacterAnimation;
using System;
using PrototypeLSWProgrammingInterview.System.Input;
namespace PrototypeLSWProgrammingInterview.System.CharacterController.PlayerCharacterController{
    public partial class PlayerCharacterController : BaseCharacterController
    {
        ICharacterAnimation characterAnimation;
        [SerializeField] Animator animator;

        IInputAxis axis;
        void InitializeAnimation(){
            characterAnimation = new CharacterAnimationUsingAnimator(animator, "horizontal", "vertical","speed");
            axis = new ControllerInputOneAxis();
        }

        void SetAnimation(){
            axis.ReadInput();
            Vector2 original = new Vector2(axis.horizontalValue, axis.verticalValue);
            characterAnimation.SetAnimation(original);

        }
    }
}
