using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour {
    public static float speed=0.3f;//Setting speed of movement
    // Use this for initialization
    void Start()
    {
  
    }

    // Update is called once per frame
    void Update()
    {
        float step = speed * Time.deltaTime;
        transform.LookAt(Camera.main.transform.position);
        transform.position = Vector3.MoveTowards(transform.position, Camera.main.transform.position, step);
    }
    void OnTriggerEnter(Collider other)
    {
        //Debug.Log("Has collided!");
        if(other.CompareTag("Player"))
        {
            //Decrease player's health and destroy the robo
            endTrigger();
            Destroy(this.gameObject);

        }
        if(other.CompareTag("bullet"))
        {
            //Debug.Log("Shot!");
            Destroy(other.gameObject);
            //Increase player's score and destroy the robo
            Game.score += (long)(Game.currentlevel * speed * 20);
            endTrigger();
            Destroy(this.gameObject);
        }
    
    }
    void endTrigger()
    {
        Game.robosHit -= 1;
        if (Game.robosHit != 0)
            FindObjectOfType<Game>().SpawnNewRobo();
        else
            SceneManager.LoadScene("Level Up");
    }
}
