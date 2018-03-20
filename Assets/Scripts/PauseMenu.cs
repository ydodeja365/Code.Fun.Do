using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour {

	// Use this for initialization
	public static bool paused;
    public GameObject pauseMenu;
    // Update is called once per frame
    void Update () {
		
	}
    public void Pause()
    {
        FindObjectOfType<webcam>().enabled = false;
        paused = true;
        Time.timeScale = 0;
        pauseMenu.SetActive(true);
    }
    public void Resume()
    {
        FindObjectOfType<webcam>().enabled = true;
        paused = false;
        Time.timeScale = 1f;
        pauseMenu.SetActive(false);
    }
    public void Menu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("GameMenu");
    }
    public void Quit()
    {
        Application.Quit();
    }
}
