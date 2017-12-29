using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using GamerClass;

public class Money : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        gameObject.GetComponent<Text>().text = "$" + GameObject.FindGameObjectWithTag("Player").GetComponent<Gamer>().money;
	}
}
