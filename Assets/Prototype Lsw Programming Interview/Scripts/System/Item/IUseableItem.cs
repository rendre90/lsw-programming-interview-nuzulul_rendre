using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IUseableItem
{
    void Use(Sprite sprt);
    void Preview();
    void UnUse();
}
