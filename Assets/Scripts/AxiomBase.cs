using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxiomBase: Selectable
{
    public GameObject EffectedObject;
    public float distance;
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

    public override void OnHover()
    {
        base.OnHover();
        sprite.color = new Color(.5f, .5f, 0);
    }

    public override void OnSelected()
    {
        base.OnSelected();
        sprite.color = new Color(0, 1, 0);
    }

    public override void OnSelectedUpdate()
    {
        base.OnSelectedUpdate();
    }
}
