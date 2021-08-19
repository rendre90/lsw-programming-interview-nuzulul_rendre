using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PrototypeLSWProgrammingInterview.System.Item{
    public abstract class BaseItem : ScriptableObject, IBaseItem
    {
        [SerializeField] string id;
        [SerializeField] ItemType type;
        [SerializeField] string itemName;
        [SerializeField] Sprite iconSprt;
        [SerializeField] Sprite previewSprt;

        public string ItemId => id;
        public ItemType ItemType => type;
        public string ItemName=> itemName;
        public Sprite PreviewSprite => previewSprt;
        public Sprite IconSprite => iconSprt;

    }
}
