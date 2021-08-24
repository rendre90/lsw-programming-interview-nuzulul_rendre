using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace PrototypeLSWProgrammingInterview.System.CharacterAnimation{
    public class CharacterAnimationUsingAnimator : ICharacterAnimation
    {
        Animator animator;
        readonly string parameter_horizontal_name;
        readonly string parameter_vertical_name;
        readonly string parameter_speed_name;

        public void SetAnimation(Vector2 dir){
            animator.SetFloat(parameter_speed_name, dir.sqrMagnitude);
            animator.SetFloat(parameter_horizontal_name, dir.x);
            animator.SetFloat(parameter_vertical_name, dir.y);
        }


        void SetSpeed(float speed){
            animator.SetFloat(parameter_speed_name, speed);
        }
     


        public CharacterAnimationUsingAnimator(Animator animator, string horizontalParam, string verticalParam, string speedParam){
            this.parameter_vertical_name = verticalParam;
            this.parameter_horizontal_name = horizontalParam;
            this.parameter_speed_name = speedParam;
            this.animator = animator;
        }
         
    }
}
