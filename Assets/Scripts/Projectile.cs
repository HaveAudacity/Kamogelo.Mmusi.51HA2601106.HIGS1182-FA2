using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed = 20f;

    void Start()
    {
        Launch();
    }
    // Launches the laser forward using physics velocity, and schedules it to
    // self-destruct after 3 seconds so stray lasers don't clutter the scene
    void Launch()
    {
        GetComponent<Rigidbody>().linearVelocity = transform.forward * speed;
        Destroy(gameObject, 3f);
        Debug.Log("Laser launched");
    }
    void Update()
    {

    }

    
}