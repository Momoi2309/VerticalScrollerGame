using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickenMovement : MonoBehaviour
{
    public float moveSpeed=5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right *moveSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.tag == "Boundary")
        {
            transform.position = new Vector3(transform.position.x,transform.position.y -1, transform.position.z);
            moveSpeed *= -1;
        }

        // daca atinge bara de jos se distruge
        if(collision.gameObject.tag == "Boundary_bot")
        {
            Destroy(gameObject);
        }
        
    }



    
}
