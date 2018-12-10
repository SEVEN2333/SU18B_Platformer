using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetSpriteInvisible : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        /* Här gör jag så när spelet startar så hämtar jag alla components med scriptet på 
         * och stänger av spriterenderen på dom. Man använder detta för att göra saker osynliga 
           som man inte vill att spelaren ska se. */
        GetComponent<SpriteRenderer>().enabled = false;
    }
}
