using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidScript : MonoBehaviour
{
    //enemy speed
    public int enemySpeed;

    //enemy health
    public int enemyHealth;
    
    //enemy score
    public int enemyScore;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= 
            transform.up * enemySpeed * Time.deltaTime;
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
                GameManager.instance.Explosion(gameObject);
                GameManager.instance.addScore(enemyScore);
                
            }

            Destroy(collision.gameObject);
        }
    }

}
