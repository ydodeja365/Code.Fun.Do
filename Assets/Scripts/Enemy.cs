using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {
    public static float speed=0.3f;//Setting speed of movement
    public AudioClip[] audios;
    // Use this for initialization
    void Start()
    {
        speed = 0.3f + 0.15f * (Game.currentlevel - 1);
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
   
        if(other.CompareTag("Player"))
        {
            //Debug.Log("Has collided!");
            //Decrease player's health and destroy the spaceship
            FindObjectOfType<Health>().TakeDamage();
            endTrigger();
            GetComponent<AudioSource>().clip=audios[0];
            GetComponent<AudioSource>().Play();
            //Debug.Log("Played Audio!");
            Destroy(this.gameObject,audios[0].length);
        }
        if(other.CompareTag("bullet"))
        {
            //Debug.Log("Shot!");
            Destroy(other.gameObject);
            //Increase player's score and destroy the spaceship
            Game.score += (int)((Game.currentlevel+5) * speed * 20);
            endTrigger();
            GetComponent<AudioSource>().clip = audios[1];
            GetComponent<AudioSource>().Play();
            //Debug.Log("Played Audio!");
            Destroy(this.gameObject, audios[1].length);
            Destroy(this.gameObject);
        }
    
    }
    void endTrigger()
    {
        Game.spaceshipsHit -= 1;
        if (Game.spaceshipsHit>=Game.spawnCount)
            FindObjectOfType<Game>().SpawnNewRobo();
    }
}
