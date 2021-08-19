using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PrototypeLSWProgrammingInterview.System.Item{

    [CreateAssetMenu(menuName = "MyScriptableObjects/Items/StoreItem")]
    public class StoreItem : UseableItem, IBuyable
    {
        [SerializeField] float price;
        public float Price => price;
        void IBuyable.Buy(){
            
        }
    }
}
