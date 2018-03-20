using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour {
    public static bool isAlive = true;
    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }
    private void Start()
    {
        Music[] objects= FindObjectsOfType<Music>();
        foreach(Music m in objects)
        {
            if (!m.Equals(this))
                Destroy(this.gameObject);
        }
    }
    private void Update()
    {
        if (!isAlive)
            Destroy(this.gameObject);
    }
}
