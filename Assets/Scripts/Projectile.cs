using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float moveSpeed=10f;
    public GameObject explosionpref;
    private ScoreManager scoreManager; // e prefab asa ca inca nu e instantiat  nu poate sa gaseasca Scoremanager;

    

    // Start is called before the first frame update
    void Start()
    {
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>(); // comunica cu scriptu de pe comp
    }
  
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.up * moveSpeed * Time.deltaTime); // se deplaseaza in sus cu o viteza constanta
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
             
            GameObject explosionInstance = Instantiate(explosionpref, transform.position, Quaternion.identity); // se instantiaza explozia
            Destroy(collision.gameObject); // distruge enemy
            Destroy(explosionInstance,1.0f); // destroy explosion after a delay of 1 sec
            scoreManager.UpdateScore(10); // se apeleaza functia din scriptul de pe ScoreManager
            Destroy(gameObject); // se distruge si proiectilul la contactul cu enemy
            
        }

        if(collision.gameObject.tag == "Boundary")
        {
            Destroy(gameObject); // se distruge proiectilul la contactul cu boundary
        }
    }
}
