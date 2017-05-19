using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Boid : MonoBehaviour {

    public Vector3 force = Vector3.zero;
    public Vector3 acceleration = Vector3.zero;
    public Vector3 velocity = Vector3.zero;
    public float mass = 1;
    public float maxSpeed = 5.0f;

    SteeringBehaviour[] behaviours;

	// Use this for initialization
	void Start () {
        behaviours = this.GetComponents<SteeringBehaviour>();
	}

    private void FixedUpdate()
    {
        behaviours = this.GetComponents<SteeringBehaviour>();
        force = CalculateForces();
        acceleration = acceleration * Time.deltaTime;
        if (velocity.magnitude > 0.0001f)
        {
            transform.LookAt(transform.position + velocity);
            velocity *= 0.99f;
        }
        this.transform.position += velocity;
    }

    Vector3 CalculateForces()
    {
        Vector3 newForce = Vector3.zero;
        foreach (SteeringBehaviour behave in behaviours)
        {
            newForce += (behave.Calculate() * behave.weight);
        }
        return newForce;
    }

    public Vector3 SeekForce(Vector3 target)
    {
        return ((target - this.transform.position).normalized) * maxSpeed;
    }
	
}
