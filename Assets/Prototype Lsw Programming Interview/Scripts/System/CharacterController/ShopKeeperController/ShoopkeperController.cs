using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PrototypeLSWProgrammingInterview.System.CharacterController.ShopKeeperController{
    public partial class ShoopkeperController : BaseCharacterController
    {
        protected override void Start()
        {
            base.Start();
            gameObject.layer = LayerMask.NameToLayer("CharacterNPC");
            InitializeInteractable();
        }
    }
}
