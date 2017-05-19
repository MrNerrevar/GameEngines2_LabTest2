using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeeSpawner : MonoBehaviour
{

    public GameObject hivePrefab;

    // Use this for initialization
    void Start()
    {
        StartCoroutine(SpawnBees());
    }

    Vector3 SpawnPos()
    {
        return transform.position + new Vector3(Random.Range(-4, -6), -0.5f, Random.Range(-4, 6));
    }

    System.Collections.IEnumerator SpawnBees()
    {
        while (true)
        {
            GameObject[] bees = GameObject.FindGameObjectsWithTag("bee");
            if (bees.Length < 10)
            {
                GameObject bee = GameObject.Instantiate<GameObject>(hivePrefab);
                bee.transform.position = SpawnPos();
                bee.transform.parent = this.transform;
            }
            yield return new WaitForSeconds(2);
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}
