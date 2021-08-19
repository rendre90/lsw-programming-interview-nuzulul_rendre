using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PrototypeLSWProgrammingInterview.Utility.VariableReference;
using TMPro;

namespace PrototypeLSWProgrammingInterview.UI
{
    public class VariableText : MonoBehaviour
    {
        [SerializeField] BaseVariableReference value;
        [SerializeField] TMP_Text valueText;
        [SerializeField] string initialText;

        void OnEnable(){
            value.OnUpdateVariable += UpdateValue;
            UpdateValue();
        }

        void Start(){
           value.ForceRefresh();
        }

    
        void OnDisable(){
            value.OnUpdateVariable -= UpdateValue;
        }

        void UpdateValue(){
            valueText.text = $""+initialText + value.ToString();
        } 
    }
}

