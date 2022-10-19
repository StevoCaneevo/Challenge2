using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 10.0f;
    public float xRange = 10;

    public GameObject ProjectilePrefab ;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    //keeping the player from exiting the scene
    {
     if (transform.position.x < -xRange) 
     {
        transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
     }
     if (transform.position.x > xRange) 
     {
        transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
     }
     if (Input.GetKeyDown(KeyCode.Space)) //launch the projectile
        {
            Instantiate(ProjectilePrefab, transform.position, ProjectilePrefab.transform.rotation);
        }

        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
    }
}
