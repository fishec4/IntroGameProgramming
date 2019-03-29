using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeText : MonoBehaviour {
    public Text highScore1;
    public Text highScore2;
    public Text highScore3;
    public Text highScore4;
    public Text highScore5;
    public Text highScore6;
    public Text highScore7;
    public Text highScore8;
    public Text highScore9;
    public Text highScore10;

    void ChangeLeaderboard()
    {
        highScore1.text = "" + PlayerPrefs.GetInt("HighScore1");

        print(PlayerPrefs.GetInt("HighScore1"));

        highScore2.text = "" + PlayerPrefs.GetInt("HighScore2");
        highScore3.text = "" + PlayerPrefs.GetInt("HighScore3");
        highScore4.text = "" + PlayerPrefs.GetInt("HighScore4");
        highScore5.text = "" + PlayerPrefs.GetInt("HighScore5");
        highScore6.text = "" + PlayerPrefs.GetInt("HighScore6");
        highScore7.text = "" + PlayerPrefs.GetInt("HighScore7");
        highScore8.text = "" + PlayerPrefs.GetInt("HighScore8");
        highScore9.text = "" + PlayerPrefs.GetInt("HighScore9");
        highScore10.text = "" + PlayerPrefs.GetInt("HighScore10");
    }

    void Start()
    {
        ChangeLeaderboard();

    }

}
