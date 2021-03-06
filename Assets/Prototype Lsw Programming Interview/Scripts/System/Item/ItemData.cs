using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PrototypeLSWProgrammingInterview.System.Item.Cloth;

namespace PrototypeLSWProgrammingInterview.System.Item{

    [CreateAssetMenu(menuName = "MyScriptableObjects/ItemDataBase")]
    public class ItemData : ScriptableObject
    {
        [SerializeField] List<BaseItem> items;
        
        public List<StoreItem> GetBuyAbleItem(){
            List<StoreItem> store = new List<StoreItem>();
            var storeBase = items.FindAll((x)=>x is  StoreItem);
            for(int i = 0; i < storeBase.Count; i++){
                store.Add((StoreItem) storeBase[i]);
            }
            return store;
        } 

        public List<BaseItem> DefaultItem(){
            return items.FindAll((x)=>x is UseableItem);
        }

        public List<StoreItem> GetClothItem(){
            return GetBuyAbleItem().FindAll(((x)=>x is ClothData));
        }


    }
}
