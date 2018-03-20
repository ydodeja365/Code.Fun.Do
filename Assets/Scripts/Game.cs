using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game : MonoBehaviour {
    public static int currentlevel;
    public GameObject[] spaceships;
    public static int spaceshipsHit;
    public static int score;
    Vector3 newpos;
    private bool started;
    public static int spawnCount;
    public static int signx, signy, signz;
    private float spawnDist;
    // Use this for initialization
    void Start () {
        spawnCount = currentlevel/5+2 ;
        spaceshipsHit =2 + (currentlevel) * 5 / 2;
        started = false;
        spawnDist = currentlevel + 1.5f;
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
	}
	
	// Update is called once per frame
	void Update () {
		if(!started)
        {
            started = true;
            for (int i = 0; i < spawnCount; i++)
                SpawnNewRobo();
        }
        if(spaceshipsHit==0&&Health.health!=100)
        {
            currentlevel += 1;
    
            SceneManager.LoadScene("Level Up");
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
        newpos = new Vector3(signx*(spawnDist+Random.Range(0,6.25f)),signy*(spawnDist+Random.Range(0f,4f)),signz*(spawnDist+Random.Range(0f,8f)));
        Instantiate(spaceship,newpos,Quaternion.Euler(0f,0f,0f));
    }
}
