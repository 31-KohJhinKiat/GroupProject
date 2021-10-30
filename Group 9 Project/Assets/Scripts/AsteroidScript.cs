﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidScript : MonoBehaviour
{
    //enemy speed
    public int enemySpeed;

    //enemy health
    public int enemyHealth;

    //enemy explosion
    public GameObject Explosion;

    //enemy score
    public int enemyScore;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= transform.up * enemySpeed * Time.deltaTime;
        if (transform.position.y < -10)
        {
            Destroy(gameObject);
        }
    }


    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("projectile"))
        {
            print("shot down");
            enemyHealth--;
            if (enemyHealth <= 0)
            {
                GameManager.instance.addScore(enemyScore);
                GameObject TempExplosion = Instantiate(Explosion, transform.position, transform.rotation);
                Destroy(TempExplosion, 0.5f);
                Destroy(gameObject);
            }
            Destroy(collision.gameObject);
        }
    }
}
