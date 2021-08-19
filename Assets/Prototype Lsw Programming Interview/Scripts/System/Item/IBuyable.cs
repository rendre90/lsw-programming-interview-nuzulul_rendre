using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PrototypeLSWProgrammingInterview.System.Item{
    public interface IBuyable
    {  
        float Price{get;}
        void Buy(); 
    }
}
