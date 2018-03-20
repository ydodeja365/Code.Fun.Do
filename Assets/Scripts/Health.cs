using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Health : MonoBehaviour {
    public Image ActiveBar;
    public Image BackBar;
    public int damage=10;
    public static int health;
    public Text healthtext;
    public AudioClip gameover;
    private void Start()
    {
        healthtext.text = (100 - health).ToString();
        ActiveBar.transform.localScale = new Vector3((100-health)/100f, 1, 1);
    }
    public void TakeDamage()
    {
        health += damage;
        //Debug.Log(health);
        if((100-health)<=0)
        {
            SceneManager.LoadScene("Game Over");
        }
        float ratio= (100-health) / 100f;
        ActiveBar.transform.localScale=new Vector3(ratio,1,1);
        healthtext.text = (100-health).ToString();
    }
}
