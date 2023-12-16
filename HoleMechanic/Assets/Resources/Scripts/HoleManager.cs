using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoleManager : MonoBehaviour, IObserver
{
    [SerializeField] Subject cubeCheckSubject;


    public void OnNotify()
    {
        Debug.Log("A cube has eaten");
    }

    private void OnEnable()
    {
        cubeCheckSubject.AddObserver(this);
    }

    private void OnDisable()
    {
        cubeCheckSubject.RemoveObserver(this);
    }
}
