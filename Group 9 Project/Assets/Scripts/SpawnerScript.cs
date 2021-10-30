using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
    //asteroids
    public GameObject SpawnObject1;
    public GameObject SpawnObject2;

    //y position
    float PositionY;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObjects", 1, 1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnObjects()
    {
        PositionY = Random.Range(4, -4f);
        this.transform.position = new Vector3(transform.position.x, PositionY, transform.position.z);
        
        int RandomNumber = Random.Range(0, 2);

        if (RandomNumber == 0)
        {
            Instantiate(SpawnObject1, transform.position, transform.rotation);
        }

        else if (RandomNumber == 1)
        {
            Instantiate(SpawnObject2, transform.position, transform.rotation);
        }
        



    }

}
