using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CatchSpawn : MonoBehaviour
{
    public Text txtScore;
    int currentScore= 0;
    public Text txtLives;
    public AudioSource catchSound;
    public AudioClip soundToPlay;
    


    void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "SpawnItem")
        {
            currentScore += 5;
            txtScore.text = "Score: " + currentScore;
            catchSound.Play();
            Destroy(collision.gameObject);

        }
    }
      
     void Update()
        {

        if (PlayerPrefs.GetInt("DeathParam")==0)
        {   
            if (currentScore > PlayerPrefs.GetInt("HighScore1"))
            {
                PlayerPrefs.SetInt("HighScore1", currentScore);
                
            }
            else if (currentScore > PlayerPrefs.GetInt("HighScore2"))
            {
                PlayerPrefs.SetInt("HighScore2", currentScore);
                
            }
            else if (currentScore > PlayerPrefs.GetInt("HighScore3"))
            {
                PlayerPrefs.SetInt("HighScore3", currentScore);
                
            }
            else if (currentScore > PlayerPrefs.GetInt("HighScore4"))
            {
                PlayerPrefs.SetInt("HighScore4", currentScore);
                
            }
            else if (currentScore > PlayerPrefs.GetInt("HighScore5"))
            {
                PlayerPrefs.SetInt("HighScore5", currentScore);
                
            }
            else if (currentScore > PlayerPrefs.GetInt("HighScore6"))
            {
                PlayerPrefs.SetInt("HighScore6", currentScore);
                
            }
            else if (currentScore > PlayerPrefs.GetInt("HighScore7"))
            {
                PlayerPrefs.SetInt("HighScore7", currentScore);
                
            }
            else if (currentScore > PlayerPrefs.GetInt("HighScore8"))
            {
                PlayerPrefs.SetInt("HighScore8", currentScore);
                
            }
            else if (currentScore > PlayerPrefs.GetInt("HighScore9"))
            {
                PlayerPrefs.SetInt("HighScore9", currentScore);
                
            }
            else if (currentScore > PlayerPrefs.GetInt("HighScore10"))
            {
                PlayerPrefs.SetInt("HighScore10", currentScore);
                
            }
            currentScore = 0;
            
        }

    }
}
