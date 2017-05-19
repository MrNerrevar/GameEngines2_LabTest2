using UnityEngine;
using System.Collections;

public class Bee : MonoBehaviour {

    public GameObject target;
    public GameObject bee;
    public Boid boid;
	// Use this for initialization
	void Start () {
        //bee = this.GetComponent<Boid>();
        transform.localScale = new Vector3(-1, 2, -1);
	}
	
	// Update is called once per frame
	void Update () {
	    transform.position = ((target.transform.position - this.transform.position).normalized) * 5.0f;
    }
}
