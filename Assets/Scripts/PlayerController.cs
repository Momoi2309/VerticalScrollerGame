using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         // Get input from keyboard
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Calculate movement in x and z directions
        float moveX = horizontalInput * moveSpeed * Time.deltaTime;
        float moveZ = verticalInput * moveSpeed * Time.deltaTime;

        // Move the object on the x and z axes
        transform.Translate(new Vector3(moveX, 0, moveZ));
    }
}
