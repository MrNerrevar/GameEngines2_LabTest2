using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class SteeringBehaviour : MonoBehaviour
{

    public bool active;
    public float weight;
    public abstract Vector3 Calculate();
    [HideInInspector]
    public Boid boid;

    public void Awake()
    {
        boid = this.GetComponent<Boid>();
        active = true;
    }
}