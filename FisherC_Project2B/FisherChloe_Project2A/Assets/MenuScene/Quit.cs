using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Quit : MonoBehaviour {
    public GameObject quitButton;
    public void QuitGame()
    {
        print("QUIT");
        Application.Quit();
    }
}
