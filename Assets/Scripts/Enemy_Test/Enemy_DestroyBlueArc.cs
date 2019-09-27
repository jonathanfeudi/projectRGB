using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_DestroyBlueArc : MonoBehaviour
{
    public GameObject blueArc;

    public void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Blue_Arc")
        {
            blueArc = other.gameObject;
        }
    }

    // Destroy Arc
    public void DestroyBlueArc()  // Collision Event?
    {
        Destroy(blueArc);
    }
}
