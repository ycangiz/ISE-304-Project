using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceScript : MonoBehaviour {


    Vector3 epicentre;

	// Use this for initialization
	void Start () {
        epicentre = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(Collision collision)
    {
        GameObject dice = GameObject.FindGameObjectWithTag("Dice");
        Rigidbody rb = dice.GetComponent<Rigidbody>();
        rb.AddExplosionForce(700, epicentre, 5, 3);
    }
}
