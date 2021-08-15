using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ButtonScript : MonoBehaviour
{
    public UnityEvent OnClicked = new UnityEvent();
    bool clicked = false;
    public Animation anima;
    public Animator clip;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.GetComponent<AxiomPower>() != null)
        {
            if (!clicked)
            {
                OnClicked.Invoke();
                if (anima != null)
                {
                    anima.Play();
                }
                if (clip != null)
                {
                    clip.SetBool("on", true);
                }
                clicked = true;
            }

            
        }
    }
}
