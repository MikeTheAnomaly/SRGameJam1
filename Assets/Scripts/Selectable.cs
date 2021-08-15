using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Selectable : MonoBehaviour
{
    public UnityEvent onHover = new UnityEvent();
    public UnityEvent onSelected = new UnityEvent();
    public UnityEvent deSelected = new UnityEvent();
    public UnityEvent onDragUpdate = new UnityEvent();

    public virtual void OnHover()
    {
        onHover.Invoke();
    }

    public virtual void OnSelected()
    {
        onSelected.Invoke();
    }

    public virtual void DeSelected()
    {
        deSelected.Invoke();
    }


    public virtual void OnDragUpdate()
    {
        onDragUpdate.Invoke();
    }

}
