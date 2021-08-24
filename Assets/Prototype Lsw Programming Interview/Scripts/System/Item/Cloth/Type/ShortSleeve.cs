using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PrototypeLSWProgrammingInterview.System.Item.Cloth.Type{
    [CreateAssetMenu(menuName = "MyScriptableObjects/Cloth/ShortSleeve")]
    public class ShortSleeve : NoSleeve
    {
        [SerializeField] ItemCharacterSprite shoulderLeftSprt;
        [SerializeField] ItemCharacterSprite shoulderRightSprt;
    }
}
