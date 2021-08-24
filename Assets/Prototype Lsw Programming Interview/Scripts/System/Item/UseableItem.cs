using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace PrototypeLSWProgrammingInterview.System.Item{
    [CreateAssetMenu(menuName = "MyScriptableObjects/Items/UseableItems")]
    public class UseableItem : BaseItem, IUseableItem
    {

        void IUseableItem.Use(Sprite sprite){

        }

        void IUseableItem.Preview(){
            
        }

        void IUseableItem.UnUse(){
            
        }
    }
}
