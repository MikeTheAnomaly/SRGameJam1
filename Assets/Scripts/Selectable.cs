using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Selectable : MonoBehaviour
{
    public UnityEvent<Vector3> onHover = new UnityEvent<Vector3>();
    public UnityEvent<Vector3> onDeHover = new UnityEvent<Vector3>();
    public UnityEvent<Vector3> onSelected = new UnityEvent<Vector3>();
    public UnityEvent<Vector3> deSelected = new UnityEvent<Vector3>();
    public UnityEvent<Vector3> onDragUpdate = new UnityEvent<Vector3>();

    public virtual void OnHover(Vector3 mouseWorld)
    {
        onHover.Invoke(mouseWorld);
    }
    public virtual void OnDeHover(Vector3 mouseWorld)
    {
        onDeHover.Invoke(mouseWorld);
    }

    public virtual void OnSelected(Vector3 mouseWorld)
    {
        onSelected.Invoke(mouseWorld);
    }

    public virtual void DeSelected(Vector3 mouseWorld)
    {
        deSelected.Invoke(mouseWorld);
    }


    public virtual void OnDragUpdate(Vector3 mouseWorld)
    {
        onDragUpdate.Invoke(mouseWorld);
    }

}
