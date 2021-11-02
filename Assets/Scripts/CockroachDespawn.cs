using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CockroachDespawn : MonoBehaviour
{
    void Start()
    {
        StartCoroutine("Despawn");
    }

    IEnumerator Despawn()
    {
        yield return new WaitForSeconds(2.0f);

        Destroy(gameObject);
    }
}
