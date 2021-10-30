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

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        currentTime = currentTime + Time.deltaTime;

        if (Input.GetKey(KeyCode.Space) && canShoot )
        {
            
            if(currentTime >= waitTime)
            {
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
}
