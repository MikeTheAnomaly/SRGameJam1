using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class RedSoloCup : MonoBehaviour
{
    public List<AxiomPower> bucket;
    public UnityEvent OnClicked = new UnityEvent();
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.GetComponent<AxiomPower>() != null)
        {
            bucket.Add(collision.gameObject.GetComponent<AxiomPower>());
        }
    }

    private void Update()
    {
        if(bucket.Count == 2)
        {
            OnClicked.Invoke();
        }else if(bucket.Count == 1)
        {
            if (bucket[0].type == "Big")
            {
                OnClicked.Invoke();
            }
        }
    }
}
