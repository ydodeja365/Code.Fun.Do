using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shoot : MonoBehaviour {
    public Text lText;
    public Text sText;
    public GameObject bullet;
    private void Update()
    {
        lText.text = "Level: " + Game.currentlevel.ToString();
        sText.text = "Score: " + Game.score.ToString();
    }
    public void shootBullet()
    {
        GameObject b = Instantiate(bullet, transform.position, Quaternion.Euler(0, 0, 0));
        Rigidbody rb = b.GetComponent<Rigidbody>();
        b.transform.rotation = Camera.main.transform.rotation;
        b.transform.position = Camera.main.transform.position;
        rb.AddForce(Camera.main.transform.forward * 500f);
        Destroy(b, 3);
    }

}
