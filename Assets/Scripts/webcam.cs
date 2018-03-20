using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class webcam : MonoBehaviour {
    public GameObject plane;    //Reference to the plane that renders camera feed
    Quaternion newRotation;     //Storing new rotation in every frame

    void Start () {
        if(Application.isMobilePlatform)//If platform is mobile platform
        {
            // Mobile specific code needed to render correctly in landscape mode`
            GameObject cameraParent = new GameObject("camParent");
            cameraParent.transform.position = this.transform.position;
            this.transform.parent = cameraParent.transform;
            cameraParent.transform.Rotate(Vector3.right,90);
        }
        //Enabling gyro readings for device:
        Input.gyro.enabled = true;
        //Rendering webcam feed on the plane
        WebCamTexture webCamTexture = new WebCamTexture();
        plane.GetComponent<MeshRenderer>().material.mainTexture = webCamTexture;
        //Playing the feed
        webCamTexture.Play();
		
	}
	
	// Update is called once per frame
	void Update () {
        //Changing camera rotation based on gyro values
        newRotation =new Quaternion(Input.gyro.attitude.x,Input.gyro.attitude.y, -Input.gyro.attitude.z, -Input.gyro.attitude.w);
        this.transform.localRotation =newRotation;
	}
}
