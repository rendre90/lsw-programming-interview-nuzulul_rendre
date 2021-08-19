using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PrototypeLSWProgrammingInterview.UI.Abstract;
namespace PrototypeLSWProgrammingInterview.UI.Shop{
    public class ShopMenuManager : MenuManager
    {
        [SerializeField] MenuLinkController shopMenuLink;
        [SerializeField] Transform canvasParent;
        
        void OnEnable(){
            shopMenuLink.menuLink.ActionLink+=ShowShopMenu;
        }
        void OnDisable(){
            shopMenuLink.menuLink.ActionLink -= ShowShopMenu;
        }

        void Start(){
            
        }

        void Update(){
           
        }

        void ShowShopMenu(){
            MenuManager.Show(shopMenuLink, canvasParent);
        }
    }
}
