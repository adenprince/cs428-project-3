using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlySpawner : MonoBehaviour
{
    public GameObject fly;
    public Transform spawnPoint;
    public int maxNumFlies;

    bool maxReached = true;
    int numFlies = 0;

    public void MaxReached()
    {
        maxReached = true;
    }

    public void MinReached()
    {
        if (maxReached && numFlies < maxNumFlies)
        {
            GameObject newFly = Instantiate(fly, spawnPoint);
            newFly.GetComponent<FlyDeath>().flySpawner = gameObject.GetComponent<FlySpawner>();
            newFly.GetComponent<FlyDeath>().flyDeathSound = spawnPoint.GetComponent<AudioSource>();
            newFly.transform.localPosition = new Vector3(0f, Random.Range(-0.3f, 0.3f), Random.Range(-0.5f, 0.5f));
            ++numFlies;
        }

        maxReached = false;
    }

    public void DecrementNumFlies()
    {
        --numFlies;
    }
}
