using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverController : MonoBehaviour
{
    public LeverScript[] leverArray = new LeverScript[3];

    private void Update()
    {
        int count = 0;

        foreach(LeverScript lever in leverArray)
        {
            if(lever.isTriggered)
            {
                count++;
            }
        }
        if (count==leverArray.Length)
        {
            openCage();
        }
    }

    public void openCage()
    {

    }
}
