using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AndroidBack : MonoBehaviour {

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }
    void FixedUpdate()
        {
            if (Application.platform == RuntimePlatform.Android)
            {
                if (Input.GetKey(KeyCode.Escape))
                {
                    Application.Quit();
                }
            }
        }
}
