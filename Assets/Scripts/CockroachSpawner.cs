using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CockroachSpawner : MonoBehaviour
{
    public GameObject cockroach;
    public Transform spawnPoint;

    bool maxReached = false;

    public void MaxReached()
    {
        maxReached = true;
    }

    public void MinReached()
    {
        if (maxReached)
        {
            GameObject newCockroach = Instantiate(cockroach, spawnPoint);
        }

        maxReached = false;
    }
}
