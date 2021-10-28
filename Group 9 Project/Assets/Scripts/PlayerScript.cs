using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    //speed
    public int speed;

    //shoot laser
    public bool canShoot = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space) && canShoot)
        {
            //shoot laser
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
