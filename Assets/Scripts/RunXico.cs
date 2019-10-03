using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
  

public class RunXico : MonoBehaviour {
    public float runspeed;
    public int flip;
    public AudioManager killMe;

    void Start() {
        killMe = GameObject.FindObjectOfType<AudioManager>();

    }

    private void OnMouseDown() {
        killMe.Berro();
        ScoreScript.scoreValue += 1;
        Destroy(gameObject);
        if(ScoreScript.scoreValue < 0)
        {
            SceneManager.LoadScene("MainScene"); 
        }
    }

    void Update() {
        transform.position += (Vector3.left * Time.deltaTime * runspeed) * flip;
    }
}
