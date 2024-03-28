using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ObjetoKinematic: MonoBehaviour

{
    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("quadrado"))
        {
            AtivarEventoPegar();
            SceneManager.LoadScene("Creditos");

        }
    }

    
    private void AtivarEventoPegar()
    {


        Debug.Log("Objeto Pego! ");
        gameObject.SetActive(false);
    }

}

    
