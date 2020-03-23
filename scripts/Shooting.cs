using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject bullet;
    public float speed = 100f;
    void Update()
    {
        // Ef ýtt á "q"
        if (Input.GetKeyDown("q"))
        {
            Debug.Log("skjota");
            // Skjótta
            GameObject instBullet = Instantiate(bullet, transform.position, Quaternion.identity) as GameObject;
            Rigidbody instBulletRigidbody = instBullet.GetComponent<Rigidbody>();
            instBulletRigidbody.AddForce(transform.forward * speed);
            Destroy(instBullet, 0.5f);//kúla eytt eftir 0.5sek

        }
    }
}
