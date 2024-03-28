using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LaunchObject : MonoBehaviour 
{
    public float launchForce = 10f;

    private void OnTriggerEnter(Collider other)

    {
        Rigidbody rb = other.GetComponent<Rigidbody>();

        if (rb != null)
        {

            rb.AddForce(Vector3.up * launchForce, ForceMode.Impulse);

        }


    }


}