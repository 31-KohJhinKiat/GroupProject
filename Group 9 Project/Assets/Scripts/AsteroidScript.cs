using System.Collections;
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

    public void OnCollisionEnter2D(Collision2D collision)
    {
       
        if (collision.gameObject.tag.Equals("Player"))
        {
            print("collision");
            Destroy(gameObject);
        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("projectile"))
        {
            print("shot");
            enemyHealth--;
            if (enemyHealth <= 0)
            {
                Destroy(gameObject);
            }
            Destroy(collision.gameObject);
        }
    }

    private void OnDestroy()
    {
        GameObject TempExplosion = Instantiate(Explosion, transform.position, transform.rotation);
        Destroy(TempExplosion, 0.5f);
    }
}
