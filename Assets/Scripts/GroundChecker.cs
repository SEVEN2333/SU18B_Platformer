using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundChecker : MonoBehaviour
{
    public int isGrounded;
   

    private void OnTriggerExit2D(Collider2D collision)
    {
        // Här gör jag så när hitboxen inte är i kontakt med en annan hitbox så görs isGrounded till false.
        isGrounded--;
    }


    private void OnTriggerEnter2D(Collider2D collision)
    
    {
        // Här gör jag så när hitboxen är i kontakt med en annan hitbox så görs isGrounded till true.
        isGrounded ++;
    }
    private void Update()
    {
        /* Här gör jag så om isGrounded är mer än 1 så kommer isGrounded bli 1. Detta var för att fixa en bugg 
         med att isGrounded gick upp när man tog upp en coin och man kunde därmed hoppa när som helst för 
         isGrounded blev mer än 1. */
        if(isGrounded > 1)
        {
            isGrounded = 1;
        }
    }
}
