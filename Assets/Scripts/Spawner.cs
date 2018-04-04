using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Spawner : MonoBehaviour
{
    public GameObject enemy = null;
    public int count = 3;
    public float wait = .5f;
    public float startWait = 1;
    public float waveWait = 4;
    public Transform[] points;

    float timer = 0;
    // Use this for initialization
    void Start()
    {

        timer = count;


    }

    void Update()
    {
        timer += Time.deltaTime;
        if(timer >= count)
        {
            for (int i = 0; i < count; i++)
            {
                int spawnIdx = Random.Range(0, points.Length);
                Instantiate(enemy, points[spawnIdx].position, points[spawnIdx].rotation);
            }
            timer = 0;
        }
    }
}
