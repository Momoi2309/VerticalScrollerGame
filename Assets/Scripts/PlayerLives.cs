using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerLives : MonoBehaviour
{
    public int lives = 3;
    public Image[] livesUI;
    public GameObject explosionprefab;
    private AudioSource audioSource;
    public AudioClip damagesound;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
      
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.gameObject.tag == "Enemy") // looks at the collider, rather than the parent obj
        {
            GetComponent<AudioSource>().PlayOneShot(damagesound);
            Destroy(collision.collider.gameObject); // destroy enemy when collision detected
           GameObject explosionInstance = Instantiate(explosionprefab, transform.position, Quaternion.identity); // se instantiaza explozia
           Destroy(explosionInstance,1.0f); // se distruge instanta dupa collision
            lives -= 1;
            for(int i = 0; i< livesUI.Length; i++)
            {
                if(i <lives)
                {
                    livesUI[i].enabled = true;
                }
                else
                {
                    livesUI[i].enabled = false;
                }
            }
            if(lives <= 0)
            {
                Destroy(gameObject);
            }
        }
    }

     private void OnTriggerEnter(Collider collision)
     {
             if(collision.gameObject.tag == "Enemy Projectile") // looks at the collider, rather than the parent obj
        {
            Destroy(collision.gameObject); // destroy egg when collision detected
            //Instantiate(explosionprefab,transform.position,Quaternion.identity);
            GameObject explosionInstance = Instantiate(explosionprefab, transform.position, Quaternion.identity); // se instantiaza explozia
           Destroy(explosionInstance,1.0f); // se distruge instanta dupa collision
            //Destroy(explosionprefab);
            lives -= 1;
            for(int i = 0; i< livesUI.Length; i++)
            {
                if(i <lives)
                {
                    livesUI[i].enabled = true;
                }
                else
                {
                    livesUI[i].enabled = false;
                }
            }
            if(lives <= 0)
            {
                Destroy(gameObject);
            }
        }
     }

}
