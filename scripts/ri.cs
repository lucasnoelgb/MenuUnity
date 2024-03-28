using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ri : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Transparente"))
        {
            Destroy(gameObject);

        }

    }
}