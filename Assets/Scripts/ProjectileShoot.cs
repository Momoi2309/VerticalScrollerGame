using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileShoot : MonoBehaviour
{
    public GameObject projectilePrefab;
    private AudioSource audioSource;
    public AudioClip shotSound;
    // Start is called before the first frame update

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
      
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Instantiate(projectilePrefab,transform.position, Quaternion.identity); // no rotation
            GetComponent<AudioSource>().PlayOneShot(shotSound);

        }
    }

    
}
