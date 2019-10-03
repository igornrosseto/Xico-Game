using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class maneteColide : MonoBehaviour
{
    private Vector3 _initialPosition;

    // Start is called before the first frame update
    void Start()
    {
        _initialPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Respawn"))
        {
            //  SceneManager.LoadScene("SampleScene"); 
            ScoreScript.scoreValue += -1;
            transform.position = _initialPosition;
        }
    }
}
