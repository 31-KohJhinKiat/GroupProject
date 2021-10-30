using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    //speed
    public int speed;

    //shoot laser
    public bool canShoot = true;
    private float waitTime = 0.1f;
    private float currentTime = 0.0f;
    public GameObject laser;

    //health
    public int playerHealth;

    //audio
    private AudioSource audioSource;
    public AudioClip laserSound;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

        currentTime = currentTime + Time.deltaTime;

        if (Input.GetKey(KeyCode.Space) && canShoot )
        {
            
            if(currentTime >= waitTime)
            {
                audioSource.PlayOneShot(laserSound);
                Vector2 newposition = 
                    new Vector2(transform.position.x, 
                    transform.position.y + 0.8f);
                Instantiate(laser, newposition,
                    transform.rotation);
                currentTime = 0;
            }
            
        }

        if (Input.GetKey(KeyCode.LeftArrow) || transform.position.x >= 10)
        {
            transform.position -= transform.right * speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.RightArrow) || transform.position.x <= -10)
        {
            transform.position += transform.right * speed * Time.deltaTime;
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("obstacles"))
        {
 
            if(collision.gameObject.name == "Asteroid(Clone)")
            {
                playerHealth -= 5;
            }
            else if (collision.gameObject.name == "Asteroid2(Clone)")
            {
                playerHealth -= 10;
            }
            else if (collision.gameObject.name == "Asteroid3(Clone)")
            {
                playerHealth -= 20;
            }

            GameManager.instance.UpdateHealthBar(playerHealth);
           
            Destroy(collision.gameObject);
        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag.Equals("heal"))
        {
            print("heal");
            playerHealth += 20;
            GameManager.instance.UpdateHealthBar(playerHealth);

            if (playerHealth > 100)
            {
                playerHealth = 100;
            }

            Destroy(collision.gameObject);
        }
    }

}
