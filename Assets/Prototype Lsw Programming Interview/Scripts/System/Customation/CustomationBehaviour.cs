using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PrototypeLSWProgrammingInterview.System.Customation{
    public class CustomationBehaviour : MonoBehaviour
    {
        IUseableItem useableItem;
        [SerializeField] SpriteRenderer spriteRenderer;
        [SerializeField] string path;
        void Start(){
            Initialize();
        }
        void Initialize(){
            CustomationScriptableObject customation = CustomationScriptableObject.CreateInstanceObject(path);
            customation.Initialize(spriteRenderer);
            useableItem = customation;
        }

         
    }
}
