using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seek : SteeringBehaviour
{
    public GameObject target;

    public override Vector3 Calculate()
    {
            return boid.SeekForce(target.transform.position);
    }
}