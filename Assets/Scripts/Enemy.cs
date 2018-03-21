using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {
    private const string MethodName = "playMusic";
    public static float speed=0.3f;//Setting speed of movement
    public AudioClip[] audios;
    private bool wasShot;
    private bool collided;
    ParticleSystem p;
    // Use this for initialization
    void Start()
    {
        wasShot = false;
        collided = false;
        speed = 0.3f + 0.15f * (Game.currentlevel - 1);
        p  = GetComponent<ParticleSystem>();
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
            collided = true;
            //Debug.Log("Has collided!");
            //Decrease player's health and destroy the spaceship
            FindObjectOfType<Health>().TakeDamage();
            p.Play();
            Invoke(MethodName,p.main.duration-0.5f);
        }
        if(other.CompareTag("bullet"))
        {
            wasShot = true;
            //Debug.Log("Shot!");
            Destroy(other.gameObject);
            //Increase player's score and destroy the spaceship
            Game.score += (int)((Game.currentlevel+5) * speed * 20);

            p.Play();
            Invoke(MethodName,p.main.duration-0.5f);
        }
    
    }
    void endTrigger()
    {
        Game.spaceshipsHit -= 1;
        if (Game.spaceshipsHit>=Game.spawnCount)
            FindObjectOfType<Game>().SpawnNew();
    }
    void playMusic()
    {
        int i;
        if (wasShot)
            i = 1;
        else
            i = 0;
        GetComponent<AudioSource>().clip = audios[i];
        GetComponent<AudioSource>().Play();
        //Debug.Log("Played Audio!");
        endTrigger();
        Destroy(this.gameObject, audios[i].length);
    }
}
