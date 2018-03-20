using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Walk : MonoBehaviour {
    Vector3 pos;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        pos = this.transform.position;
        if (Input.acceleration.z <= -0.01f)
        {
            pos.z +=Time.deltaTime;
            this.transform.position = pos;
        }
        if(pos.z>=4.8f && pos.y<=0&&pos.y>-5&&pos.x<1.7f&&pos.x>-1.8f)
        {
            SceneManager.LoadScene("GameMenu");
        }
	}
}
