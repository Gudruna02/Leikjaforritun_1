 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Rigidbody rb;

    private void OnCollisionEnter(Collision collision)
    {
        // Ef hitt á obstacle tag(bomba)
        if (collision.collider.tag == "Obstacle")
        {
            // Eyðir frá gameObject
            Destroy(collision.gameObject);
            // Óvirkar gameObject
            gameObject.SetActive(false);
        }

        else if (collision.collider.name != "Player")
        {
            // Óvirkar gameObject
            gameObject.SetActive(false);
        }
    }

}
