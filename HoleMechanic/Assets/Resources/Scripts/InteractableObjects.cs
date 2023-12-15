using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableObjects : MonoBehaviour
{
    void Awake()
    {
        Debug.Log(GetComponent<Rigidbody>().sleepThreshold);
        //GetComponent<Rigidbody>().sleepThreshold = 0.0f;
    }
}
