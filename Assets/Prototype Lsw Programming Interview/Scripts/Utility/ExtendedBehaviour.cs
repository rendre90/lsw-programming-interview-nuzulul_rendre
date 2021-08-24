using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using DG.Tweening;
namespace PrototypeLSWProgrammingInterview.Utility{
    public static class ExtendedBehaviour
    {
        public static Collider2D FindNearestCollider(this Transform transform, Collider2D[] colliders){
            float nearestDis = Mathf.Infinity;
            Collider2D nearestCollider = null;
            for(int i = 0; i < colliders.Length; i++){
                float currentDis = Vector3.Distance(transform.position, colliders[i].transform.position);
                if(currentDis < nearestDis){
                    nearestDis = currentDis;
                    nearestCollider = colliders[i];
                }
            }

            return nearestCollider;
        }

        public static Collider2D FindNearestCollider(this Transform transform, List<Collider2D> colliders){
            float nearestDis = Mathf.Infinity;
            Collider2D nearestCollider = null;
            for(int i = 0; i < colliders.Count; i++){
                float currentDis = Vector3.Distance(transform.position, colliders[i].transform.position);
                if(currentDis < nearestDis){
                    nearestDis = currentDis;
                    nearestCollider = colliders[i];
                }
            }

            return nearestCollider;
        }
        public static Collider2D[] FilterCollider(this Collider2D[] colliders, Predicate<Collider2D> p = null){
            return p == null ? colliders : Array.FindAll(colliders, p);
        }
    }
}
