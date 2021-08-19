using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace PrototypeLSWProgrammingInterview.Utility.MenuLink
{
    [CreateAssetMenu(menuName = "MyScriptableObjects/MenuLink")]
    public class MenuLink : ScriptableObject
    {
        [SerializeField] string menuLinkName;
        public event Action ActionLink;

        public void InvokeActionLink(){
            ActionLink?.Invoke();
        }
    }    
}

