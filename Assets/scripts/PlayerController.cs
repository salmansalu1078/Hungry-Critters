using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float verticalInput;
    public float speed = 10.0f;
    public float xRange = -25.0f;
    public GameObject projectileprefab; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical"); 
        transform.Translate(Vector3.right*horizontalInput *Time.deltaTime*speed);
        transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * speed);

        if (transform.position.x > -xRange)
        {
            transform.position = new Vector3(20 , transform.position.y,transform.position.z);
        }
        if (transform.position.x < xRange)
        {
            transform.position = new Vector3(-20, transform.position.y, transform.position.z);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectileprefab,transform.position, transform.rotation);
        }
    }
}
