using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHorizontalMovement : MonoBehaviour
{
    public float speed = 2f;
    public bool left = true;
    public static bool mobAlive;


    private Rigidbody2D rbody;
    // Use this for initialization
    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
        mobAlive = true;
    }
    // Här så hämtar jag Rigidbodyn av objeket som scripten sitter på.
    private void FixedUpdate()
    {
        
        // Här gör jag så om left är true så rör sig fienden åt vänster och vänder samtidigt sin sprite åt vänster.
        // Jag castar också om Vector3n till en Vector2 därmed att jag inte behöver z axeln.
        if (left == true)
        {
            rbody.velocity = -(Vector2)transform.right * speed;
            transform.localScale = new Vector3(1, 1, 1);
        }
        // Här gör jag så om left inte är true så rör sig fienden åt höger och vänder sin sprite åt höger.
        else
        {
            rbody.velocity = (Vector2)transform.right * speed;
            transform.localScale = new Vector3(-1, 1, 1);
        }
        //Här gör jag så om mobAlive är false så slutar den att röra på sig.
        if (mobAlive == false)
        {
            rbody.velocity = new Vector2(0, 0);
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        /* Här gör jag så om något med detta scriptet kolliderar med något med tagen InvisibleWall 
           så kommer den att börja röra sig åt andra hållet. */
        if(collision.tag == "InvisibleWall")
        {
        left = !left;
        }
    }
}
