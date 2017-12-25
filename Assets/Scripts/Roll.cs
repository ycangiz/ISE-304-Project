using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Roll : MonoBehaviour {

    Rigidbody rb;
    
    // Use this for initialization
	void Start () {

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void RollDice()
    {
        rb = GetComponent<Rigidbody>();
        int r = Random.Range(0, 1);
        if (r == 0)
        {
            rb.AddTorque(Random.Range(0, 1000) % 10, Random.Range(0, 1000) % 10, Random.Range(0, 1000) % 10);
            rb.AddForce(Random.Range(0, 1000) % 10 * 20, Random.Range(0, 1000) % 10 * 20, Random.Range(0, 1000) % 10 * 20);
        }
        else
        {
            rb.AddForce(-Random.Range(0, 1000) % 10 * 20, -Random.Range(0, 1000) % 10 * 20, -Random.Range(0, 1000) % 10 * 20);
            rb.AddTorque(-Random.Range(0, 1000) % 10, -Random.Range(0, 1000) % 10, -Random.Range(0, 1000) % 10);
        }

    }
}
