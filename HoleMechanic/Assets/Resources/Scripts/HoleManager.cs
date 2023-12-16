using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoleManager : MonoBehaviour, IObserver
{
    public List<AudioClip> gulpSounds = new List<AudioClip>();
    [SerializeField] Subject cubeCheckSubject;
    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void OnNotify()
    {
        Eat();
    }

    private void OnEnable()
    {
        cubeCheckSubject.AddObserver(this);
    }

    private void OnDisable()
    {
        cubeCheckSubject.RemoveObserver(this);
    }

    private void Eat()
    {
        transform.localScale += new Vector3(0.05f, 0, 0.05f);
        var randomIndex = Random.Range(0, gulpSounds.Count);
        audioSource.PlayOneShot(gulpSounds[randomIndex]);
    }
}
