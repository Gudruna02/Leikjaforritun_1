using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinControl : MonoBehaviour
{
    void Update()
    {
        // Gullpeningar snúa
        transform.Rotate(new Vector3(0, 0, 80) * Time.deltaTime);
    }
}
