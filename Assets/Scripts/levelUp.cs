using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class levelUp : MonoBehaviour {
    public Text levelup;
    public Text score;
	// Use this for initialization
	void Start () {
        levelup.text = "Level " + Game.currentlevel.ToString() + " Complete!";
        score.text = "Score:" + Game.score.ToString();
        if(Game.score>PlayerPrefs.GetInt("Score"))
        {
            PlayerPrefs.SetInt("Score", Game.score);
        }
	}
    public void NextLevel()
    {
        SceneManager.LoadScene("Game");
    }
    public void Quit()
    {
        SceneManager.LoadScene("GameMenu");
    }
}
