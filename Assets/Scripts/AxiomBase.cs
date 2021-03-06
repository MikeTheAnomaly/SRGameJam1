using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxiomBase: Selectable
{
    public GameObject EffectedObject;
    public SpriteRenderer sprite;
    private Color startColor;

    void Start()
    {
        if (EffectedObject == null)
        {
            EffectedObject = this.gameObject;
        }
        if(sprite == null)
        {
            sprite = this.GetComponent<SpriteRenderer>();
        }
        startColor = sprite.color;
    }

    public override void OnHover(Vector3 mouseWorld)
    {
        base.OnHover(mouseWorld);
        sprite.color = new Color(.5f, .5f, 0);
    }

    public override void OnSelected(Vector3 mouseWorld)
    {
        base.OnSelected(mouseWorld);
        sprite.color = new Color(0, 1, 0);
    }

    public override void OnDragUpdate(Vector3 mouseWorld)
    {
        base.OnDragUpdate( mouseWorld);
    }

    public override void OnDeHover(Vector3 mouseWorld)
    {
        base.OnDeHover(mouseWorld);
        sprite.color = startColor;
    }
}
