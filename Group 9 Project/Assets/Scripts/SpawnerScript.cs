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

    public GameObject SpawnObjects()
    {
        PositionX = Random.Range(10, -10f);
        this.transform.position = new Vector3(PositionX, 
            transform.position.y , transform.position.z);
        
        int random = Random.Range(1, 5);
        GameObject asteroid;
        switch (random)
        {
            case 1:
                asteroid = Instantiate(SpawnObject1, 
                    transform.position, transform.rotation);
                break;
            case 2:
                asteroid = Instantiate(SpawnObject2,
                    transform.position, transform.rotation);
                break;
            case 3:
                asteroid = Instantiate(SpawnObject3,
                    transform.position, transform.rotation);
                break;
            case 4:
                asteroid = Instantiate(SpawnObject4,
                    transform.position, transform.rotation);
                break;
            default:
                asteroid = Instantiate(SpawnObject1,
                    transform.position, transform.rotation);
                break;
        }

        return asteroid;
    }

}
