using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mo : MonoBehaviour
{
    //movimento
    public float fast = 0f;




    void Start()

    { 
    }

    void Update()
    {
        //movimento
       
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0f, 0f, -fast);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-fast, 0f, 0f );
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0f, 0f, fast);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(fast, 0f, 0f );
        }
        if (Input.GetKey(KeyCode.Space))
        {
            transform.Translate(0f, 0.5f, 0f );
        }
      
        
    }
}
