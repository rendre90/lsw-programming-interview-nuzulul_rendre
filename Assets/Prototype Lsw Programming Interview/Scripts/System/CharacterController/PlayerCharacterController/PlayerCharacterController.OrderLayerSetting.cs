using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace PrototypeLSWProgrammingInterview.System.CharacterController.PlayerCharacterController{
    public partial class PlayerCharacterController : BaseCharacterController
    {

        List<(Transform, float)> neighborList = new List<(Transform, float)>();
        [SerializeField] float radiusLayerDetection = 1.5f;

        void SetLayer(){
            foreach(var neighbor in neighborList){
                Vector3 pos = neighbor.Item1.position;
                pos.z = neighbor.Item2;
                neighbor.Item1.position = pos;
            }

            neighborList = new List<(Transform, float)>();
            Collider2D[] detect = GetNeighbor();
            foreach(var i in detect){
                var pos = i.transform.position;
                if(transform.position.y > i.transform.position.y){
                    pos.z = transform.position.z - 0.25f;
                }else{
                    pos.z = transform.position.z + 0.25f;
                }

                neighborList.Add((i.transform, i.transform.position.z));
                i.transform.position = pos;
            }


        }

        Collider2D[] GetNeighbor(){
            Collider2D[] others = Physics2D.OverlapCircleAll(transform.position, radiusLayerDetection, 1 << LayerMask.NameToLayer("Environment"));
            return others;
        }
        
    }
}
