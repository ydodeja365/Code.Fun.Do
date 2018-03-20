using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class GameMenu : MonoBehaviour {
    public Text HighScore;
    private void Start()
    {
        Music.isAlive = true;
        HighScore.text = "HighScore: "+PlayerPrefs.GetInt("Score").ToString();
        Game.score = 0;
        Game.currentlevel = 0;
        Health.health = 0;
    }
    public void Play()
    {
        SceneManager.LoadScene("Game");
    }
    public void Instructions()
    {
        SceneManager.LoadScene("Instructions");
    }
    public void Exit()
    {
        Application.Quit();
    }

}
