using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoulderTrap : MonoBehaviour
{

    
    public float boulderSpeed;
    public float spinSpeed;
    public Rigidbody2D boulder;



    /* Här kommer jag skriva vad alla funktioner i unity (som jag har använt) gör. void start används när spelet startar 
     * och där lägger man kod som t.ex när man vill sätta in ett värde på en variabel som jag gjorde nedan här.
     * void Update är en funktion vilket används varje frame. Här sätter man kod som man vill ska konstant vara igång 
     * som t.ex kod som checkar om du trycker på en knapp. void OnTriggerEnter är en funktion vilket används när något 
     * kommer i kontakt med en Trigger. Detta används för t.ex att man gör så fiender och spikar dödar dig eller att 
     * göra så man kommer in till nästa level när man kommer i mål. OnTriggerExit används när man slutar kollidera 
     * med en trigger. OnCollisionEnter2D är samma sak som OnTriggerEnter fast istället för Triggers så 
     * aktiveras den när man kommer i kontakt med en vanlig hitbox. FixedUpdate är en funktion lik Update fast till 
     * skillnad från Update kallar den sin kod i en bestämd interval och inte konstant. */

    // Use this for initialization
    void Start()
    {
        // Här sätter jag värdet på hur snabbt min boulder ska röra sig och hur mycket den ska rotera.
        boulderSpeed = 6.55f;
        spinSpeed = 6.55f;
    }

    // Update is called once per frame
    void Update()
    {
        /* Här gör jag så om ens score är lika med eller mer än 9999 (vilket man får av att ta upp diamanten) så 
         * kommer bouldern att få bodytypen Dynamic vilket kommer göra att den kan börja röra på sig och ramlar.
         * Jag gör också så den börjar röra sig på x axeln och rotera.*/ 
        if (Coin.score >= 9999)
        {
            transform.Translate(boulderSpeed * Time.deltaTime, 0, 0, Space.World);
            transform.Rotate(new Vector3(0, 0, -spinSpeed));
            boulder.bodyType = RigidbodyType2D.Dynamic;
            
        }
        
    }
    

}
