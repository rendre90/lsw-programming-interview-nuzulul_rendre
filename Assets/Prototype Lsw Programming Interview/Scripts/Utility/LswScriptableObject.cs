using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PrototypeLSWProgrammingInterview.Utility{
    public abstract class LswScriptableObject : ScriptableObject
    {
        [SerializeField] string path;
        public string Path => path;
        public void InitPath(string path){
            this.path = path;
        }
        
    }
}
