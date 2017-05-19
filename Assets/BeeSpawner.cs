using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeeSpawner : MonoBehaviour
{
    //Failed at using the boid and steeringbehaviour scripts. 
    //Attempted to accomplish bee spawning and behaviours through the same method as the flower spawns.
    public GameObject hivePrefab;

    public float pollenCount = 10;

    // Use this for initialization
    void Start()
    {
        StartCoroutine(SpawnBees());
    }

    Vector3 SpawnPos()
    {
        return transform.position + new Vector3(Random.Range(-4, -6), -0.5f, Random.Range(4, 6));
    }

    System.Collections.IEnumerator SpawnBees()
    {
        while (true)
        {
            GameObject[] bees = GameObject.FindGameObjectsWithTag("bee");
            if (bees.Length < 10 && pollenCount > 4)
            {
                GameObject bee = GameObject.Instantiate<GameObject>(hivePrefab);
                bee.transform.position = SpawnPos();
                bee.transform.parent = this.transform;
                pollenCount -= 5;
            }
            yield return new WaitForSeconds(2);
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}
