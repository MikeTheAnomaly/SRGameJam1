using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class SelctorManager : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        Vector3 pointerPos = new Vector3(Pointer.current.position.x.ReadValue(), Pointer.current.position.y.ReadValue(), 0);
        Vector3 worldPosition = Camera.main.ScreenToWorldPoint(pointerPos);
        RaycastHit2D hitData = Physics2D.Raycast(new Vector2(worldPosition.x, worldPosition.y), Vector2.zero, 0);
        {
            if (hitData && Mouse.current.leftButton.isPressed)
            {
                GameObject selectedObject = hitData.transform.gameObject;
                Selectable sel = selectedObject.GetComponent<Selectable>();
                if(sel != null)
                {
                    sel.OnDragUpdate(pointerPos);
                }
            }
        }
    }
}
