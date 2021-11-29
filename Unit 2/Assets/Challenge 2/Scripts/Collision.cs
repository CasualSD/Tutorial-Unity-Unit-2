using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    private Rigidbody rb;
    private float Fly = 5f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
       
    }


    private void OnCollisionEnter(UnityEngine.Collision collision)
    {
        if (collision.collider.name == "Blocky")
        {
            rb.mass = 25f;
            rb.useGravity = false;
            rb.AddForce(transform.forward * Fly);
        }
    }
}
