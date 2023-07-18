using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class balloonSpawner : MonoBehaviour
{
    public float min, max;
    public GameObject[] Balloons;
    public float maxTime;
    float currentTime = 0;
    void Start()
    {

    }

    void Update()
    {
        currentTime += Time.deltaTime;
        if (currentTime >= maxTime)
        {
            currentTime = 0;
            Instantiate(Balloons[Random.Range(0,Balloons.Length)],
                new Vector3(Random.Range(min,max),this.transform.position.y,0),Quaternion.identity);
        }
    }
}
