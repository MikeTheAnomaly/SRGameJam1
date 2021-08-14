using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxiomPower : MonoBehaviour
{
    public GameObject EffectedObject;

    void Start()
    {
        if(EffectedObject == null)
        {
            EffectedObject = this.gameObject;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public bool IsGround()
    {
        return (Physics2D.Raycast(this.transform.position, Vector3.down, 1f, LayerMask.NameToLayer("Ground"))); // raycast down to look for ground is not detecting ground? only works if allowing jump when grounded = false; // return "Ground" layer as layer
    }
}
