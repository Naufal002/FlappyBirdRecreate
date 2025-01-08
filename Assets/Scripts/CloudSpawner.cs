using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudSpawner : MonoBehaviour
{
    public GameObject cloud;
    public float spawnerRate = 2;
    public float heightOffset = 10;
    private float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnerRate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            cloudspawn();
            timer = 0;
        }
    }

    void cloudspawn()
    {
        float lowesPoint = transform.position.y - heightOffset;
        float highesPoint = transform.position.y + heightOffset;

        Instantiate(cloud, new Vector3(transform.position.x, Random.Range(lowesPoint, highesPoint), 0), transform.rotation);
    }
}
