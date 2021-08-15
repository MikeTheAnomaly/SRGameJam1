using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxiomPower : MonoBehaviour
{
    public float distance;
    public LayerMask groundLayer;

    // Update is called once per frame
    void Update()
    {
        Vector3 worldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        RaycastHit2D hitData = Physics2D.Raycast(new Vector2(worldPosition.x, worldPosition.y), Vector2.zero, 0);
        {
            if (hitData && Input.GetMouseButtonDown(0))
            {
                GameObject selectedObject = hitData.transform.gameObject;
            }
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
