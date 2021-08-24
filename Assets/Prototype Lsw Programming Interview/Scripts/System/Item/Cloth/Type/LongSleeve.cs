using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace PrototypeLSWProgrammingInterview.System.Item.Cloth.Type{
    [CreateAssetMenu(menuName = "MyScriptableObjects/Cloth/LongSleeve")]
    public class LongSleeve : ShortSleeve
    {
        [SerializeField] ItemCharacterSprite armLeftSprt;
        [SerializeField] ItemCharacterSprite armRightSprt;
    }
}
