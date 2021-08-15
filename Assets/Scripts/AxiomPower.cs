using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class AxiomPower : AxiomBase
{
    public float distance;
    public LayerMask groundLayer;

    public override void OnDragUpdate(Vector3 mouseWorld)
    {
        base.OnDragUpdate(mouseWorld);

        if (IsGrounded())
        {
            EffectedObject.transform.position = new Vector3(Pointer.current.position.x.ReadValue(), EffectedObject.transform.position.y, EffectedObject.transform.position.z);
        }
    }

    bool IsGrounded()
    {
        Vector2 position = transform.position;
        Vector2 direction = Vector2.down;

        RaycastHit2D hit = Physics2D.Raycast(position, direction, distance, groundLayer);
        if (hit.collider != null)
        {
            return true;
        }

        return false;
    }
}
