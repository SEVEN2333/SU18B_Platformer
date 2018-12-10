using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreText : MonoBehaviour
{
    private TextMeshProUGUI text;

    // Use this for initialization
    void Start()
    {
        // Här hämtar jag texten som scriptet sitter på.
        text = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        /* Här gör jag så texten skriver ut Score: 0 där 0 är vad din score är. 
        Detta används som en UI för att se dina poäng.*/
        text.text = string.Format("Score: {0}", Coin.score);
    }
}
