using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PrototypeLSWProgrammingInterview.Utility.MenuLink;
using PrototypeLSWProgrammingInterview.UI.Abstract;

namespace PrototypeLSWProgrammingInterview.UI{
    [CreateAssetMenu(menuName = "MyScriptableObjects/UI/MenuLinkController")]
    public class MenuLinkController : ScriptableObject
    {
        [SerializeField] MenuController menuController;
        public MenuController Menu =>menuController;
        public MenuLink menuLink;
    }
}
