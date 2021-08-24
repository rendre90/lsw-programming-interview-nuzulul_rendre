using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PrototypeLSWProgrammingInterview.UI.Abstract;
using PrototypeLSWProgrammingInterview.System.Customation;

namespace PrototypeLSWProgrammingInterview.UI.DressMenu
{
    public class DressMenuController : MenuController
    {
        public override string Path => MenuPath.DressMenu.Main;
        [SerializeField] string clothPath;
        CustomationScriptableObject custom;        
        public void OnClick(){
            custom = CustomationScriptableObject.CreateInstanceObject(clothPath);
            custom.Use(null);
        }
    }
}
