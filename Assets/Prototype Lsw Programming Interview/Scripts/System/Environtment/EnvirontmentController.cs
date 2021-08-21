using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PrototypeLSWProgrammingInterview.System.Interaction;
using PrototypeLSWProgrammingInterview.System.Interaction.InteractableSign;
using PrototypeLSWProgrammingInterview.Utility.MenuLink;
public class EnvirontmentController : MonoBehaviour, IInteractable
{
    [SerializeField] string environmentName;
    [SerializeField] GameObject signObj;
    public IInteractableSign interactableSign{get; private set;}
    [SerializeField] MenuLink shopLink;
    void Start(){
        gameObject.layer = LayerMask.NameToLayer("Environment");
        interactableSign = new InteractableSignWithImage(signObj);
    }

    void IInteractable.Interacted(){
        shopLink.InvokeActionLink();
    } 


}
