using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace PrototypeLSWProgrammingInterview.System.CharacterController{

    [RequireComponent(typeof(Rigidbody2D))]
    public abstract class BaseCharacterController : MonoBehaviour
    {
        protected Rigidbody2D rb;
        // Start is called before the first frame update
        protected virtual void Start()
        {
            rb = GetComponent<Rigidbody2D>();
            rb.freezeRotation = true;
            rb.gravityScale = 0;
        }



    }
    
}
