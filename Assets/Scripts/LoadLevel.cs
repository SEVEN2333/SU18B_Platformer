using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevel : MonoBehaviour
{
    public string sceneToLoad = "Level0";
    public int minimumScoreNeeded = 0;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        /* Här gör jag så om något med tagen Player och man har tillräckligt med poäng av coinen så laddas en scene 
        och poängen blir 0. Detta används vid mål i slutet av banorna för att ladda en ny nivå.*/
        if(collision.tag == "Player" && Coin.score >= minimumScoreNeeded)
        {
            SceneManager.LoadScene(sceneToLoad);
            Coin.score = 0;
        }
    }
}
