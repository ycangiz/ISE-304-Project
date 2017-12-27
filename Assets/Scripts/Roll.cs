using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;
public class Roll : NetworkBehaviour{

    GameObject dice;
    
    private void Start()
    {
        GameObject[] textFields = GameObject.FindGameObjectsWithTag("DiceValText");
        for (int i = 0; i < 2; i++)
        {
            textFields[i].GetComponent<Text>().text = "";
        }
            dice = gameObject;
    }

    public void RollDice()
    {
        
        dice = Instantiate(gameObject);
        Rigidbody rb = dice.GetComponent<Rigidbody>();
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
