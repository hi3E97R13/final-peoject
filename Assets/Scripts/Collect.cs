using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]

public class Collect : MonoBehaviour
{
    public AudioClip collect;
    AudioSource audioSource;
    public GameObject gameObject;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    
    void OnCollisionEnter(Collision collision){
        audioSource.PlayOneShot(collect, 0.5F);
        Destroy(gameObject, 0.4F);
        Debug.Log("work dammit");
    }   
}
