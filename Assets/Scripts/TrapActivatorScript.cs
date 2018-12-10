using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapActivatorScript : MonoBehaviour
{
    public Rigidbody2D boulder;
    public float boulderSpeed;
    public float spinSpeed;

    // Use this for initialization
    void Start()
    {
        boulderSpeed = 5f;
        spinSpeed = 5f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            boulder.bodyType = RigidbodyType2D.Dynamic;
        }
    }
}
