using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 25.0f ;
    private float lowBound = -25.0f; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topBound)
        {
            Destroy(gameObject); 
        }
        else if (transform.position.z < lowBound)
        {
            Debug.Log("GameOver !");
            Destroy(gameObject);
           
        }
        if (transform.position.x > topBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.x < lowBound)
        {
            Debug.Log("GameOver !");
            Destroy(gameObject);
        }
    }
}
