using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour {
    public static int currentlevel;
    public GameObject[] spaceships;
    public static int robosHit;
    public static long score;
    Vector3 newpos;
    private bool started;
    private int spawnCount;
    private bool levelEnd;
    public static int signx, signy, signz;
    // Use this for initialization
    void Start () {
        levelEnd = false;
        spawnCount = 3;
        currentlevel = 1;
        robosHit = currentlevel*7/5;
        started = false;
        score = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if(!started)
        {
            started = true;
            for (int i = 0; i < spawnCount; i++)
                SpawnNewRobo();
        }
        if(robosHit==0)
        {
            levelEnd = true;
            if (spawnCount < 8)
            {
                spawnCount *= 7 / 5;
            }
            currentlevel += 1;
            Enemy.speed += 0.15f;
        }
	}
    public void SpawnNewRobo()
    {
        GameObject spaceship = spaceships[Random.Range(0, 2)];
        signx = Random.Range(0,2);
        signy = Random.Range(0, 2);
        signz = Random.Range(0, 2);
        signx = (signx == 0) ? -1 : 1;
        signy = (signy == 0) ? -1 : 1;
        signz = (signz == 0) ? -1 : 1;
        newpos = new Vector3(signx*(1+Random.Range(0,6.25f)),signy*(1+Random.Range(0f,4f)),signz*(1+Random.Range(0f,8f)));
        Instantiate(spaceship,newpos,Quaternion.Euler(0f,0f,0f));
    }
}
