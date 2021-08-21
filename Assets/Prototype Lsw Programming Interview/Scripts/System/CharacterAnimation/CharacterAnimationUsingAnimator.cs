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

        public void SetAnimation(float horizontal, float vertical){
            animator.SetFloat(parameter_horizontal_name, horizontal);
            animator.SetFloat(parameter_vertical_name, vertical);
            Vector2 dir = new Vector2(horizontal, vertical);
            animator.SetFloat(parameter_speed_name, dir.sqrMagnitude);
        }

   

        public void FaceFront(float dir ){
            
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
