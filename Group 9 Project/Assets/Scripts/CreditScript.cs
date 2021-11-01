using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreditScript : MonoBehaviour
{
    public int creditSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y >= 800)
        {
            transform.position = 
                new Vector3(Screen.width / 2, -600, 0);
        }


        transform.position = 
            transform.position + 
            new Vector3(0, creditSpeed * Time.deltaTime, 0);
    }
}
