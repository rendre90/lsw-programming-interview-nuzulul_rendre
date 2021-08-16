using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PrototypeLSWProgrammingInterview.Utility.VariableReference
{
    [CreateAssetMenu(menuName = "MyScriptableObject/FloatVariable")]
    public class VariableFloatReference : ScriptableObject, IVariableReference<float>
    {
        public float Value => value;
        [SerializeField] float value;
        [SerializeField] bool isAlwaysPositive;
        public void DecreaseValue(float otherValue){
            value -= otherValue;
            if(isAlwaysPositive){
                value = Mathf.Clamp(value, 0, Mathf.Infinity);
            }
        }

        public void IncreaseValue(float otherValue){
            value  += otherValue;
        }
    }
}
