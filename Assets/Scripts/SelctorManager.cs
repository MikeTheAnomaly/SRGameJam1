using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class SelctorManager : MonoBehaviour
{

    public Selectable lastClick;
    public Selectable lastHover;

    // Update is called once per frame
    void Update()
    {
        Vector3 pointerPos = new Vector3(Pointer.current.position.x.ReadValue(), Pointer.current.position.y.ReadValue(), 0);
        Vector3 worldPosition = Camera.main.ScreenToWorldPoint(pointerPos);
        RaycastHit2D hitData = Physics2D.Raycast(new Vector2(worldPosition.x, worldPosition.y), Vector2.zero, 0);
        {
            if (hitData.transform != null)
            {
                GameObject selectedObject = hitData.transform.gameObject;
                Selectable sel = selectedObject.GetComponent<Selectable>();
                if (sel != null)
                {
                    if(lastClick != sel && lastClick != null)
                    {
                        lastClick.DeSelected(hitData.point);
                        lastClick.OnDeHover(hitData.point);
                    }
                    if (lastHover != sel && lastHover != null)
                    {
                        lastHover.DeSelected(hitData.point);
                        lastHover.OnDeHover(hitData.point);
                    }
                    lastHover = sel;
                    if (hitData && Mouse.current.leftButton.isPressed)
                    {

                        lastClick = sel;
                        sel.OnDragUpdate(hitData.point);
                    }
                    else
                    {
                        sel.OnHover(hitData.point);
                    }
                }
            }
            else
            {
                if ( lastClick != null)
                {
                    lastClick.DeSelected(hitData.point);
                }
                if (lastHover != null)
                {
                    lastHover.OnDeHover(hitData.point);
                }
                lastClick = null;
                lastHover = null;
            }
        }
    }
}
