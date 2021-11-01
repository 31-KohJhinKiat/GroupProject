using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class background : MonoBehaviour
{
    public float BG_speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y <= -10)
        {
            transform.position = new Vector3(0, 10, 0);
        }

        transform.position -= 
            transform.up * BG_speed * Time.deltaTime;
    }
}
