using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverScript : Selectable
{
    public bool isTriggered = false;

    public Animator leverAni;
    public override void DeSelected(Vector3 mouseWorld)
    {
        base.DeSelected(mouseWorld);
        isTriggered = !isTriggered;
        leverAni.SetBool("Active", isTriggered);
    }
}
