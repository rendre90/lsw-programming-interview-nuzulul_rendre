using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PrototypeLSWProgrammingInterview.UI.Abstract;
using PrototypeLSWProgrammingInterview.System.Item;
using PrototypeLSWProgrammingInterview.System.Inventory;

namespace PrototypeLSWProgrammingInterview.UI.Shop
{
    public class ShopMenuController : MenuController
    {
        public override string Path => MenuPath.Shop.Main;
        [SerializeField] ShopBlock shopPrefab;
        [SerializeField] ItemData itemData;

        List<StoreItem> clothData;
        [SerializeField]Transform clothParent;
        void Start(){
            clothData = itemData.GetClothItem();
            GenerateShopCloth();
        }
        void GenerateShopCloth(){
            for(int i = 0; i  < clothData.Count; i++){
            ShopBlock spawned  = Instantiate(shopPrefab,clothParent);
            spawned.Display(clothData[i].IconSprite, clothData[i].ItemName, clothData[i].Price);
            int index = i;
            spawned.SetListenerOnBuy(()=>{
                bool valid = InventoryManager.Instance.ReduceCoin(clothData[index].Price);
                if(valid) InventoryManager.Instance.AddItem(clothData[index].ItemId);
            });
            }
        }

    

    }
}
