using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PrototypeLSWProgrammingInterview.Utility;

namespace PrototypeLSWProgrammingInterview.System.Interaction{
    public class InteractingWithRadius : IInteracting
    {
        Transform transform;
        float radius;
        LayerMask layerMask;
        List<Collider2D> interactedObjsInArea = new List<Collider2D>();
        public InteractingWithRadius(Transform transform, float radius, LayerMask layerMask){
            this.transform = transform;
            this.radius = radius;
            this.layerMask = layerMask;
        } 

        void IInteracting.DetectInteractedObjs(){
            Collider2D[] others = Physics2D.OverlapCircleAll(transform.position, radius, layerMask);
            others = others.FilterCollider((x)=>x.transform.GetComponent<IInteractable>() != null && x.gameObject != transform.gameObject);
            if(interactedObjsInArea.Count > 0){
                for(int i = 0; i < interactedObjsInArea.Count; i++){
                    interactedObjsInArea[i].GetComponent<IInteractable>().interactableSign.DisableSign();
                }
            }
            interactedObjsInArea = new List<Collider2D>();
            for(int i = 0; i < others.Length; i++){
                Vector3 dir = others[i].transform.position - transform.position;
                RaycastHit2D hit = Physics2D.Raycast(transform.position, dir, Mathf.Infinity,layerMask);
                if(hit.collider != null){
                    interactedObjsInArea.Add(hit.collider);
                    hit.transform.GetComponent<IInteractable>().interactableSign.EnableSign();
                }
            }
        }

        void IInteracting.Interacting(){
            if(interactedObjsInArea != null){
                if(interactedObjsInArea.Count > 0){
                    IInteractable interacted = transform.FindNearestCollider(interactedObjsInArea).GetComponent<IInteractable>();
                    if(interacted != null) interacted.Interacted();
                }
            }
        }
    }
}
