using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    /* Statics är variabler som kan kallas på i andra script. Vi använder den för scoren 
     * för den behövs sen kallas på i ScoreText scriptet för att vi ska kunna se våra poäng.*/
    public static int score;
    public int amount = 1;
    private float spinSpeed = 180;

    private void OnTriggerEnter2D(Collider2D collision)
    {
            // Här så gör jag så när något med tagen Player kolliderar med coinens hitbox så ökar scoren med hur mycket coinen är värd 
            // och coinen förstörs också efter dom kolliderat.
        if(collision.tag == "Player")
        {
            Coin.score += amount;
            Destroy(gameObject);
        }
    }
    private void Update()
    {
        // Här så gör jag så coinen roterar så det ser ut som en animation av ett snurrande coin.
        transform.Rotate(0, spinSpeed * Time.deltaTime, 0);
    }
}
