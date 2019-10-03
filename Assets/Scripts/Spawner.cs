using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject xico;
    
    public bool flip;
    public float spawnTimer = 5;


    void Start()
    {
        StartCoroutine(SpawnXico());
        
    }

    void Update()
    {

    }

    IEnumerator SpawnXico()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(0.5f, spawnTimer * 2));
            spawnTimer -= 0.01f;
            spawnTimer = Mathf.Clamp(spawnTimer, 0.5f, 5);
            GameObject o = Instantiate(xico, transform.position, Quaternion.identity);
            if (flip) { o.GetComponent<RunXico>().flip = -1; o.GetComponent<SpriteRenderer>().flipX = true; }
            float a = Random.Range(-4, 4);
            while (a < 2.6f && a > -0.6f)
            {
                a = Random.Range(-4, 4);
                yield return new WaitForSeconds(0.01f);
            }

            o.transform.position = new Vector3(o.transform.position.x, a);
        }
    }
  
}

