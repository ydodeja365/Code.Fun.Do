using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Display : MonoBehaviour {

	// Use this for initialization
	void Start () {
        this.transform.position = Camera.main.transform.position + new Vector3(0f,-1.24f,5f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
