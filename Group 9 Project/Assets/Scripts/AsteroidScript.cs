using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidScript : MonoBehaviour
{
    public int enemySpeed;
    public GameObject Explosion;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * Time.deltaTime * enemySpeed);
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

    private void OnDestroy()
    {
        GameObject TempExplosion = Instantiate(Explosion, transform.position, transform.rotation);
        Destroy(TempExplosion, 0.5f);
    }
}
