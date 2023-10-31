using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PumpkinLight : MonoBehaviour
{
    public Light pumpkinLight;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            pumpkinLight.enabled = !pumpkinLight.enabled;
        }
    }
}
