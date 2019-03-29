using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class DropSpawn : MonoBehaviour {

    public Text txtLives;
    int currentLives = 3;
    public AudioSource dropSound;
    public AudioClip soundToPlay;
    public AudioSource resetSound;
    public AudioClip anotherSoundToPlay;

    void Reset()
    {
            currentLives = 3;
            txtLives.text = "Lives: " + currentLives;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag== "SpawnItem")
        {
            currentLives--;
            txtLives.text = "Lives: " + currentLives;
            dropSound.Play();
            Destroy(collision.gameObject);
            PlayerPrefs.SetInt("DeathParam", 3);

        }
        if (currentLives == 0)
        {
            PlayerPrefs.SetInt("DeathParam", 0);
            resetSound.Play();
            SceneManager.LoadScene("Leaderboard");
        }


    }
}
