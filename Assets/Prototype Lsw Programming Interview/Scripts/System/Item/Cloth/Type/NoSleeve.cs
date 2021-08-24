using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PrototypeLSWProgrammingInterview.System.Item.Cloth.Type{
    
    [CreateAssetMenu(menuName = "MyScriptableObjects/Cloth/NoSleeve")]
    public class NoSleeve : ClothData
    {
        [SerializeField] ItemCharacterSprite bodySprt;
    }
}
