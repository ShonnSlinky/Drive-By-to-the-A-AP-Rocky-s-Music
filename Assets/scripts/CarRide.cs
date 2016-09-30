using UnityEngine;
using System.Collections;

public class CarRide : MonoBehaviour {

    Vector3 velocity = Vector3.zero;
    public float forwardspeed = 3f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        velocity.x = forwardspeed;
        transform.position += velocity * Time.deltaTime; 
	}
}
