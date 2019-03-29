using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ButtonFunction : MonoBehaviour {
    public GameObject button;
    public string sceneName;

    public void NextScene(string sceneName)
        {
            Debug.Log("Loaded Scene: Game");
            SceneManager.LoadScene(sceneName);
        }
}
