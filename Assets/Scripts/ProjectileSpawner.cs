using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileSpawner : MonoBehaviour
{
    public GameObject enemyProjectile;
    public float spawnTimer;
    public float spawnMax= 10;
    public float spawnMin = 5;

    // Start is called before the first frame update
    void Start()
    {
        spawnTimer= Random.Range(spawnMin,spawnMax); // random intre 5 si 10
    }

    // Update is called once per frame
    void Update()
    {
        spawnTimer -= Time.deltaTime; // incepe timerul
        if(spawnTimer <=0)
        {
        // Quaternion == vec3
        Instantiate(enemyProjectile, transform.position, Quaternion.identity); 
        spawnTimer = Random.Range(spawnMin,spawnMax);
        }
      
    }
}
