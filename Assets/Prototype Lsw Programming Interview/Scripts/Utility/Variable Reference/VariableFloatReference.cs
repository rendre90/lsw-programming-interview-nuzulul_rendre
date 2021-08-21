using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using PrototypeLSWProgrammingInterview.Utility.VariableReference.ReferenceUtility;

namespace PrototypeLSWProgrammingInterview.Utility.VariableReference
{
    [CreateAssetMenu(menuName = "MyScriptableObjects/FloatVariable")]
    public class VariableFloatReference : BaseVariableReference, IReferenceUtility<float>, IReferenceLerpValue<float>
    {
        public float Value => value;
        public float lerpValue{set;get;}
        [SerializeField] float value;
        [SerializeField] bool isAlwaysPositive;
        public override event Action OnUpdateVariable;
        void OnEnable(){
            lerpValue = 0;
            LerpValue(); 
        }

        void IReferenceUtility<float>.DecreaseValue(float otherValue){
            value -= otherValue;
            if(isAlwaysPositive){
                value = Mathf.Clamp(value, 0, Mathf.Infinity);
            }
            LerpValue(); 
        }

        void IReferenceUtility<float>.IncreaseValue(float otherValue){
            value  += otherValue;
            LerpValue(); 
        }

        void IReferenceUtility<float>.OverrideValue(float otherValue){
            value = otherValue;
            LerpValue();
        }

        void LerpValue(){
            this.LerpFloat(Value, 0.3f, GetHashCode().ToString(),  OnUpdateVariable);
        }

        public override void ForceRefresh(){
            LerpValue();
        }

        public override string ToString()
        {
            return $""+lerpValue.ToString();
        }
    }
}
