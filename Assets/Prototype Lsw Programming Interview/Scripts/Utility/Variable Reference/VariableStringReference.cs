using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using PrototypeLSWProgrammingInterview.Utility.VariableReference.ReferenceUtility;
using System.Threading.Tasks;
namespace PrototypeLSWProgrammingInterview.Utility.VariableReference
{
    [CreateAssetMenu(menuName = "MyScriptableObjects/VariableStringReference")]
    public class VariableStringReference : BaseVariableReference, IReferenceLerpValue<string>
    {
        public string Value => value;
        [SerializeField, TextArea(4,4)] string value;
        public VariableFloatReference floatReference;        
        public override event Action OnUpdateVariable;
        public string lerpValue{set; get;}
        public override void ForceRefresh(){LerpValue();}
        [SerializeField] float normalSpeed;
        [SerializeField] float fastSpeed;
        void LerpValue(){
            ChangeToNormalSpeed();
            this.LerpString(value, OnUpdateVariable);
        }
        
        public void ChangeToFastSpeed(){
            ChangeSpeed(fastSpeed);
        }

        public void ChangeToNormalSpeed(){
            ChangeSpeed(normalSpeed);
        }

        void ChangeSpeed(float speed){
            IReferenceUtility<float> speedUtility = floatReference;
            speedUtility.OverrideValue(speed);
        }

    }
}
