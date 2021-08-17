using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PrototypeLSWProgrammingInterview.System.Interaction.InteractableSign;

namespace PrototypeLSWProgrammingInterview.System.Interaction{
    public interface IInteractable
    {
        void Interacted();
        IInteractableSign interactableSign{get;}
    }
}
