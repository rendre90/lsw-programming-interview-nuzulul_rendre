using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PrototypeLSWProgrammingInterview.UI.Abstract;
namespace PrototypeLSWProgrammingInterview.UI{
    public class ShopMenuManager : MenuManager
    {
        [SerializeField] MenuLinkController shopMenuLink, dialogLink;
        [SerializeField] Transform canvasParent;
        
        void OnEnable(){
            shopMenuLink.menuLink.ActionLink += ShowShopMenu;
            dialogLink.menuLink.ActionLink += ShowDialogMenu;
        }
        void OnDisable(){
            shopMenuLink.menuLink.ActionLink -= ShowShopMenu;
            dialogLink.menuLink.ActionLink -= ShowDialogMenu;
        }

        void Start(){
            
        }

        void Update(){
           
        }

        void ShowShopMenu(){
            MenuManager.Show(shopMenuLink, canvasParent);
        }
        void ShowDialogMenu(){
            MenuManager.Show(dialogLink, canvasParent);
        }
    }
}
