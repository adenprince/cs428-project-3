using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyDeath : MonoBehaviour
{
    public FlySpawner flySpawner;
    public AudioSource flyDeathSound;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Swatter")
        {
            flySpawner.DecrementNumFlies();
            flyDeathSound.Play();
            Destroy(gameObject);
        }
    }
}
