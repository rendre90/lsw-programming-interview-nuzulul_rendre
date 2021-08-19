using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System;
namespace PrototypeLSWProgrammingInterview.UI.Shop
{
    public class ShopBlock : MonoBehaviour
    {
        [SerializeField] Image itemImg;
        [SerializeField] Image bg;
        [SerializeField] TMP_Text priceText;
        [SerializeField] TMP_Text itemText;
        [SerializeField] Button buyBtn;
        public void Display(Sprite itemSprt, string itemName, float price){
            itemImg.sprite = itemSprt;
            itemText.text = itemName;
            priceText.text = $""+price;
        }
        public void SetListenerOnBuy(Action buyAction){
            buyBtn.onClick.AddListener(()=>buyAction());
        }
        
    }
}
