using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PrototypeLSWProgrammingInterview.System.Item{
    public abstract class BaseItem : ScriptableObject, IBaseItem
    {
        [SerializeField] string id;
        [SerializeField] string itemName;
        [SerializeField] Sprite iconSprt;
        [SerializeField] Sprite previewSprt;

        public string ItemId => id;
        public string ItemName=> itemName;
        public Sprite IconSprite => iconSprt;

    }
}
