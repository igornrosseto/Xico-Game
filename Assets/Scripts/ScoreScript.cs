using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreScript : MonoBehaviour
{
    public static int scoreValue = 0;
    Text Score;
    public float restartDelay = 5f;         // Time to wait before restarting the level
    float restartTimer;
    public AudioManager2 gameover;



    // Start is called before the first frame update
    void Start()
    {

        scoreValue = 0;
        Score = GetComponent<Text>();
        gameover = GameObject.FindObjectOfType<AudioManager2>();
        
    }

    // Update is called once per frame
    void Update()
    {
        Score.text = "Xicos destruídos: " + scoreValue;
        if (scoreValue < 0)
        {
            
            Score.text = "GAME OVER! Xico manetou demais.";
            // gameover.Berrao();
            
           
             // .. increment a timer to count up to restarting.
            restartTimer += Time.deltaTime;

            // .. if it reaches the restart delay...
            if (restartTimer >= restartDelay)
            {
                
                SceneManager.LoadScene("MainScene");
            }
        }

        
    }
}
