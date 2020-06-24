using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject[] Obstacles;
    float PositionX;
    int i;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PositionX = Random.Range(-2.5f, 2.5f);
        int Spawn = Random.Range(0, 4);

        if(Time.time > i)
        {
            i += 1;
            this.transform.position = new Vector3(PositionX, transform.position.y, transform.position.z);
            Instantiate(Obstacles[Spawn], transform.position, transform.rotation);
        }
    }
}
