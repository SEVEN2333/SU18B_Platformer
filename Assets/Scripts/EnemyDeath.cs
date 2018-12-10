using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDeath : MonoBehaviour
{

    public SpriteRenderer mobSprite;
    public Sprite mobDead;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Trap")
        {
            mobSprite.sprite = mobDead;
            Destroy(gameObject, 3);
            EnemyHorizontalMovement.mobAlive = false;
        }
    }
}
