using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float TopxBound = 30f;
    private float BottomxBound = -10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > TopxBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < BottomxBound)
        {
            Debug.Log("Game Over!");
            Destroy(gameObject);
        }
    }
}
