using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectRotate : MonoBehaviour
{
    public GameObject player;
    public float rotationSpeed;
    public Vector3 rotationAngle;

    // Update is called once per frame
    void Update()
    {
        float playerDistance = (transform.position - player.transform.position).magnitude;
        transform.Rotate(rotationAngle * rotationSpeed * 1/playerDistance * Time.deltaTime);
    }
}
