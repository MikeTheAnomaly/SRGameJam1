using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class AxiomPower : AxiomBase
{
    public float distance;
    public LayerMask groundLayer;
    public float movmentForce = 100;
    Vector3 lastPos;
    public string type = "Big";

    public override void OnDragUpdate(Vector3 mouseWorld)
    {
        base.OnDragUpdate(mouseWorld);

        if (IsGrounded())
        {
            
            lastPos = EffectedObject.transform.position;
            EffectedObject.GetComponent<Rigidbody2D>().velocity = new Vector2(-(transform.position.x - mouseWorld.x) * movmentForce, EffectedObject.GetComponent<Rigidbody2D>().velocity.y);
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

    public override void DeSelected(Vector3 mouseWorld)
    {
        base.DeSelected(mouseWorld);

    }
}
