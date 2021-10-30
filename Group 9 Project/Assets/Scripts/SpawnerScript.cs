using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
    //asteroids
    public GameObject SpawnObject1;
    public GameObject SpawnObject2;
    public GameObject SpawnObject3;
    public GameObject SpawnObject4;

    //y position
    float PositionX;

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
        PositionX = Random.Range(10, -10f);
        this.transform.position = new Vector3(PositionX, transform.position.y , transform.position.z);
        
        int RandomNumber = Random.Range(0, 5);

        if (RandomNumber == 0)
        {
            Instantiate(SpawnObject1, transform.position, transform.rotation);
        }

        else if (RandomNumber == 1)
        {
            Instantiate(SpawnObject2, transform.position, transform.rotation);
        }

        else if (RandomNumber == 2)
        {
            Instantiate(SpawnObject2, transform.position, transform.rotation);
        }

        else if (RandomNumber == 3)
        {
            Instantiate(SpawnObject3, transform.position, transform.rotation);
        }

        else if (RandomNumber == 4)
        {
            Instantiate(SpawnObject4, transform.position, transform.rotation);
        }

    }

}
