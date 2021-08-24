using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PrototypeLSWProgrammingInterview.System.Item{
    public interface IBaseItem
    {
        string ItemId {get;}
        string ItemName{get;}
        Sprite IconSprite{get;}

    }
}
