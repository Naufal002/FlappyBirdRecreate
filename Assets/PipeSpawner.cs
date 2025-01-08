using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject pipe;
    public float spawenerRate = 2;
    public float heightOffset = 10;
    private float timer = 0;

    // Start is called before the first frame update
    void Start()
    {
        pipeSpawn();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawenerRate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            pipeSpawn();
            timer = 0;
        }

    }
    void pipeSpawn()
    {
        float lowesPoint = transform.position.y - heightOffset;
        float highesPoint = transform.position.y + heightOffset;

        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowesPoint, highesPoint),0), transform.rotation);
    }
}
