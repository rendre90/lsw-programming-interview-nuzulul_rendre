using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PrototypeLSWProgrammingInterview.System.Item{
    public interface IBaseItem
    {
        string ItemId {get;}
        string ItemName{get;}
        ItemType ItemType{get;}
        Sprite IconSprite{get;}
        Sprite PreviewSprite{get;}
    }
}
