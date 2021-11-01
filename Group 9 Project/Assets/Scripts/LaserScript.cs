using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserScript : MonoBehaviour
{
    public int laserSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * 
            Time.deltaTime * laserSpeed);
        if (transform.position.y > 10)
        {
            Destroy(gameObject);
        }
    }

}
