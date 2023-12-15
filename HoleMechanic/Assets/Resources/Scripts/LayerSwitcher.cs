using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LayerSwitcher : MonoBehaviour
{

    [SerializeField] private string enterLayer;
    [SerializeField] private string exitLayer;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Cubes"))
        {
            other.gameObject.layer = LayerMask.NameToLayer(enterLayer);
            other.gameObject.GetComponent<Rigidbody>().sleepThreshold = 0;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Cubes"))
        {
            other.gameObject.layer = LayerMask.NameToLayer(exitLayer);
            other.gameObject.GetComponent<Rigidbody>().sleepThreshold = 0.005f;
        }
    }
}
