using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeCheck : Subject
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Cubes"))
        {
            NotifyObservers();
        }
    }

}
