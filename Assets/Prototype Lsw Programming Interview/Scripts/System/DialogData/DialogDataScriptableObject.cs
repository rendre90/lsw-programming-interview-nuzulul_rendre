using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PrototypeLSWProgrammingInterview.System.DialogData
{
    [CreateAssetMenu (menuName = "MyScriptableObjects/DialogData")]
    public class DialogDataScriptableObject : ScriptableObject
    {
        [TextArea(4, 4),SerializeField] string dialogText;
        public void ShowDialog(){
            
        }
    }    
}

