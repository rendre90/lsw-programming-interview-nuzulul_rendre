using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PrototypeLSWProgrammingInterview.Utility.VariableReference.ReferenceUtility;
using PrototypeLSWProgrammingInterview.Utility.VariableReference;
using PrototypeLSWProgrammingInterview.System.Item;

namespace PrototypeLSWProgrammingInterview.System.Inventory{
    public class InventoryManager : MonoBehaviour
    {
        [SerializeField] VariableFloatReference playerCoin;
        [SerializeField] ItemData itemData;
        Dictionary<string, int> playerItem = new Dictionary<string, int>();
        IReferenceUtility<float> coinUtility => playerCoin;

        public static InventoryManager Instance;
        void Start(){
            Instance = this;
        }
        public void AddItem(string itemID){
            if(!playerItem.ContainsKey(itemID)){
                playerItem.Add(itemID,1);
            }else{
                playerItem[itemID]++;
            }
        }

        public bool ReduceItem(string itemID){
            if(playerItem.ContainsKey(itemID)){
                if(playerItem[itemID] > 1){
                    playerItem[itemID]--;
                }else{
                    playerItem.Remove(itemID);
                }
                return true;
            }else{
                Debug.LogError("Player doesn't have this item ::" + itemID );
                return false;

            }   
        }

        public void AddCoin(float qty){
            coinUtility.IncreaseValue(qty);
        }

        public bool ReduceCoin(float qty){
            if(playerCoin.Value >= qty){
                coinUtility.DecreaseValue(qty);
                return true;
            }else{
                Debug.LogError("Not Enough Coin");
                return false;
            }
        }
    }
}

