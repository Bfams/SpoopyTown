using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class NukeInteract : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip boomSound;
    public float boomVolume = 1;

    public bool canInteractWith = false;
    public bool isInTrigger = false;
    public float interactDelay;

    private void Start()
    {
        StartCoroutine(InteractionDelay());
    }

    void Update()
    {
        if(isInTrigger)
        {
            audioSource.PlayOneShot(boomSound, boomVolume);
            canInteractWith = false;
            StartCoroutine(InteractionDelay());
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            isInTrigger = true;
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            isInTrigger = false;
        }
    }

    IEnumerator InteractionDelay()
    {
        yield return new WaitForSecondsRealtime(interactDelay);
        canInteractWith = true;
    }
}
