using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Obstacle : MonoBehaviour
{
    public GameObject Explosion;

    private void Update()
    {
        // Ef dettur niður
        if (transform.position.y < -10)
        {
            // Eyða object
            Destroy(gameObject);
            gameObject.SetActive(false);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Bullet")
        {
            // Kallar á föll Explo
            Explo();
            Destroy(gameObject);
            gameObject.SetActive(false);
        }
    }

    void Explo()
    {
        // Explosion effect
        Instantiate(Explosion, transform.position, transform.rotation);
    }
}
