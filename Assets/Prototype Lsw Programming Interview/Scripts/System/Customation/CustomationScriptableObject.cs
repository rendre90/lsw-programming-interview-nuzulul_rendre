using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PrototypeLSWProgrammingInterview.Utility;
namespace PrototypeLSWProgrammingInterview.System.Customation
{
    public class CustomationScriptableObject : LswScriptableObject, IUseableItem
    {
        SpriteRenderer spriteRenderer;

        public void Initialize(SpriteRenderer spriteRenderer){
            this.spriteRenderer = spriteRenderer;
        }
        public void Use(Sprite sprt){
            spriteRenderer.sprite = sprt;
            spriteRenderer.enabled = true;
        }
        public void UnUse(){
            spriteRenderer.sprite = null;
            spriteRenderer.enabled = false;
        }
        public void Preview(){
            
        }

        public static CustomationScriptableObject CreateInstanceObject(string path){
            CustomationScriptableObject thisObj = LswScriptableObjectResource<CustomationScriptableObject>.CreateInstanceObject(path);
            return thisObj;
        }
    }    
}

