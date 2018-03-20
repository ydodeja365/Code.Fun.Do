using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {
    public Text score;
	void Start () {
        Health.health = 0;
        Music.isAlive = false;
        int high = PlayerPrefs.GetInt("Score");
        if(Game.score>high)
        {
            PlayerPrefs.SetInt("Score", Game.score);
        }
        score.text = "Score: " + Game.score.ToString();
	}
	public void GotoMainMenu()
    {
        SceneManager.LoadScene("GameMenu");
    }
    public void Quit()
    {
        Application.Quit();
    }
}
