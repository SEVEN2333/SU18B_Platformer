using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{

    public float moveSpeed = 6f;
    public float jumpSpeed = 12f;

    public GroundChecker groundCheck;

    private Rigidbody2D rbody;

    // Use this for initialization
    void Start()
    {
        // Här hämtar jag Rigidbodyn av det som har scriptet.
        rbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        /* Här gör jag så det som har scriptet kan röra sig åt höger och vänster med knapparna som finns på Horizontal
         * gångrad med hasigheten av moveSpeed.*/
        rbody.velocity = new Vector2(Input.GetAxis("Horizontal") * moveSpeed, rbody.velocity.y);

        // Här gör jag så om knappen som finns på Jump trycks ner och om då isGrounded är true så rör den sig uppåt med jumpSpeed.
        if (Input.GetButtonDown("Jump"))
        {
            if (groundCheck.isGrounded > 0)
            {
                rbody.velocity = new Vector2(rbody.velocity.x, jumpSpeed);
            }
        }
    }
}
